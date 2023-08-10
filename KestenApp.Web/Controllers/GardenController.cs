namespace KestenApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Garden;

    public class GardenController : BaseController
    {
        private readonly IGardenServices _gardenService;

        public GardenController(
            IGardenServices specimenService)
        {
            _gardenService = specimenService;
        }

        [Authorize]
        public async Task<IActionResult> List()
        {
            GardenListModel listViewModel = await _gardenService
                .AllGardensAsync(currentPage: 1);

            return View(listViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Details(Guid id)
        {
            GardenDetailsModel detailsModel = await _gardenService
                .GetDetailsViewByIdAsync(id);


            return View(detailsModel);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(Guid id)
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

    }
}