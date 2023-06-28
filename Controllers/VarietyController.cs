using KestenTestApp.Contracts;
using KestenTestApp.Models.Data;
using KestenTestApp.Models.EnumHelpers;
using KestenTestApp.Models.Enums;
using KestenTestApp.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace KestenTestApp.Controllers
{
    public class VarietyController : BaseController
    {
        private readonly IVarietyService _varietyService;
        private readonly ISpeciesService _speciesService;
        public IWebHostEnvironment _environment { get; }

        public VarietyController(
            IVarietyService varietyService,
            ISpeciesService speciesService,
            IWebHostEnvironment environment)
        {
            _varietyService = varietyService;
            _speciesService = speciesService;

            _environment = environment; //Needed to get local path to images in case of file deletion
        }

        public ViewResult List()
        {
            var allVarieties = _varietyService
                .AllVarieties();

            VarietyListViewModel listViewModel = GenerateListViewModel(allVarieties);

            return View(listViewModel);
        }

        public IActionResult Details(int id)
        {
            Variety? variety = _varietyService
                .GetDetailsViewById(id);

            if (variety == null)
                return NotFound();

            //string contentRootPath = _environment.WebRootPath;

            return View(GenerateVatieryViewModel(variety));
        }

        [HttpGet]
        public IActionResult AddOrEdit(int? id)
        {
            VarietyDetailsViewModel? varietyViewModel = default;

            //If id is not null, then load variety details to view
            if (id != null)
            {
                ViewBag.Title = "Edit Variety";

                var variety = _varietyService.GetDetailsViewById((int)id);

                if (variety == null)
                    return NotFound();

                //Species
                varietyViewModel = GenerateVatieryViewModel(variety);
            }
            else
            {
                //Create an empty view by default
                ViewBag.Title = "Create Variety";
                var speciesCheckboxes = _speciesService
                    .AllSpecies()
                    .Select(s => new CheckboxViewModel
                    {
                        Id = s.SpeciesId,
                        LabelName = s.ShortLatinName,
                        IsChecked = false
                    })
                    .ToArray()
                    .AsReadOnly();

                varietyViewModel = new VarietyDetailsViewModel(new Variety(), speciesCheckboxes);
            }

            //Populate model
            VarietyAddOrEditViewModel model = new VarietyAddOrEditViewModel
            {
                VarietyName = varietyViewModel.Variety.VarietyName,
                Description = varietyViewModel.Variety.Description,
                ThumbnailImagePath = varietyViewModel.ThumbnailImagePath,
                SpeciesCheckboxes = varietyViewModel.SpeciesCheckboxes,
                PollenOptions = EnumExtensions
                    .GetEnumValuesCollection<PollenTypeEnum>()
                    .Select(p => new SelectListItem
                    {
                        Value = ((int)p).ToString(),
                        Text = p.ToString(),
                        Selected = varietyViewModel.Variety.PollenType == p
                    })
                    .ToList().AsReadOnly(),
                ConfirmButtonText = id == null ? "Create" : "Save"
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([FromQuery] int? id, VarietyAddOrEditViewModel model)
        {
            if (string.IsNullOrEmpty(model.VarietyName))
            {
                ModelState.AddModelError(nameof(model.VarietyName), "Please enter variety name");

                return View(model);
            }

            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Select(x => x.Value?.Errors)
                    .Where(e => e?.Count > 0)
                    .ToList();

                return View(model);
            }

            if (id != null)
            {
                int? varietyIndex = await _varietyService.UpdateVarietyAsync((int)id, model);

                if (varietyIndex == null)
                {
                    return RedirectToAction("List", "Variety");
                }

                return RedirectToAction("Details", "Variety", new { id });
            }

            var newVarietyIndex = await _varietyService.AddVarietyAsync(model);

            return RedirectToAction("Details", "Variety", new { id = newVarietyIndex });
        }

        public IActionResult Search()
        {
            return View();
        }


        //Private methods
        private static VarietyListViewModel GenerateListViewModel(IEnumerable<Variety> allVarieties)
        {
            var varietiesViewModels = allVarieties
                .Select(v => new VarietyListDetailsViewModel
                {
                    VarietyId = v.VarietyId,
                    VarietyName = v.VarietyName,
                    Species = JoinStrings(
                        v.Species
                        .OrderBy(s => s.ShortLatinName)
                        .Select(s => s.ShortLatinName)
                        .ToList()),
                    FruitSizes = JoinStrings(
                        v.FruitSizes
                        .OrderBy(fs => fs.FruitSizeId)
                        .Select(fs => fs.Name)),
                    IsMarron = GetStringFromNullableBoolean(v.IsMarron),
                    ChestnutBlightResistance = GetStringValueOfNullableEnum(v.ChestnutBlightResistance),
                    InkDiseaseResistance = GetStringValueOfNullableEnum(v.InkDiseaseResistance),
                    Peeling = GetStringValueOfNullableEnum(v.Peeling),
                    PollenFertility = GetStringValueOfNullableEnum(v.PollenType),
                    MaturityPeriod = GetStringValueOfNullableEnum(v.MaturityPeriod),
                    IsPollenizedBy = JoinStrings(
                        v.IsPollenizedBy
                        .Select(p => p.PollenizerVariety.VarietyName)
                        .OrderBy(n => n)),
                    IsPollenizerFor = JoinStrings(
                        v.IsPollenizerFor
                        .Select(p => p.PollenizerVariety.VarietyName)
                        .OrderBy(n => n)),
                    IsRootstockFor = JoinStrings(
                        v.IsRootstockFor
                        .Select(p => p.GraftedVariety.VarietyName)
                        .OrderBy(n => n)),
                    IsGraftedOn = JoinStrings(
                        v.IsGraftedOn
                        .Select(p => p.RootstockVariety.VarietyName)
                        .OrderBy(n => n))
                })
                .OrderBy(p => p.VarietyId);

            return new VarietyListViewModel(varietiesViewModels);
        }

        private VarietyDetailsViewModel GenerateVatieryViewModel(Variety variety)
        {
            int[] varietySpecies = variety
                .Species
                .Select(vs => vs.SpeciesId)
                .ToArray() ?? new int[0];

            IReadOnlyList<CheckboxViewModel> speciesCheckboxes = _speciesService
                .AllSpecies()
                .Select(s => new CheckboxViewModel
                {
                    Id = s.SpeciesId,
                    LabelName = s.ShortLatinName,
                    IsChecked = varietySpecies.Contains(s.SpeciesId)
                })
                .ToArray()
                .AsReadOnly();

            return new VarietyDetailsViewModel(variety, speciesCheckboxes);
        }

        private static string GetStringValueOfNullableEnum<T>(T enumValue)
        {
            if (enumValue == null
                || enumValue.ToString() == "None")
            {
                return "";
            }

            return Enum.GetName(typeof(T), enumValue) ?? "";
        }

        private static string JoinStrings(IEnumerable<string> names)
        {
            string separator = $",{Environment.NewLine}";
            return string.Join(separator, names);
        }

        private static string GetStringFromNullableBoolean(bool? isMarron)
        {
            return isMarron != null
                ? (bool)isMarron
                    ? "\u2713"
                    : "\u2717"
                : "";
        }
    }
}
