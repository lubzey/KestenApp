using KestenTestApp.Contracts;
using KestenTestApp.Models.Data;
using KestenTestApp.Models.EnumHelpers;
using KestenTestApp.Models.Enums;
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
            VarietyDetailsViewModel? variety = _varietyService
                .GetDetailsViewById(id);
            if (variety == null)
                return NotFound();

            //string contentRootPath = _environment.WebRootPath;

            return View(variety);
        }

        [HttpGet]
        public IActionResult AddOrEdit(int? id)
        {
            //Create an empty view by default
            ViewBag.Title = "Create Variety";
            var speciesCheckboxes = _speciesService
                .AllSpecies()
                .Select(s => new CheckboxViewModel
                {
                    Id = s.SpeciesId,
                    LabelName = s.ShortLatinName,
                    IsChecked = false
                }).ToArray().AsReadOnly();
            VarietyDetailsViewModel? variety = new VarietyDetailsViewModel(new Variety(), speciesCheckboxes);            

            //If id is not null, then load variety details to view
            if (id != null)
            {
                ViewBag.Title = "Edit Variety";

                variety = _varietyService
                    .GetDetailsViewById((int)id);

                if (variety == null)
                    return NotFound();
            }

            //Populate model
            VarietyAddOrEditViewModel model = new VarietyAddOrEditViewModel
            {
                VarietyName = variety.Variety.VarietyName,
                Description = variety.Variety.Description,
                ThumbnailImagePath = variety.ThumbnailImagePath,
                SpeciesCheckboxes = variety.SpeciesCheckboxes,
                PollenOptions = EnumExtensions
                    .GetEnumValuesCollection<PollenTypeEnum>()
                    .Select(p => new SelectListItem
                    {
                        Value = ((int)p).ToString(),
                        Text = p.ToString(),
                        Selected = variety.Variety.PollenType == p
                    }).ToList().AsReadOnly(),
                ConfirmButtonText = id == null ? "Create" : "Save"
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int? id, VarietyAddOrEditViewModel model)
        {
            if (string.IsNullOrEmpty(model.VarietyName))
            {
                ModelState.AddModelError(nameof(model.VarietyName), "Please enter variety name");

                return View(model);
            }

            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .Select(x => x.Value?.Errors)
                    .Where(e => e?.Count > 0)
                    .ToList();

                return View(model);
            }

            if (id != null)
            {
                int? varietyIndex = await _varietyService.UpdateVarietyAsync((int)id, model);

                if (varietyIndex == null)
                {
                    return RedirectToAction("List", "Variety");
                }

                return RedirectToAction("Details", "Variety", new { id });
            }
            else
            {
                var newVarietyIndex = await _varietyService.AddVarietyAsync(model);

                return RedirectToAction("Details", "Variety", new { id = newVarietyIndex });
            }
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
