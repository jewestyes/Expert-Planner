using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ExpertPlanner.Models;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authorization;

[AutoValidateAntiforgeryToken]
public class AuthorizationController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly ILogger<AuthorizationController> _logger;
    private readonly IAntiforgery _antiforgery;

    public AuthorizationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<AuthorizationController> logger, IAntiforgery antiforgery)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _logger = logger;
        _antiforgery = antiforgery;
    }
    [AllowAnonymous]
    [HttpGet]
    public IActionResult Auth()
    {
        return View();
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByNameAsync(model.Username);

            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1),
                HttpOnly = true
            };
            var tokens = _antiforgery.GetAndStoreTokens(HttpContext);
            HttpContext.Session.SetString("CSRFToken", tokens.RequestToken);

            Response.Cookies.Append("MyCookieName", "MyCookieValue", cookieOptions);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                await _signInManager.SignInAsync(user, model.RememberMe);

                _logger.LogInformation("CSRF token saved to session: {CSRFToken}", tokens.RequestToken);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Неверный логин или пароль");
        }

        return View("Auth", model);
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Auth", "Authorization");
    }
}
