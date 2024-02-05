using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

namespace ExpertPlanner.Controllers
{
    public class ForgotPasswordController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ForgotPasswordController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult RestorePassword()
        {
            return View();
        }
    }
}
