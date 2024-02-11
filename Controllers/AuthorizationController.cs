using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ExpertPlanner.Models;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

[AutoValidateAntiforgeryToken]
public class AuthorizationController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly ILogger<AuthorizationController> _logger;
    private readonly IAntiforgery _antiforgery;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuthorizationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
        ILogger<AuthorizationController> logger, IAntiforgery antiforgery, IHttpContextAccessor httpContextAccess)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _logger = logger;
        _antiforgery = antiforgery;
        _httpContextAccessor = httpContextAccess;
    }
    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> Auth()
    {
        bool rememberMe = Request.Cookies["RememberMe"] == "True";

        if (User.Identity.Name != null & ( User.Identity.IsAuthenticated || rememberMe) )
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var fullName = $"{user.FirstName} {user.MiddleName}";
            _httpContextAccessor.HttpContext.Session.SetString("UserFullName", fullName);

            return RedirectToAction("Index", "Home");
        }

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
                Secure = true,
                Expires = model.RememberMe ? DateTime.Now.AddDays(30) : DateTime.Now.AddDays(1),
                HttpOnly = true
            };
            var tokens = _antiforgery.GetAndStoreTokens(HttpContext);
            HttpContext.Session.SetString("CSRFToken", tokens.RequestToken);

            Response.Cookies.Append("MyCookieName", "MyCookieValue", cookieOptions);
            Response.Cookies.Append("RememberMe", model.RememberMe.ToString(), cookieOptions);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                await _signInManager.SignInAsync(user, model.RememberMe);

                var fullName = $"{user.FirstName} {user.MiddleName}";
                _httpContextAccessor.HttpContext.Session.SetString("UserFullName", fullName);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Неверный логин или пароль");
        }

        return RedirectToAction("Auth", "Authorization");
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        Response.Cookies.Delete("RememberMe");
        return RedirectToAction("Auth", "Authorization");
    }
}
