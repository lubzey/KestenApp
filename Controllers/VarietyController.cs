using KestenApp.Contracts;
using KestenApp.Data.Models;
using KestenApp.Infrastructure.Enums;
using KestenApp.Infrastructure.Enums.EnumHelpers;
using KestenApp.Models;
using KestenApp.Models.Varieties;
using KestenApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

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
            VarietyServiceModel allVarieties = _varietyService
                .AllVarieties(currentPage: 1);

            VarietyListModel listViewModel = GenerateListViewModel(allVarieties.Varieties);

            return View(listViewModel);
        }

        public IActionResult Details(int id)
        {
            Variety? variety = _varietyService
                .GetDetailsViewById(id);

            if (variety == null)
                return NotFound();

            //string contentRootPath = _environment.WebRootPath;

            return View(GenerateVatieryDetailsViewModel(variety));
        }

        [HttpGet]
        public IActionResult Form(int? id)
        {
            //Empty form
            VarietyFormModel formModel = new VarietyFormModel
            {
                VarietyId = id,
                ThumbnailImagePath = $"/Images/no-image.jpg",

                //Tree
                SpeciesCheckboxes = GenerateSpeciesCheckboxes(),
                PollenOptions = GeneratePollenOptions()
            };

            //Load exiating variety details
            if (id != null)
            {
                Variety? variety = _varietyService.GetDetailsViewById((int)id);

                if (variety == null)
                    return NotFound();

                PopulateFormModelFromVariety(formModel, variety);
            }

            return View(formModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Form(VarietyFormModel form, int? id) //[FromQuery]
        {
            var variety = _varietyService
                .GetVarietyByName(form.VarietyName);

            if (variety != null)
            {
                ModelState.AddModelError(nameof(form.VarietyName), $"Variety '{form.VarietyName}' already exists.");

                form.SpeciesCheckboxes = GenerateSpeciesCheckboxes();
                form.PollenOptions = GeneratePollenOptions();
                return View(form);
            }

            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Select(x => x.Value?.Errors)
                    .Where(e => e?.Count > 0)
                    .ToList();

                form.SpeciesCheckboxes = GenerateSpeciesCheckboxes();
                form.PollenOptions = GeneratePollenOptions();
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
                });

            return new VarietyListModel(varietiesViewModels);
        }

        private VarietyDetailsModel GenerateVatieryDetailsViewModel(Variety variety)
        {
            int[] varietySpecies = variety
                .Species
                .Select(vs => vs.SpeciesId)
                .ToArray();

            IList<CheckboxModel> speciesCheckboxes = GenerateSpeciesCheckboxes(varietySpecies);

            return new VarietyDetailsModel(variety, speciesCheckboxes);
        }

        #region Form
        private void PopulateFormModelFromVariety(VarietyFormModel formModel, Variety variety)
        {
            //Details
            formModel.VarietyName = variety.VarietyName;
            formModel.Description = variety.Description;
            if (variety.Images.Any())
            {
                formModel.ThumbnailImagePath =
                    $"/Images/Varieties/{variety.VarietyId}/{variety.Images.First().FileName}.jpg";
            }

            //Tree
            int[] varietySpecies = variety
                .Species
                .Select(vs => vs.SpeciesId)
                .ToArray();
            formModel.SpeciesCheckboxes = GenerateSpeciesCheckboxes(varietySpecies);
            formModel.PollenOptions = GeneratePollenOptions(variety.PollenType);

            //Fruit
            formModel.ChestnutBlightResistance = variety.ChestnutBlightResistance;
            formModel.InkDiseaseResistance = variety.InkDiseaseResistance;
        }

        private ReadOnlyCollection<SelectListItem> GeneratePollenOptions(PollenTypeEnum pollenType = PollenTypeEnum.None)
        {
            return EnumExtensions
                .GetEnumValuesCollection<PollenTypeEnum>()
                .Select(p => new SelectListItem
                {
                    Value = ((int)p).ToString(),
                    Text = p.ToString(),
                    Selected = pollenType == p
                })
                .ToList()
                .AsReadOnly();
        }

        private IList<CheckboxModel> GenerateSpeciesCheckboxes(IEnumerable<int>? varietySpecies = null)
        {
            if (varietySpecies == null)
            {
                varietySpecies = new int[0];
            }

            return _speciesService
                .AllSpecies()
                .Select(s => new CheckboxModel
                {
                    Id = s.SpeciesId,
                    LabelName = s.ShortLatinName,
                    IsChecked = varietySpecies.Contains(s.SpeciesId)
                })
                .ToList();
        }
        #endregion

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
