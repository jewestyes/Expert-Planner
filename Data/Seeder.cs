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

            var adminUser = new ApplicationUser
            {
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@example.com",
                NormalizedEmail = "admin@example.com",
                Role = UserRole.Admin,
                FirstName = "Вадим",
                MiddleName = "Дроздов",
                LastName = "Эдуардович",
                Position = Position.Senior,
                City = "Москва",
                PasswordHash = passwordHasher.HashPassword(null, "test@123") // Генерация хеша пароля
            };

            await userManager.CreateAsync(adminUser);

            var users = context.Users.ToList();
            foreach (var user in users)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"User Id: {user.Id}, UserName: {user.UserName}, Email: {user.Email}, FirstName: {user.FirstName}, LastName: {user.LastName}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during user seeding: {ex.Message}");
        }
    }

}
