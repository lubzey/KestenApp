using KestenTestApp.Contracts;
using KestenTestApp.Models.EnumHelpers;
using KestenTestApp.Models.Enums;
using KestenTestApp.Models.View;
using Microsoft.AspNetCore.Mvc;

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
            VarietyDetailsViewModel? variety = _varietyService
                .GetDetailsViewById(id);
            if (variety == null)
                return NotFound();

            //string contentRootPath = _environment.WebRootPath;

            return View(variety);
        }

        [HttpGet]
        public IActionResult Add()
        {
            IReadOnlyList<CheckboxViewModel> speciesCheckboxes = _speciesService
                .AllSpecies()
                .Select(s => new CheckboxViewModel
                {
                    Id = s.SpeciesId,
                    LabelName = s.ShortLatinName,
                    IsChecked = false
                }).ToArray().AsReadOnly();

            VarietyAddViewModel model = new VarietyAddViewModel();
            model.Species = speciesCheckboxes;
            model.AllPollenTypes = EnumExtensions.GetEnumValuesCollection<PollenTypeEnum>();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(VarietyAddViewModel model)
        {
            if (string.IsNullOrEmpty(model.VarietyName))
            {
                ModelState.AddModelError(nameof(model.VarietyName), "Please enter variety name");

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                var errors = ModelState
                    .Select(x => x.Value?.Errors)
                    .Where(e => e?.Count > 0)
                    .ToList();

                return View(model);
            }

            var newVarietyIndex = await _varietyService.AddVarietyAsync(model);

            return RedirectToAction("Details", "Variety", new { id = newVarietyIndex });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            VarietyDetailsViewModel? detailsViewModel = _varietyService.GetDetailsViewById(id);


            return View(detailsViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(VarietyAddViewModel model)
        {
            if (string.IsNullOrEmpty(model.VarietyName))
            {
                ModelState.AddModelError(nameof(model.VarietyName), "Please enter variety name");

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            var newVarietyIndex = await _varietyService.AddVarietyAsync(model);

            return RedirectToAction("Details", "Variety", new { id = newVarietyIndex });
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
