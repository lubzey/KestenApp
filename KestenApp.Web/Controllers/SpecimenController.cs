﻿namespace KestenApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Specimen;
    using KestenApp.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using KestenApp.Web.ViewModels.Garden;
    using Newtonsoft.Json;
    using KestenApp.Data.Models;
    using Microsoft.CodeAnalysis.Elfie.Diagnostics;

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
            var userId = GetUserId();

            SpecimenListModel listViewModel = await _specimenService
                .AllSpecimensAsync(currentPage: 1, userId: userId);

            return View(listViewModel);
        }

        [Authorize]
        public async Task<IActionResult> Details(Guid id)
        {
            var userId = GetUserId();
            SpecimenDetailsModel detailsModel = await _specimenService
                .GetDetailsViewByIdAsync(id, userId);

            if (detailsModel.SpecimenId == Guid.Empty)
            {
                return RedirectToAction(nameof(this.List), "Specimen", new { id });
            }

            return View(detailsModel);
        }

        [Authorize]
        public async Task<IActionResult> Archive(Guid id)
        {
            await _specimenService
                .ArchiveByIdAsync(id);

            return RedirectToAction(nameof(this.Details), "Specimen", new { id });
        }

        [Authorize]
        public async Task<IActionResult> Restore(Guid id)
        {
            await _specimenService
                .ArchiveByIdAsync(id, true);

            return RedirectToAction(nameof(this.Details), "Specimen", new { id });
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
                return RedirectToAction("Add", "Garden");
            }
            else if (gardens.Count() == 1)
            {
                return RedirectToAction(nameof(this.AddGardenFromQueryRoute), "Specimen", new { gardenId = gardens.Single().Value });
            }

            PopulateErrorsInModelState();

            SpecimenGardenSelectModel model = new SpecimenGardenSelectModel(gardens);

            return View("GardenSelect", model);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddGardenFromQueryRoute([FromQuery] Guid gardenId)
        {
            PopulateErrorsInModelState();

            GardenDetailsModel model = await _gardenService.GetGardenWithUsedPositionsAsync(gardenId);

            return View("PositionSelect", model);
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

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddGardenAndPositionFromQueryRoute(
            [FromQuery] Guid gardenId, [FromQuery] string position)
        {
            return await ReturnDetailsFormOrError(gardenId, position);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DetailsForm([FromForm] Guid gardenId, [FromForm] string position)
        {
            return await ReturnDetailsFormOrError(gardenId, position);
        }

        private async Task<IActionResult> ReturnDetailsFormOrError(Guid gardenId, string position)
        {
            int[] positions = position.Split(",").Select(x => int.Parse(x)).ToArray();

            //Empty form
            DetailsFormModel model = new DetailsFormModel()
            {
                GardenId = gardenId,
                Row = positions.First(),
                Column = positions.Last()
            };

            PopulateErrorsInModelState();

            //validate null and negative
            if (model.Row <= 0 || model.Column <= 0)
            {
                ModelState.AddModelError(position, $"The selected position {model.Row}:{model.Column} must be of valid positive values.");
                AddModelStateErrorsToTempData();

                return RedirectToAction(nameof(this.AddGardenFromQueryRoute), "Specimen", new { gardenId = gardenId });
            }

            //validate that garden position is empty
            bool isPositionTaken = await _gardenService
                .IsPositionTakenAsync(gardenId, model.Row, model.Column);
            if (isPositionTaken)
            {
                ModelState.AddModelError(position, $"The selected position {model.Row}:{model.Column} is already taken.");
                AddModelStateErrorsToTempData();

                return RedirectToAction(nameof(this.AddGardenFromQueryRoute), "Specimen", new { gardenId = gardenId });
            }

            //validate that row and column don't exceed the garden totals
            bool isPositionValid = await _gardenService
                .IsPositionValidAsync(gardenId, model.Row, model.Column);
            if (!isPositionValid)
            {
                ModelState.AddModelError(position, $"The selected position {model.Row}:{model.Column} isn't valid for the current garden.");
                AddModelStateErrorsToTempData();

                return RedirectToAction(nameof(this.AddGardenFromQueryRoute), "Specimen", new { gardenId = gardenId });
            }

            await PopulateFormDetails(model);

            return View("Form", model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add([FromForm] DetailsFormModel model)
        {
            //Other errors
            if (!ModelState.IsValid)
            {
                await PopulateFormDetails(model);

                return View("Form", model);
            }

            if (string.IsNullOrEmpty(model.SpecimenName) && 
                (model.VarietyId == null || model.VarietyId == Guid.Empty))
            {
                ModelState.AddModelError("Name", "Select a known variety or enter a temporary name");
                AddModelStateErrorsToTempData();

                await PopulateFormDetails(model);
                return View("Form", model);
            }

            //Create a new specimen
            Guid userId = Guid.Parse(GetUserId());
            Guid newSpecimenIndex = await _specimenService.AddSpecimenAsync(model, userId);

            return RedirectToAction(nameof(this.Details), "Specimen", new { id = newSpecimenIndex });
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit([FromRoute] Guid id)
        {
            var userId = GetUserId();

            SpecimenDetailsModel detailsModel = await _specimenService
                .GetDetailsViewByIdAsync(id, userId);

            if (detailsModel.SpecimenId == Guid.Empty)
            {
                return RedirectToAction(nameof(this.List), "Specimen", new { id });
            }

            //Empty form
            DetailsFormModel model = new DetailsFormModel()
            {
                GardenId = detailsModel.Garden.GardenId,
                Row = detailsModel.Row,
                Column = detailsModel.Column,
                SpecimenId = detailsModel.SpecimenId,
                SpecimenName = detailsModel.SpecimenName,
                VarietyId = detailsModel.Variety?.VarietyId,
                Elevation = detailsModel.Elevation,
                PlantedOnDate = detailsModel.PlantedOnDate,
                SowedOnDate = detailsModel.SowedOnDate,
                GraftedOnDate = detailsModel.GraftedOnDate
            };
            await PopulateFormDetails(model, true);

            return View("Form", model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit([FromForm] DetailsFormModel model, [FromRoute] Guid id)
        {
            model.SpecimenId = id;

            //Other errors
            if (!ModelState.IsValid)
            {
                await PopulateFormDetails(model);

                return View("Form", model);
            }

            if (string.IsNullOrEmpty(model.SpecimenName) &&
                (model.VarietyId == null || model.VarietyId == Guid.Empty))
            {
                ModelState.AddModelError("Name", "Specimen identifier is required");
                AddModelStateErrorsToTempData();

                await PopulateFormDetails(model, true);
                return View("Form", model);
            }

            //Update existing variety
            if (!(await _specimenService.UpdateSpecimenAsync((Guid)model.SpecimenId, model)))
            {
                return RedirectToAction(nameof(this.List), "Specimen");
            }

            return RedirectToAction(nameof(this.Details), "Specimen", new { model.SpecimenId });
        }


        //Private
        //TODO: Move method to service
        private async Task PopulateFormDetails(DetailsFormModel model, bool isEdit = false)
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
