using KestenApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace KestenApp.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signIInManager;

        public UserController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signIInManager)
        {
            this.userManager = userManager;
            this.signIInManager = signIInManager;
        }

        public IActionResult Register() => View();

        //[HttpPost]
        //public IActionResult Register(RegisterFormModel user)
        //{ 
        //    if (!ModelState.IsValid)
        //    {
        //        return View(user);
        //    }
        //}
    }
}
