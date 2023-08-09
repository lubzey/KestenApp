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
                    foreach (var error in errors!)
                    {
                        ModelState.AddModelError("", error);
                    }
                }
            }

            SpecimenGardenSelectModel model = new SpecimenGardenSelectModel(gardens);

            return View("GardenSelect", model);
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
                string serializedErrors = JsonConvert.SerializeObject(ModelState.SelectMany(x => x.Value!.Errors).Select(x => x.ErrorMessage));
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
                    foreach (var error in errors!)
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
                string serializedErrors = JsonConvert.SerializeObject(ModelState.SelectMany(x => x.Value!.Errors).Select(x => x.ErrorMessage));
                TempData["ModelStateErrors"] = serializedErrors;

                return RedirectToAction("AddPositionFromQuery", "Specimen", new { gardenId = gardenId });
            }

            //validate that row and column don't exceed the garden totals
            bool isPositionValid = await _gardenService
                .IsPositionValidAsync(gardenId, row, column);
            if (!isPositionValid)
            {
                ModelState.AddModelError(position, $"The selected position {row}:{column} isn't valid for the current garden.");
                string serializedErrors = JsonConvert.SerializeObject(ModelState.SelectMany(x => x.Value!.Errors).Select(x => x.ErrorMessage));
                TempData["ModelStateErrors"] = serializedErrors;

                return RedirectToAction("AddPositionFromQuery", "Specimen", new { gardenId = gardenId });
            }

            //Empty form

            DetailsFormModel model = await RenderFormDetails(gardenId, row, column);

            return View("DetailsForm", model);
        }

        private async Task<DetailsFormModel> RenderFormDetails(Guid gardenId, int row, int column)
        {
            DetailsFormModel model = new DetailsFormModel()
            {
                GardenId = gardenId,
                Row = row,
                Column = column,
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
        public async Task<IActionResult> Create(
            [FromForm] DetailsFormModel formModel,
            [FromQuery] Guid gardenId, [FromQuery] int row, [FromQuery] int column)
        {
            formModel.GardenId = gardenId;
            formModel.Row = row;
            formModel.Column = column;
            Guid userId = Guid.Parse(GetUserId());

            //Other errors
            if (!ModelState.IsValid)
            {
                List<string> errors = ModelState
                    .Values.Where(E => E.Errors.Count > 0)
                    .SelectMany(E => E.Errors)
                    .Select(E => E.ErrorMessage)
                    .ToList();
                errors.Add("QWERTY");
                string serializedErrors = JsonConvert.SerializeObject(errors);
                TempData["ModelStateErrors"] = serializedErrors;


                //NOT WORKING YET
                return View("DetailsForm", formModel);
            }

            //Create a new specimen
            Guid newSpecimenIndex = await _specimenService.AddSpecimenAsync(formModel, userId);

            return RedirectToAction("Details", "Specimen", new { id = newSpecimenIndex });
        }
    }
}
