namespace KestenApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    using KestenApp.Services.Contracts;
    using KestenApp.Data.Enums;
    using KestenApp.Data.Enums.EnumHelpers;
    using KestenApp.Data.Models;
    using Microsoft.AspNetCore.Authorization;
    using KestenApp.Web.ViewModels.Varieties;
    using KestenApp.Web.ViewModels;

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

        [Authorize]
        public async Task<IActionResult> List()
        {
            VarietyListModel listViewModel = await _varietyService
                .AllVarietiesAsync(currentPage: 1);

            return View(listViewModel);
        }

        [Authorize]
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

        [Authorize]
        public async Task<IActionResult> Publish(Guid id)
        {
            await _varietyService
                .PublishVarietyAsync(id);

            return RedirectToAction("Details", "Variety", new { id });
        }

        [Authorize]
        public async Task<IActionResult> Unpublish(Guid id)
        {
            await _varietyService
                .PublishVarietyAsync(id, true);

            return RedirectToAction("Details", "Variety", new { id });
        }

        [Authorize]
        public async Task<IActionResult> Archive(Guid id)
        {
            await _varietyService
                .ArchiveByIdAsync(id);

            return RedirectToAction("Details", "Variety", new { id });
        }

        [Authorize]
        public async Task<IActionResult> Restore(Guid id)
        {
            await _varietyService
                .ArchiveByIdAsync(id, true);

            return RedirectToAction("Details", "Variety", new { id });
        }

        [HttpGet]
        [Authorize]
        [Route("Variety/Add")]
        public async Task<IActionResult> Add()
        {
            //Empty form
            VarietyFormModel formModel = new VarietyFormModel
            {
                //Render selects
                SpeciesCheckboxes = await _varietyService.GenerateSpeciesCheckboxesAsync(),
                PollenOptions = _varietyService.GeneratePollenOptions(),
                BlightResistanceOptions = _varietyService.GenerateConditionOptions(),
            };

            return View("Form", formModel);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([FromForm] VarietyFormModel formModel)
        {
            Variety? variety = await _varietyService
                .GetVarietyByNameAsync(formModel.VarietyName);

            //Avoid using an existing name
            if (variety != null) //when creating
            {
                //Render selects
                formModel.SpeciesCheckboxes = await _varietyService.GenerateSpeciesCheckboxesAsync(formModel.SpeciesCheckboxes.Where(x => x.IsChecked).Select(x => x.Id));
                formModel.PollenOptions = _varietyService.GeneratePollenOptions();

                ModelState.AddModelError(nameof(formModel.VarietyName), $"Variety '{formModel.VarietyName}' already exists.");

                return View("Form", formModel);
            }

            //Other errors
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Select(x => x.Value?.Errors)
                    .Where(e => e?.Count > 0)
                    .ToList();

                return View("Form", formModel);
            }

            //Create a new variety
            Guid newVarietyIndex = await _varietyService.AddVarietyAsync(formModel);

            return RedirectToAction("Details", "Variety", new { id = newVarietyIndex });
        }

        [HttpGet]
        [Authorize]
        [Route("Variety/Edit/{id}")]
        public async Task<IActionResult> Edit([FromRoute] Guid id)
        {
            Variety? variety = await _varietyService.GetDetailsViewByIdAsync(id);

            if (variety == null)
                return NotFound();

            VarietyFormModel formModel = await GenerateEditFormModel(id, variety);

            return View("Form", formModel);
        }

        private async Task<VarietyFormModel> GenerateEditFormModel(Guid id, Variety variety)
        {
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
                SpeciesCheckboxes = await _varietyService.GenerateSpeciesCheckboxesAsync(varietySpeciesIds),
                PollenType = variety.PollenType,
                PollenOptions = _varietyService.GeneratePollenOptions(),
                BlightResistanceOptions = _varietyService.GenerateConditionOptions(),

                //Fruit
                ChestnutBlightResistance = variety.ChestnutBlightResistance,
                InkDiseaseResistance = variety.InkDiseaseResistance
            };

            return formModel;
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] VarietyFormModel formModel, [FromRoute] Guid id)
        {
            Variety? variety = await _varietyService
                .GetVarietyByNameAsync(formModel.VarietyName);

            //Render selects
            formModel.VarietyId = id;

            //Avoid using an existing name
            if (variety != null && variety.VarietyId != id) //when updating
            {
                ModelState.AddModelError(nameof(formModel.VarietyName), $"Variety '{formModel.VarietyName}' already exists.");

                formModel.SpeciesCheckboxes = await _varietyService.GenerateSpeciesCheckboxesAsync(formModel.SpeciesCheckboxes.Where(x => x.IsChecked).Select(x => x.Id));
                formModel.PollenOptions = _varietyService.GeneratePollenOptions();

                return View("Form", formModel);
            }

            //Other errors
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Select(x => x.Value?.Errors)
                    .Where(e => e?.Count > 0)
                    .ToList();

                return View("Form", formModel);
            }

            //Update existing variety
            Guid? varietyIndex = await _varietyService.UpdateVarietyAsync(id, formModel);

            if (varietyIndex == null)
            {
                return RedirectToAction("List", "Variety");
            }

            return RedirectToAction("Details", "Variety", new { id });
        }

        [Authorize]
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

            IList<CheckboxModel> speciesCheckboxes = await _varietyService.GenerateSpeciesCheckboxesAsync(varietySpecies);

            return new VarietyDetailsModel(variety, speciesCheckboxes);
        }

        //private async Task<IEnumerable<SelectListItem>> GeneratePollenOptionsAsync(PollenType pollenType)
        //{
        //    var enumValues = await Task.Run(() => EnumExtensions.GetEnumValuesCollection<PollenType>());

        //    return enumValues.Select(p => new SelectListItem
        //    {
        //        Value = ((int)p).ToString(),
        //        Text = p.ToString(),
        //        Selected = pollenType == p
        //    }).ToList().AsReadOnly();
        //}
    }
}
