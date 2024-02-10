using Microsoft.AspNetCore.Mvc;
using ExpertPlanner.Models;
using Microsoft.EntityFrameworkCore;
using ExpertPlanner.Services;

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

    public IActionResult Details(string tableName)
    {
        var data = _databaseService.GetDataFromTable(tableName);
        return PartialView("~/Views/UserItems/_TableDetails.cshtml", data);
    }
    private string GetWeekNumber(DateTime date)
    {
        return $"{date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Monday):dd-MM-yyyy}";
    }
}