namespace KestenApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Specimen;
    using KestenApp.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using KestenApp.Web.ViewModels.Garden;

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

        //Add-Select-Garden
        //if none - create
        //if 1 - go to step 2
        //if > 1 - select
        [HttpGet]
        [Authorize]
        [Route("Specimen/Add")]
        public async Task<IActionResult> Add() //[FromQuery] Guid? gardenId)
        {
            string userId = GetUserId();

            IEnumerable<SelectListItem> gardens = await _gardenService.GetUserGardensAsync(userId);

            if (!gardens.Any())
            {
                return RedirectToAction("AddError", "Specimen");
            }
            else if (gardens.Count() == 1)
            {
                return RedirectToAction("AddPosition", "Specimen", new { gardenId = gardens.Single() });
            }

            SpecimenGardenSelectModel model = new SpecimenGardenSelectModel(gardens);

            return View("SpecimenGardenSelect", model);

            //var userId = Guid.Parse(GetUserId());

            ////Empty form
            //SpecimenFormModel formModel = new SpecimenFormModel(userId);

            //await RenderFormSelects(formModel, gardenId);

            //return View("Form", formModel);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddError()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPosition([FromForm]Guid gardenId)
        {
            GardenDetailsModel model = await _gardenService.GetGardenWithUsedPositionsAsync(gardenId);

            return View("PositionSelect", model);
        }

        [HttpPost]
        public async Task<IActionResult> DetailsForm([FromQuery] Guid gardenId, [FromForm] string position)
        {
            return View("DetailsForm");
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
        public async Task<IActionResult> Add([FromForm] SpecimenFormModel formModel)
        {
            //validate that garden position isn't partially filled
            if ((formModel.Row > 0 && formModel.Column == 0)
                || (formModel.Row == 0 && formModel.Column > 0))
            {
                await RenderFormSelects(formModel, formModel.SelectedGarden!.GardenId);

                ModelState.AddModelError(nameof(formModel.SpecimenName), $"Please select both row and column or neither.");

                return View("Form", formModel);
            }

            if (formModel.Row > 0 && formModel.Column! > 0)
            {
                //validate that row and column don't exceed the garden totals

                //validate that garden position is empty
                bool isPositionTaken = await _gardenService
                    .IsPositionTakenAsync(formModel.SelectedGarden!.GardenId, (int)formModel.Row, (int)formModel.Column);
                if (isPositionTaken)
                {
                    await RenderFormSelects(formModel, formModel.SelectedGarden!.GardenId);

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
            formModel.FormTexts = new FormTextsModel("Specimen");
            formModel.GardenOptions = await _gardenService
                .GenerateSpecimenGardenOptionsAsync(GetUserId(), selectedGardenId);
            formModel.VarietyOptions = await _varietyService
                .GenerateSpecimenVarietyOptionsAsync(formModel.VarietyId);            

            if (selectedGardenId != null && selectedGardenId != Guid.Empty)
            {
                formModel.SelectedGardenId = selectedGardenId.Value;
                formModel.SelectedGarden = await _gardenService.GetGardenAsync(selectedGardenId.Value);
            }
        }
    }
}
