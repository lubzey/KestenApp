using KestenApp.Contracts;
using KestenApp.Data.Models;
using KestenApp.Infrastructure.Enums;
using KestenApp.Infrastructure.Enums.EnumHelpers;
using KestenApp.Models;
using KestenApp.Models.Varieties;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace KestenApp.Controllers
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
                .AllVarieties()
                .ToList()
                .OrderBy(v => v.VarietyName);

            VarietyListModel listViewModel = GenerateListViewModel(allVarieties);

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
        public IActionResult Form(int? id)
        {
            VarietyDetailsModel? varietyViewModel = default;

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
                    .Select(s => new CheckboxModel
                    {
                        Id = s.SpeciesId,
                        LabelName = s.ShortLatinName,
                        IsChecked = false
                    })
                    .ToArray()
                    .AsReadOnly();

                varietyViewModel = new VarietyDetailsModel(new Variety(), speciesCheckboxes);
            }

            //Populate model
            VarietyFormModel form = new VarietyFormModel
            {
                VarietyId = id == null ? null : (int)id,
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

            return View(form);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Form(VarietyFormModel form, int? id) //[FromQuery]
        {
            if (string.IsNullOrEmpty(form.VarietyName))
            {
                ModelState.AddModelError(nameof(form.VarietyName), "Please enter variety name");

                return View(form);
            }

            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Select(x => x.Value?.Errors)
                    .Where(e => e?.Count > 0)
                    .ToList();

                return View(form);
            }

            if (id != null)
            {
                int? varietyIndex = await _varietyService.UpdateVarietyAsync((int)id, form);

                if (varietyIndex == null)
                {
                    return RedirectToAction("List", "Variety");
                }

                return RedirectToAction("Details", "Variety", new { id });
            }

            var newVarietyIndex = await _varietyService.AddVarietyAsync(form);

            return RedirectToAction("Details", "Variety", new { id = newVarietyIndex });
        }

        public IActionResult Search()
        {
            return View();
        }


        //Private methods
        private static VarietyListModel GenerateListViewModel(IEnumerable<Variety> allVarieties)
        {
            var varietiesViewModels = allVarieties
                .Select(v => new VarietyListDetailsModel
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

            return new VarietyListModel(varietiesViewModels);
        }

        private VarietyDetailsModel GenerateVatieryViewModel(Variety variety)
        {
            int[] varietySpecies = variety
                .Species
                .Select(vs => vs.SpeciesId)
                .ToArray() ?? new int[0];

            IReadOnlyList<CheckboxModel> speciesCheckboxes = _speciesService
                .AllSpecies()
                .Select(s => new CheckboxModel
                {
                    Id = s.SpeciesId,
                    LabelName = s.ShortLatinName,
                    IsChecked = varietySpecies.Contains(s.SpeciesId)
                })
                .ToArray()
                .AsReadOnly();

            return new VarietyDetailsModel(variety, speciesCheckboxes);
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
