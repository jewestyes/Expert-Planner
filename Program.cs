using ExpertPlanner.Models;
using ExpertPlanner.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Конфигурация хоста
builder.Host.UseContentRoot(System.IO.Directory.GetCurrentDirectory());
builder.Host.UseEnvironment(builder.Configuration.GetValue<string>("ASPNETCORE_ENVIRONMENT"));

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<FileVersionHelper>();

// Добавление конфигурации из appsettings.json
builder.Configuration.AddJsonFile("appsettings.json");

// Добавление DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Authorization}/{action=Auth}/{id?}");

app.Run();
