namespace KestenApp.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;


    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error([FromQuery] int id)
        {
            if (id == 400 || id == 404)
            {
                return View("Error404");
            }

            if (id == 401)
            {
                return View("Error401");
            }

            return View();
        }
    }
}