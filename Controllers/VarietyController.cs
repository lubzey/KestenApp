using KestenTestApp.Contracts;
using KestenTestApp.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace KestenTestApp.Controllers
{
    public class VarietyController : BaseController
    {
        private readonly IVarietyService _varietyService;
        public IWebHostEnvironment _environment { get; }

        public VarietyController(IVarietyService varietyService, IWebHostEnvironment environment)
        {
            _varietyService = varietyService;
            _environment = environment; //Needed to get local path to images in case of file deletion
        }

        public ViewResult List()
        {
            IEnumerable<VarietyListDetailsViewModel> varieties = _varietyService
                .AllVarieties
                .OrderBy(p => p.VarietyId);

            return View(new VarietyListViewModel(varieties));
        }

        public IActionResult Details(int id)
        {
            var variety = _varietyService
                .GetVarietyById(id);
            if (variety == null)
                return NotFound();

            //string contentRootPath = _environment.WebRootPath;

            return View(variety);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            VarietyAddViewModel model = await _varietyService.GetNewAddVarietyModelAsync();

            return View(model);
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
