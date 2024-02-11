using Microsoft.AspNetCore.Mvc;
using ExpertPlanner.Services;
using ExpertPlanner.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

public class UserItemsController : Controller
{
    private readonly DatabaseService _databaseService;

    public UserItemsController(DatabaseService databaseService)
    {
        _databaseService = databaseService;
    }

    public IActionResult UserIndex()
    {
        var tableNames = _databaseService.GetTableNames();
        return View(tableNames);
    }

    public async Task<IActionResult> Details(string tableName)
    {
        var data = await _databaseService.GetDataFromTableAsync(tableName);
        ViewBag.TableName = tableName;
        return PartialView("~/Views/UserItems/_TableDetails.cshtml", data);
    }

    [HttpPost]
    public async Task<IActionResult> SaveTable(string tableName, List<DefaultTable> model)
    {
        if (ModelState.IsValid)
        {
            await _databaseService.UpdateDataInTableAsync(tableName, model);
            return RedirectToAction("Details", new { tableName });
        }
        return View("Details", model);
    }

    private string GetWeekNumber(DateTime date)
    {
        return $"{date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Monday):dd-MM-yyyy}";
    }
}
