using Duende.IdentityServer.Models;
using ExpertPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

public static class DbSeeder
{
    public static async Task Seed(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
    {
        if (!context.Users.Any())
        {
            await SeedUsers(userManager, context);
        }
    }

    private static async Task SeedUsers(UserManager<ApplicationUser> userManager, ApplicationDbContext context)
    {
        try
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();

            ApplicationUser[] users = {
                new ApplicationUser { UserName = "zero50x",Link="@zero50x", NormalizedUserName = "zero50x", Email = "zero50x@example.com", NormalizedEmail = "zero50x@example.com", Role = UserRole.Admin, FirstName = "Вадим", MiddleName = "Дроздов", LastName = "Эдуардович", Position = Position.Senior, City = "Москва", PasswordHash = passwordHasher.HashPassword(null, "zero50x") },
                new ApplicationUser { UserName = "zaikin88",Link="@zaikin88", NormalizedUserName = "zaikin88", Email = "zaikin88@example.com", NormalizedEmail = "zaikin88@example.com", Role = UserRole.RegularUser, FirstName = "Ваня", MiddleName = "Заикин", LastName = "Александрович", Position = Position.Senior, City = "Москва", PasswordHash = passwordHasher.HashPassword(null, "zaikin88") },
                new ApplicationUser { UserName = "nikonovnn",Link="@nikonovnn", NormalizedUserName = "nikonovnn", Email = "nikonovnn@example.com", NormalizedEmail = "nikonovnn@example.com", Role = UserRole.RegularUser, FirstName = "Николай", MiddleName = "Никонов", LastName = "Николаевич", Position = Position.Senior, City = "Москва", PasswordHash = passwordHasher.HashPassword(null, "nikonovnn") },
                new ApplicationUser { UserName = "jewestyes",Link="@jewestyes", NormalizedUserName = "jewestyes", Email = "jewestyes@example.com", NormalizedEmail = "jewestyes@example.com", Role = UserRole.Admin, FirstName = "Кузин", MiddleName = "Артемий", LastName = "Вадимович", Position = Position.Middle, City = "Москва", PasswordHash = passwordHasher.HashPassword(null, "jewestyes") },
                new ApplicationUser { UserName = "kurier_express",Link="@kurier_express", NormalizedUserName = "kurier_express", Email = "kurier_express@example.com", NormalizedEmail = "kurier_express@example.com", Role = UserRole.RegularUser, FirstName = "Белеза", MiddleName = "Никита", LastName = "Эдуардович", Position = Position.Middle, City = "Москва", PasswordHash = passwordHasher.HashPassword(null, "kurier_express") },
                new ApplicationUser { UserName = "IVkulakov",Link="@IVkulakov", NormalizedUserName = "IVkulakov", Email = "IVkulakov@example.com", NormalizedEmail = "IVkulakov@example.com", Role = UserRole.RegularUser, FirstName = "Ваня", MiddleName = "Кулаков", LastName = "Андреевич", Position = Position.Middle, City = "Москва", PasswordHash = passwordHasher.HashPassword(null, "IVkulakov") }

        };

            foreach (var user in users)
                await userManager.CreateAsync(user);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during user seeding: {ex.Message}");
        }
    }

}
