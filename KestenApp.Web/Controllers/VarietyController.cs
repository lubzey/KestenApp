namespace KestenApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Services.Contracts;
    using KestenApp.Data.Enums;
    using KestenApp.Data.Enums.EnumHelpers;
    using KestenApp.Data.Models;
    using KestenApp.Web.Models;
    using KestenApp.Web.Models.Varieties;

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

        public async Task<IActionResult> List()
        {
            VarietyListModel listViewModel = await _varietyService
                .AllVarietiesAsync(currentPage: 1);

            return View(listViewModel);
        }

        public async Task<IActionResult> Details(Guid id)
        {
            Variety? variety = await _varietyService
                .GetDetailsViewByIdAsync(id);

            if (variety == null)
                return NotFound();

            //string contentRootPath = _environment.WebRootPath;
            VarietyDetailsModel model = await GenerateVatieryDetailsViewModelAsync(variety);

            return View(model);
        }

        [HttpGet]
        [Route("Variety/Add")]
        public async Task<IActionResult> Add()
        {
            //Empty form
            VarietyFormModel formModel = new VarietyFormModel
            {
                //ThumbnailImagePath = $"/Images/no-image.jpg",

                //Render selects
                SpeciesCheckboxes = await GenerateSpeciesCheckboxesAsync(),
                PollenOptions = GeneratePollenOptions(PollenTypeEnum.None)
            };

            return View("Form", formModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([FromForm] VarietyFormModel form)
        {
            Variety? variety = await _varietyService
                .GetVarietyByNameAsync(form.VarietyName);

            //Avoid using an existing name
            if (variety != null) //when creating
            {
                //Render selects
                form.SpeciesCheckboxes = await GenerateSpeciesCheckboxesAsync(form.SpeciesCheckboxes.Where(x => x.IsChecked).Select(x => x.Id));
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
        public async Task<IActionResult> Edit([FromRoute] Guid id)
        {
            Variety? variety = await _varietyService.GetDetailsViewByIdAsync(id);

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
                VarietyName = variety.Name,
                Description = variety.Description,
                ThumbnailImagePath = variety.VarietyImages.Any() ?
                    $"/Images/Varieties/{variety.VarietyId}/{variety.VarietyImages.First().ImageId}.jpg" :
                    "/Images/no-image.jpg", //Move to constants

                //Tree
                SpeciesCheckboxes = await GenerateSpeciesCheckboxesAsync(varietySpeciesIds),
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
            Variety? variety = await _varietyService
                .GetVarietyByNameAsync(form.VarietyName);

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

                form.SpeciesCheckboxes = await GenerateSpeciesCheckboxesAsync(form.SpeciesCheckboxes.Where(x => x.IsChecked).Select(x => x.Id));
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
        private async Task<VarietyDetailsModel> GenerateVatieryDetailsViewModelAsync(Variety variety)
        {
            int[] varietySpecies = variety
                .Species
                .Select(vs => vs.SpeciesId)
                .ToArray();

            IList<CheckboxModel> speciesCheckboxes = await GenerateSpeciesCheckboxesAsync(varietySpecies);

            return new VarietyDetailsModel(variety, speciesCheckboxes);
        }

        #region Form
        private IEnumerable<SelectListItem> GeneratePollenOptions(PollenTypeEnum pollenType)
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

        private async Task<IList<CheckboxModel>> GenerateSpeciesCheckboxesAsync(IEnumerable<int>? varietySpecies = null)
        {
            if (varietySpecies == null)
            {
                varietySpecies = new int[0];
            }

            var allSpecies = await _speciesService
                .AllSpecies();

            return allSpecies
                .Select(s => new CheckboxModel
                {
                    Id = s.SpeciesId,
                    LabelName = s.ShortLatinName,
                    IsChecked = varietySpecies.Contains(s.SpeciesId)
                })
                .ToList();
        }
        #endregion        
    }
}
