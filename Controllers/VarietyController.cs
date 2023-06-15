using KestenTestApp.Contracts;
using KestenTestApp.Models.View;
using Microsoft.AspNetCore.Mvc;

namespace KestenTestApp.Controllers
{
    public class VarietyController : Controller
    {
        private readonly IVarietyRepository _varietyRepository;
        public IWebHostEnvironment _environment { get; }

        public VarietyController(IVarietyRepository varietyRepository, IWebHostEnvironment environment)
        {
            _varietyRepository = varietyRepository;
            _environment = environment;
        }

        //public IActionResult Index()
        //{
        //    IEnumerable<Variety> varieties = _varietyRepository
        //            .AllVarieties
        //            .OrderBy(p => p.VarietyId);

        //    return View(new VarietyListViewModel(varieties));
        //}

        public ViewResult List()
        {
            IEnumerable<VarietyListDetailsViewModel> varieties = _varietyRepository
                .AllVarieties
                .OrderBy(p => p.VarietyId);

            return View(new VarietyListViewModel(varieties));
        }

        public IActionResult Details(int id)
        {
            var variety = _varietyRepository
                .GetVarietyById(id);
            if (variety == null)
                return NotFound();

            //string contentRootPath = _environment.WebRootPath;

            return View(variety);
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
