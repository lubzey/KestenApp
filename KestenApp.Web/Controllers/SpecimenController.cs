﻿namespace KestenApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using KestenApp.Services.Contracts;
    using KestenApp.Web.ViewModels.Specimen;

    public class SpecimenController : BaseController
    {
        private readonly ISpecimenService _specimenService;

        public SpecimenController(
            ISpecimenService specimenService)
        {
            _specimenService = specimenService;
        }

        [Authorize]
        public async Task<IActionResult> List()
        {
            SpecimenListModel listViewModel = await _specimenService
                .AllSpecimensAsync(currentPage: 1);

            return View(listViewModel);
        }
    }
}
