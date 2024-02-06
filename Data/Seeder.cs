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
                new ApplicationUser { UserName = "admin", NormalizedUserName = "admin", Email = "admin@example.com", NormalizedEmail = "admin@example.com", Role = UserRole.Admin, FirstName = "Вадим", MiddleName = "Дроздов", LastName = "Эдуардович", Position = Position.Senior, City = "Москва", PasswordHash = passwordHasher.HashPassword(null, "admin@123") },
                new ApplicationUser{UserName = "user",NormalizedUserName = "user", Email = "user@example.com",NormalizedEmail = "user@example.com",Role = UserRole.RegularUser,FirstName = "Роберт",MiddleName = "Мубаракшин",LastName = "Эдуардович",Position = Position.Intern,City = "Москва",PasswordHash = passwordHasher.HashPassword(null, "user@123") },
                new ApplicationUser{UserName = "test",NormalizedUserName = "test",Email = "test@example.com",NormalizedEmail = "test@example.com",Role = UserRole.RegularUser,FirstName = "Егор",MiddleName = "Лукьянов",LastName = "Эдуардович",Position = Position.Middle,City = "Москва",PasswordHash = passwordHasher.HashPassword(null, "test@123") } };

            foreach (var user in users)
                await userManager.CreateAsync(user);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error during user seeding: {ex.Message}");
        }
    }

}
