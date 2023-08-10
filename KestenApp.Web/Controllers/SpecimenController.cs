namespace KestenApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Specimen;
    using KestenApp.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using KestenApp.Web.ViewModels.Garden;
    using Newtonsoft.Json;

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
        public async Task<IActionResult> Add()
        {
            string userId = GetUserId();
            IEnumerable<SelectListItem> gardens = await _gardenService.GetUserGardensAsync(userId);

            if (!gardens.Any())
            {
                return RedirectToAction("Create", "Garden");
            }
            else if (gardens.Count() == 1)
            {
                return RedirectToAction("AddPosition", "Specimen", new { gardenId = gardens.Single() });
            }

            PopulateErrorsInModelState();

            SpecimenGardenSelectModel model = new SpecimenGardenSelectModel(gardens);

            return View("GardenSelect", model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPosition([FromForm] Guid gardenId)
        {
            //prevent invalid ids
            if (ModelState.ErrorCount > 0)
            {
                AddModelStateErrorsToTempData();
                return RedirectToAction("Add", "Specimen");
            }

            //validate garden
            bool isUserGardenValid = await _gardenService
                .IsUserGardenValidAsync(gardenId, this.GetUserId());

            if (!isUserGardenValid)
            {
                ModelState.AddModelError("Garden", $"The selected garden id is invalid.");
                AddModelStateErrorsToTempData();

                return RedirectToAction("Add", "Specimen");
            }

            GardenDetailsModel model = await _gardenService.GetGardenWithUsedPositionsAsync(gardenId);

            return View("PositionSelect", model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DetailsForm([FromForm] Guid gardenId, [FromForm] string position)
        {
            int[] positions = position.Split(",").Select(x => int.Parse(x)).ToArray();
            int row = positions.First();
            int column = positions.Last();
            PopulateErrorsInModelState();

            //validate that garden position is empty
            bool isPositionTaken = await _gardenService
                .IsPositionTakenAsync(gardenId, row, column);
            if (isPositionTaken)
            {
                ModelState.AddModelError(position, $"The selected position {row}:{column} is already taken.");
                AddModelStateErrorsToTempData();

                return RedirectToAction("AddPositionFromQuery", "Specimen", new { gardenId = gardenId });
            }

            //validate that row and column don't exceed the garden totals
            bool isPositionValid = await _gardenService
                .IsPositionValidAsync(gardenId, row, column);
            if (!isPositionValid)
            {
                ModelState.AddModelError(position, $"The selected position {row}:{column} isn't valid for the current garden.");
                AddModelStateErrorsToTempData();

                return RedirectToAction("AddPositionFromQuery", "Specimen", new { gardenId = gardenId });
            }

            //Empty form
            DetailsFormModel model = new DetailsFormModel()
            {
                GardenId = gardenId,
                Row = row,
                Column = column
            };
            await RenderFormDetails(model);

            return View("Form", model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(
            [FromForm] DetailsFormModel model)
        {
            //Other errors
            if (!ModelState.IsValid)
            {
                await RenderFormDetails(model);

                return View("Form", model);
            }

            //Create a new specimen
            Guid userId = Guid.Parse(GetUserId());
            Guid newSpecimenIndex = await _specimenService.AddSpecimenAsync(model, userId);

            return RedirectToAction("Details", "Specimen", new { id = newSpecimenIndex });
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit([FromRoute] Guid id)
        {
            SpecimenDetailsModel specimen = await _specimenService
                .GetDetailsViewByIdAsync(id);

            //Empty form
            DetailsFormModel model = new DetailsFormModel()
            {
                GardenId = specimen.Garden.GardenId,
                Row = specimen.Row,
                Column = specimen.Column,
                SpecimenId = specimen.SpecimenId,
                SpecimenName = specimen.SpecimenName,
                VarietyId = specimen.Variety?.VarietyId,
                Elevation = specimen.Elevation,
                PlantedOnDate = specimen.PlantedOnDate,
                SowedOnDate = specimen.SowedOnDate,
                GraftedOnDate = specimen.GraftedOnDate
            };
            await RenderFormDetails(model, true);

            return View("Form", model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit([FromForm] DetailsFormModel formModel, [FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View("Form", formModel);
            }

            //Update existing variety
            if (!(await _specimenService.UpdateSpecimenAsync(id, formModel)))
            {
                return RedirectToAction("List", "Specimen");
            }

            return RedirectToAction("Details", "Specimen", new { id });
        }


        //Private
        private async Task RenderFormDetails(DetailsFormModel model, bool isEdit = false)
        {
            model.FormTexts = new FormTextsModel("Specimen", isEdit);
            model.Garden = await _gardenService.GetGardenWithUsedPositionsAsync(model.GardenId);
            if (isEdit)
            {
                model.Garden.Specimens[model.Row - 1, model.Column - 1].BackgroundColor += " border-4 border-success";
            }
            model.VarietyOptions = await _varietyService.GenerateSpecimenVarietyOptionsAsync();
        }

        private void AddModelStateErrorsToTempData()
        {
            IEnumerable<string> errors = ModelState
                .Where(x => x.Value != null)
                .SelectMany(x => x.Value!.Errors)
                .Select(x => x.ErrorMessage)
                .ToList();

            string serializedErrors = JsonConvert
                .SerializeObject(errors);

            TempData["ModelStateErrors"] = serializedErrors;
        }

        private void PopulateErrorsInModelState()
        {
            if (TempData.ContainsKey("ModelStateErrors"))
            {
                var serializedErrors = TempData["ModelStateErrors"] as string;
                if (!string.IsNullOrEmpty(serializedErrors))
                {
                    IEnumerable<string> errors = JsonConvert
                        .DeserializeObject<IEnumerable<string>>(serializedErrors)!;
                    foreach (var error in errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
            }
        }
    }
}
