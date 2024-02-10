using Microsoft.AspNetCore.Mvc;
using ExpertPlanner.Models;
using Microsoft.EntityFrameworkCore;

public class UserItemsController : Controller
{
    private readonly ApplicationDbContext _context;
    public List<TableDataModel> tables = new List<TableDataModel>();

    public UserItemsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ActionResult> UserIndex(string? weekNumber)
    {
        if (string.IsNullOrEmpty(weekNumber))
            weekNumber = GetWeekNumber(DateTime.Now);

        if (!tables.Any(t => t.WeekDate == weekNumber))
        {
            var tableData = new TableDataModel
            {
                WeekDate = weekNumber,
                Employees = await LoadEmployeesData()
            };

            tables.Add(tableData);
        }

        var table = tables.FirstOrDefault(t => t.WeekDate == weekNumber);
        return View(table);
    }

    private async Task<List<ApplicationUser>> LoadEmployeesData()
    {
        var users = await _context.Users.ToListAsync();
        return users;
    }

    private string GetWeekNumber(DateTime date)
    {
        return $"{date.AddDays(-(int)date.DayOfWeek + (int)DayOfWeek.Monday):dd-MM-yyyy}";
    }
}