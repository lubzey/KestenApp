namespace KestenApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Specimen;
    using KestenApp.Data.Models;

    public class SpecimenController : BaseController
    {
        private readonly ISpecimenService _specimenService;
        private readonly IVarietyService _varietyService;
        private readonly IGardenServices _gardenService;

        public SpecimenController(
            ISpecimenService specimenService,
            IVarietyService varietyService,
            IGardenServices gardenService)
        {
            _specimenService = specimenService;
            _varietyService = varietyService;
            _gardenService = gardenService;
        }

        [Authorize]
        public async Task<IActionResult> List()
        {
            SpecimenListModel listViewModel = await _specimenService
                .AllSpecimensAsync(currentPage: 1);

            return View(listViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Details(Guid id)
        {
            SpecimenDetailsModel detailsModel = await _specimenService
                .GetDetailsViewByIdAsync(id);

            return View(detailsModel);
        }

        [Authorize]
        public async Task<IActionResult> Archive(Guid id)
        {
            await _specimenService
                .ArchiveByIdAsync(id);

            return RedirectToAction("Details", "Specimen", new { id });
        }

        [Authorize]
        public async Task<IActionResult> Restore(Guid id)
        {
            await _specimenService
                .ArchiveByIdAsync(id, true);

            return RedirectToAction("Details", "Specimen", new { id });
        }

        [HttpGet]
        [Authorize]
        [Route("Specimen/Add")]
        public async Task<IActionResult> Add([FromQuery] Guid? gardenId)
        {
            //Empty form
            IEnumerable<Garden> userGardens = new List<Garden>();

            if (gardenId != null && gardenId != Guid.Empty)
            {
                userGardens = await _gardenService.GetUserGardensAsync(Guid.Parse(GetUserId()));
            }

            SpecimenFormModel formModel = new SpecimenFormModel(userGardens, gardenId);

            await RenderFormSelects(formModel, gardenId);

            return View("Form", formModel);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult MapSelectedGarden([FromForm] SpecimenFormModel formModel)
        {
            return RedirectToAction("Add", "Specimen", new { gardenId = formModel.GardenId });
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([FromForm] SpecimenFormModel formModel, Guid? id)
        {
            //Specimen? specimen = await _specimenService
            //    .GetSpecimenByNameAsync(formModel.SpecimenName);

            ////Avoid using an existing name
            //if (specimen != null) //when creating
            //{
            //    //await RenderFormSelects(formModel);

            //    ModelState.AddModelError(nameof(formModel.SpecimenName), $"Specimen '{formModel.SpecimenName}' already exists.");

            //    return View("Form", formModel);
            //}

            //validate that garden position isn't partially filled
            if ((formModel.Row > 0 && formModel.Column == 0)
                || (formModel.Row == 0 && formModel.Column > 0))
            {
                await RenderFormSelects(formModel, id);

                ModelState.AddModelError(nameof(formModel.SpecimenName), $"Please select both row and column or neither.");

                return View("Form", formModel);
            }

            if (formModel.Row > 0 && formModel.Column !> 0)
            {
                //validate that row and column don't exceed the garden totals


                //validate that garden position is empty
                bool isPositionTaken = await _gardenService
                    .IsPositionTakenAsync(Guid.Parse(formModel.GardenId), (int)formModel.Row, (int)formModel.Column);
                if (isPositionTaken)
                {
                    await RenderFormSelects(formModel, id);

                    ModelState.AddModelError(nameof(formModel.Row), $"The selected position {formModel.Row}:{formModel.Column} is already taken.");

                    return View("Form", formModel);
                }
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

            //Create a new specimen
            Guid newSpecimenIndex = await _specimenService.AddSpecimenAsync(formModel);

            return RedirectToAction("Details", "Specimen", new { id = newSpecimenIndex });
        }

        private async Task RenderFormSelects(SpecimenFormModel formModel, Guid? selectedGardenId)
        {
            formModel.VarietyOptions = await _varietyService.GenerateSpecimenVarietyOptionsAsync();
            formModel.GardenOptions = await _gardenService.GenerateSpecimenGardenOptionsAsync(GetUserId(), selectedGardenId);
        }
    }
}
