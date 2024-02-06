using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ExpertPlanner.Models;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.Extensions.Logging;

public class AuthorizationController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly ILogger<AuthorizationController> _logger;

    public AuthorizationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<AuthorizationController> logger)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Auth()
    {
        return View();
    }

    [ValidateAntiForgeryToken, HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model, [FromServices] IAntiforgery antiforgery)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByNameAsync(model.Username);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                await _signInManager.SignInAsync(user, model.RememberMe);

                var tokens = antiforgery.GetAndStoreTokens(HttpContext);
                HttpContext.Session.SetString("CSRFToken", tokens.RequestToken);

                _logger.LogInformation("CSRF token saved to session: {CSRFToken}", tokens.RequestToken);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Неверный логин или пароль");
        }

        return View("Auth", model);
    }

    [ValidateAntiForgeryToken, HttpPost]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Auth", "Authorization");
    }
}
