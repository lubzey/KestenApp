using KestenTestApp.Contracts;
using KestenTestApp.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KestenTestApp.Controllers
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
            IEnumerable<VarietyListDetailsViewModel> varieties = _varietyService
                .AllVarieties()
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

            //for edit: https://stackoverflow.com/questions/62225362/asp-net-core-mvc-listselectlistitem-multiselect-not-showing-select-true-it
            
            List<SelectListItem> allSpecies = _speciesService
                .AllSpecies()
                .Select(s => new SelectListItem { 
                    Value = s.SpeciesId.ToString(),
                    Text = s.ShortLatinName
                }).ToList();
            
            model.SpeciesIds = new List<int>();
            model.SpeciesList = allSpecies;

            return View(model);
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
