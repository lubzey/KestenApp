namespace KestenApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Garden;
    using KestenApp.Web.ViewModels.Specimen;

    public class GardenController : BaseController
    {
        private readonly IGardenServices _gardenService;
        private readonly ISpecimenService _specimenService;

        public GardenController(
            IGardenServices gardenService, ISpecimenService specimenService)
        {
            _gardenService = gardenService;
            _specimenService = specimenService;
        }

        [Authorize]
        public async Task<IActionResult> List()
        {
            GardenListModel listViewModel = await _gardenService
                .AllGardensAsync(currentPage: 1);

            return View(listViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Details([FromRoute] Guid id)
        {
            GardenDetailsModel detailsModel = await _gardenService
                .GetDetailsViewByIdAsync(id);

            return View(detailsModel);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit([FromRoute] Guid id)
        {
            GardenDetailsModel garden = await _gardenService
                .GetDetailsViewByIdAsync(id);

            FormModel model = new FormModel
            {
                GardenId = id,
                FormTexts = new ViewModels.FormTextsModel("Garden", true),
                GardenName = garden.GardenName,
                TotalRows = garden.TotalRows,
                TotalColumns = garden.TotalColumns
            };

            return View("Form", model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit([FromForm] FormModel model, [FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View("Form", model);
            }

            //Validate specimen deletion if rows/cols are decreased
            IEnumerable<SpecimenSummaryModel> specimensToArchive = await _specimenService
                .GetSpecimensOutOfRange(id, model.TotalRows, model.TotalColumns);

            if (specimensToArchive.Any())
            {
                ArchiveSpecimensModel archiveModel = new ArchiveSpecimensModel
                {
                    GardenId = id,
                    Specimens = specimensToArchive,
                    IdsToArchive = specimensToArchive
                        .Select(s => s.SpecimenId.ToString())
                        .ToList()
                };

                return View("ArchiveSpecimens", archiveModel);
            }

            //Update existing variety
            string userId = GetUserId();
            if (!(await _gardenService.UpdateGardenAsync(id, userId, model)))
            {
                return RedirectToAction("List", "Garden");
            }

            return RedirectToAction("Details", "Garden", new { id });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> ArchiveSpecimens([FromRoute] Guid id, [FromForm] ArchiveSpecimensModel model)
        {
            await _specimenService.ArchiveByIdsAsync(model.IdsToArchive);

            return RedirectToAction("Details", "Garden", new { id });
        }

        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            FormModel model = new FormModel
            {
                FormTexts = new ViewModels.FormTextsModel("Garden")
            };

            return View("Form", model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add([FromForm] FormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Form", model);
            }

            string userId = GetUserId();
            Guid gardenId = await _gardenService.CreateGardenAsync(userId, model);

            if (gardenId == Guid.Empty)
            {
                return RedirectToAction("List", "Garden");
            }

            return RedirectToAction("Details", "Garden", new { id = gardenId });
        }
    }
}