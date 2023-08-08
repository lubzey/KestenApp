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

    public class SpecimenController : BaseController
    {
        private readonly ISpecimenService _specimenService;
        private readonly IVarietyService _varietyService;
        private readonly IGardenServices _gardenService;

        public FormTextsModel FormTexts { get; private set; }
        public IEnumerable<SelectListItem> VarietyOptions { get; private set; }

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

            if (TempData.ContainsKey("ModelStateErrors"))
            {
                var serializedErrors = TempData["ModelStateErrors"] as string;
                if (!string.IsNullOrEmpty(serializedErrors))
                {
                    var errors = JsonConvert.DeserializeObject<IEnumerable<string>>(serializedErrors);
                    foreach (var error in errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
            }

            SpecimenGardenSelectModel model = new SpecimenGardenSelectModel(gardens);

            return View("GardenSelect", model);

            //var userId = Guid.Parse(GetUserId());

            ////Empty form
            //SpecimenFormModel formModel = new SpecimenFormModel(userId);

            //await RenderFormSelects(formModel, gardenId);

            //return View("Form", formModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPosition([FromForm] Guid gardenId)
        {
            //validate garden
            bool isUserGardenValid = await _gardenService
                .IsUserGardenValidAsync(gardenId, this.GetUserId());

            if (!isUserGardenValid)
            {
                ModelState.AddModelError("Garden", $"The selected garden is invalid.");
                string serializedErrors = JsonConvert.SerializeObject(ModelState.SelectMany(x => x.Value.Errors).Select(x => x.ErrorMessage));
                TempData["ModelStateErrors"] = serializedErrors;

                return RedirectToAction("Add", "Specimen");
            }

            GardenDetailsModel model = await _gardenService.GetGardenWithUsedPositionsAsync(gardenId);



            return View("PositionSelect", model);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddPositionFromQuery([FromQuery] Guid gardenId)
        {
            if (TempData.ContainsKey("ModelStateErrors"))
            {
                var serializedErrors = TempData["ModelStateErrors"] as string;
                if (!string.IsNullOrEmpty(serializedErrors))
                {
                    var errors = JsonConvert.DeserializeObject<IEnumerable<string>>(serializedErrors);
                    foreach (var error in errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
            }

            GardenDetailsModel model = await _gardenService.GetGardenWithUsedPositionsAsync(gardenId);

            return View("PositionSelect", model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DetailsForm([FromQuery] Guid gardenId, [FromForm] string position)
        {
            int[] positions = position.Split(",").Select(x => int.Parse(x)).ToArray();
            int row = positions.First();
            int column = positions.Last();

            //validate that garden position is empty
            bool isPositionTaken = await _gardenService
                .IsPositionTakenAsync(gardenId, row, column);
            if (isPositionTaken)
            {
                ModelState.AddModelError(position, $"The selected position {row}:{column} is already taken.");
                string serializedErrors = JsonConvert.SerializeObject(ModelState.SelectMany(x => x.Value.Errors).Select(x => x.ErrorMessage));
                TempData["ModelStateErrors"] = serializedErrors;

                return RedirectToAction("AddPositionFromQuery", "Specimen", new { gardenId = gardenId });
            }

            //validate that row and column don't exceed the garden totals
            bool isPositionValid = await _gardenService
                .IsPositionValidAsync(gardenId, row, column);
            if (!isPositionValid)
            {
                ModelState.AddModelError(position, $"The selected position {row}:{column} isn't valid for the current garden.");
                string serializedErrors = JsonConvert.SerializeObject(ModelState.SelectMany(x => x.Value.Errors).Select(x => x.ErrorMessage));
                TempData["ModelStateErrors"] = serializedErrors;

                return RedirectToAction("AddPositionFromQuery", "Specimen", new { gardenId = gardenId });
            }




            //Empty form
            //SpecimenFormModel formModel = new SpecimenFormModel(userId);

            var model = await RenderFormDetails(gardenId, row, column);

            return View("DetailsForm", model);
        }

        private async Task<DetailsFormModel> RenderFormDetails(Guid gardenId, int row, int column)
        {
            DetailsFormModel model = new DetailsFormModel()
            {
                GardenId = gardenId,
                Row = row,
                Column = column,
                UserId = Guid.Parse(GetUserId()),
                SelectedGardenId = gardenId,
                Garden = await _gardenService.GetGardenWithUsedPositionsAsync(gardenId),
                FormTexts = new FormTextsModel("Specimen"),
                VarietyOptions = await _varietyService
                    .GenerateSpecimenVarietyOptionsAsync()
            };

            return model;
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

        private async Task RenderFormSelects(SpecimenFormModel formModel, Guid selectedGardenId)
        {
            formModel.FormTexts = new FormTextsModel("Specimen");
            formModel.VarietyOptions = await _varietyService
                .GenerateSpecimenVarietyOptionsAsync(formModel.VarietyId);

            if (selectedGardenId != Guid.Empty)
            {
                formModel.SelectedGardenId = selectedGardenId;
                formModel.SelectedGarden = await _gardenService.GetGardenAsync(selectedGardenId);
            }
        }
    }
}
