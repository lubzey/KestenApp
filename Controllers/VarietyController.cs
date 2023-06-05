using KestenTestApp.Models;
using KestenTestApp.Models.Repositories;
using KestenTestApp.Models.View;
using Microsoft.AspNetCore.Mvc;
using System.IO.Pipelines;

namespace KestenTestApp.Controllers
{
    public class VarietyController : Controller
    {
        private readonly IVarietyRepository _varietyRepository;

        public VarietyController(IVarietyRepository varietyRepository)
        {
            _varietyRepository = varietyRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<Variety> varieties = _varietyRepository
                    .AllVarieties
                    .OrderBy(p => p.VarietyName);

            return View(new VarietyListViewModel(varieties, null));
        }

        //public ViewResult List(string varietyName)
        //{
        //    IEnumerable<Variety> varieties;
        //    string? currentVariety;

        //    if (string.IsNullOrEmpty(varietyName))
        //    {
        //        varieties = _varietyRepository
        //            .AllVarieties
        //            .OrderBy(p => p.VarietyName);
        //        currentVariety = "All varieties";
        //    }
        //    else
        //    {
        //        varieties = _varietyRepository
        //            .AllVarieties
        //            .Where(p => p.VarietyName.Contains(varietyName))
        //            .OrderBy(p => p.VarietyName);
        //        currentVariety = varieties
        //            .FirstOrDefault()
        //            ?.VarietyName;
        //    }

        //    return View(new VarietyListViewModel(varieties, currentVariety));
        //}

        public IActionResult Details(int id)
        {
            var pie = _varietyRepository.GetVarietyById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
