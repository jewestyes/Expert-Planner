using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ExpertPlanner.Models;

public class AuthorizationController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AuthorizationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Auth()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByNameAsync(model.Username)
           ?? await _userManager.FindByEmailAsync(model.Username);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                await _signInManager.SignInAsync(user, model.RememberMe);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Неверный логин или пароль");
        }

        return View("Auth", model);
    }
}
