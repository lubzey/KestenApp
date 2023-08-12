namespace KestenApp.Web.Controllers
{
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Memory;
    using KestenApp.Data.Models;
    using KestenApp.Web.ViewModels.User;
    using static KestenApp.Common.NotificationMessagesConstants;

    public class UserController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IMemoryCache memoryCache;

        public UserController(SignInManager<ApplicationUser> signInManager,
                              UserManager<ApplicationUser> userManager,
                              IMemoryCache memoryCache)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;

            this.memoryCache = memoryCache;
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("List", "Variety");
            }

            return View();
        }

        [HttpPost]
        //[ValidateRecaptcha(Action = nameof(Register),
        //    ValidationFailedAction = ValidationFailedAction.ContinueRequest)]
        public async Task<IActionResult> Register([FromForm] RegisterFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser user = new ApplicationUser()
            {
                DisplayName = model.DisplayName
            };

            await userManager.SetEmailAsync(user, model.Email);
            await userManager.SetUserNameAsync(user, model.DisplayName);

            IdentityResult result =
                await userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }

            await signInManager.SignInAsync(user, false);
            //this.memoryCache.Remove(UsersCacheKey);

            return RedirectToAction("List", "Variety");
        }

        [HttpGet]
        public async Task<IActionResult> Login([FromQuery] string? returnUrl)
        {
            if (User.Identity?.IsAuthenticated ?? false)
            {
                return View("Error401");
            }

            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            LoginFormModel model = new LoginFormModel()
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result =
                await signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                TempData[ErrorMessage] =
                    "There was an error while logging you in! Please try again later or contact an administrator.";

                return View(model);
            }

            return model.ReturnUrl != null
                ? Redirect(model.ReturnUrl)
                : RedirectToAction("List", "Variety");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Login", "User");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userManager.GetUserId(User)}'.");
            }

            IList<string> roles = await userManager.GetRolesAsync(user);

            var model = new IndexViewModel
            {
                Username = user.UserName,
                Email = user.Email ?? "",
                Roles = string.Join(", ", roles),
                DisplayName = user.DisplayName
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] IndexViewModel model)
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await userManager.GetUserAsync(User);
                return View(model);
            }

            user.UserName = model.Username;
            user.Email = model.Email;
            user.DisplayName = model.DisplayName;

            var result = await userManager.UpdateAsync(user);
            if (result.Errors.Any())
            {
                model.StatusMessage = $"Error: {Environment.NewLine} {string.Join($", {Environment.NewLine}", result.Errors.Select(e => e.Description))}";
                return View(model);
            }

            model.StatusMessage = "Your profile has been updated";
            return View(model);
        }
    }
}
