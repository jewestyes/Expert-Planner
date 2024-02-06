// Пример контроллера
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ExpertPlanner.Models;
using Microsoft.EntityFrameworkCore;
using ExpertPlanner.Controllers;

public class UserItemsController : Controller
{
    private readonly ApplicationDbContext _context;



    private readonly ILogger<HomeController> _logger;


    public UserItemsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [ValidateAntiForgeryToken]
    public async Task<IActionResult> UserIndex()
    {
        var users = await _context.Users.ToListAsync();
        return View(users);
    }
}
