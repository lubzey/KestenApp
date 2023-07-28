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
    }
}