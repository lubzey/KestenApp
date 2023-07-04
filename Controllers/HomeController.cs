﻿using KestenApp.Contracts;
using KestenApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KestenApp.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVarietyService _varietyService;

        public HomeController(IVarietyService varietyService, ILogger<HomeController> logger)
        {
            _varietyService = varietyService; //Preview
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}