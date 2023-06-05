﻿using KestenTestApp.Models;
using KestenTestApp.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KestenTestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IVarietyRepository _varietyRepository;

        public HomeController(IVarietyRepository varietyRepository, ILogger<HomeController> logger)
        {
            _varietyRepository = varietyRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Variety> allVarieties = _varietyRepository.AllVarieties;

            //Create a view

            return View();
        }

        public IActionResult Privacy()
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