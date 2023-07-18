using System.Collections.ObjectModel;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using KestenApp.Contracts;
using KestenApp.Data.Enums;
using KestenApp.Data.Enums.EnumHelpers;
using KestenApp.Data.Models;
using KestenApp.Web.Models;
using KestenApp.Web.Models.Varieties;
using KestenApp.Services;

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

        public IActionResult Details(Guid id)
        {
            Variety? variety = _varietyService
                .GetDetailsViewById(id);

            if (variety == null)
                return NotFound();

            //string contentRootPath = _environment.WebRootPath;

            return View(GenerateVatieryDetailsViewModel(variety));
        }

        [HttpGet]
        [Route("Variety/Add")]
        public IActionResult Add()
        {
            //Empty form
            VarietyFormModel form = new VarietyFormModel
            {
                //ThumbnailImagePath = $"/Images/no-image.jpg",

                //Render selects
                SpeciesCheckboxes = GenerateSpeciesCheckboxes(),
                PollenOptions = GeneratePollenOptions(PollenTypeEnum.None)
            };

            return View("Form", form);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([FromForm] VarietyFormModel form)
        {
            Variety? variety = _varietyService
                .GetVarietyByName(form.VarietyName);

            //Avoid using an existing name
            if (variety != null) //when creating
            {
                //Render selects
                form.SpeciesCheckboxes = GenerateSpeciesCheckboxes(form.SpeciesCheckboxes.Where(x => x.IsChecked).Select(x => x.Id));
                form.PollenOptions = GeneratePollenOptions(form.PollenType);

                ModelState.AddModelError(nameof(form.VarietyName), $"Variety '{form.VarietyName}' already exists.");

                return View("Form", form);
            }

            //Other errors
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Select(x => x.Value?.Errors)
                    .Where(e => e?.Count > 0)
                    .ToList();

                return View("Form", form);
            }

            //Create a new variety
            Guid newVarietyIndex = await _varietyService.AddVarietyAsync(form);

            return RedirectToAction("Details", "Variety", new { id = newVarietyIndex });
        }

        [HttpGet]
        [Route("Variety/Edit/{id}")]
        public IActionResult Edit([FromRoute] Guid id)
        {
            Variety? variety = _varietyService.GetDetailsViewById(id);

            if (variety == null)
                return NotFound();

            int[] varietySpeciesIds = variety
                .Species
                .Select(vs => vs.SpeciesId)
                .ToArray();

            VarietyFormModel formModel = new VarietyFormModel
            {
                //Details
                VarietyId = id,
                VarietyName = variety.VarietyName,
                Description = variety.Description,
                //ThumbnailImagePath = variety.Images.Any() ?
                //    $"/Images/Varieties/{variety.VarietyId}/{variety.Images.First().FileName}.jpg" :
                //    "/Images/no-image.jpg", //Move to constants

                //Tree
                SpeciesCheckboxes = GenerateSpeciesCheckboxes(varietySpeciesIds),
                PollenOptions = GeneratePollenOptions(variety.PollenType),

                //Fruit
                ChestnutBlightResistance = variety.ChestnutBlightResistance,
                InkDiseaseResistance = variety.InkDiseaseResistance
            };

            return View("Form", formModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] VarietyFormModel form, [FromRoute] Guid id)
        {
            Variety? variety = _varietyService
                .GetVarietyByName(form.VarietyName);

            //if (variety != null && variety.VarietyId != id)
            //{
            //    return NotFound(id);
            //}

            //Render selects
            form.VarietyId = id;

            //Avoid using an existing name
            if (variety != null && variety.VarietyId != id) //when updating
            {
                ModelState.AddModelError(nameof(form.VarietyName), $"Variety '{form.VarietyName}' already exists.");

                form.SpeciesCheckboxes = GenerateSpeciesCheckboxes(form.SpeciesCheckboxes.Where(x => x.IsChecked).Select(x => x.Id));
                form.PollenOptions = GeneratePollenOptions(form.PollenType);

                return View("Form", form);
            }

            //Other errors
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Select(x => x.Value?.Errors)
                    .Where(e => e?.Count > 0)
                    .ToList();

                return View("Form", form);
            }

            //Update existing variety
            Guid? varietyIndex = await _varietyService.UpdateVarietyAsync(id, form);

            if (varietyIndex == null)
            {
                return RedirectToAction("List", "Variety");
            }

            return RedirectToAction("Details", "Variety", new { id });
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
        private ReadOnlyCollection<SelectListItem> GeneratePollenOptions(PollenTypeEnum pollenType)
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
