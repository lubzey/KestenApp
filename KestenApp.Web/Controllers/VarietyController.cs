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
            VarietyDetailsModel detailsModel = await _varietyService
                .GetDetailsViewByIdAsync(id);

            //string contentRootPath = _environment.WebRootPath;

            return View(detailsModel);
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
            VarietyFormModel formModel = new VarietyFormModel();
            await RenderFormSelects(formModel);

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
                await RenderFormSelects(formModel);

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
            VarietyFormModel editModel = await _varietyService.GetFormViewByIdAsync(id);

            return View("Form", editModel);
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

                await RenderFormSelects(formModel);

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

        private async Task RenderFormSelects(VarietyFormModel formModel)
        {
            int[] checkedSpecies = formModel.SpeciesCheckboxes != null
                ? formModel.SpeciesCheckboxes
                    .Where(x => x.IsChecked)
                    .Select(x => x.Id).ToArray()
                : new int[0];

            formModel.SpeciesCheckboxes = await _varietyService.GenerateSpeciesCheckboxesAsync(checkedSpecies);
            formModel.PollenOptions = _varietyService.GeneratePollenOptions();
            formModel.BlightResistanceOptions = _varietyService.GenerateConditionOptions();
            formModel.InkDiseaseResistanceOptions = _varietyService.GenerateConditionOptions();

            formModel.VigorOptions = _varietyService.GenerateVigorOptions();
            formModel.BuddingPeriodOptions = _varietyService.GeneratePeriodOptions();
            formModel.FloweringPeriodOptions = _varietyService.GeneratePeriodOptions();
            formModel.MaturityPeriodOptions = _varietyService.GeneratePeriodOptions();

            formModel.PeelingOptions = _varietyService.GenerateConditionOptions();
            formModel.ConservationOptions = _varietyService.GenerateConditionOptions();
        }
    }
}
