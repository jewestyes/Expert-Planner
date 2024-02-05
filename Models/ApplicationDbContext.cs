using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExpertPlanner.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<ApplicationUser> AppUsers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUsers");

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { Id = 1, NormalizedUserName = "admin", Role = UserRole.Admin, UserName = "admin", PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "test123"), FirstName = "Вадим", MiddleName = "Дроздов", LastName = "Эдуардович", Position = Position.Senior, City = "Москва" },
                new ApplicationUser { Id = 2, NormalizedUserName = "user1", Role = UserRole.RegularUser, UserName = "user1", PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "test123"), FirstName = "Иван", MiddleName = "Кулаков", LastName = "Валерьевич", Position = Position.Middle, City = "Москва" },
                new ApplicationUser { Id = 3, NormalizedUserName = "user2", Role = UserRole.RegularUser, UserName = "user2", PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "test123"), FirstName = "Михаил", MiddleName = "Киселев", LastName = "Аркадьевич", Position = Position.Junior, City = "Москва" },
                new ApplicationUser { Id = 4, NormalizedUserName = "user3", Role = UserRole.RegularUser, UserName = "user3", PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "test123"), FirstName = "Николай", MiddleName = "Самохин", LastName = "Сергеевич", Position = Position.Junior, City = "Москва" },
                new ApplicationUser { Id = 5, NormalizedUserName = "user4", Role = UserRole.RegularUser, UserName = "user4", PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "test123"), FirstName = "Даниил", MiddleName = "Пашинцев", LastName = "Андреевич", Position = Position.Middle, City = "Москва" },
                new ApplicationUser { Id = 6, NormalizedUserName = "user5", Role = UserRole.RegularUser, UserName = "user5", PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "test123"), FirstName = "Андрей", MiddleName = "Ветлугин", LastName = "Александрович", Position = Position.Senior, City = "Екатеринбург" }
            );
        }
    }
}
