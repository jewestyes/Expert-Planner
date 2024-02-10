using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpertPlanner.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<ApplicationUser> AppUsers { get; set; }
        public DbSet<UserItemViewModel> GrafikTables { get; set; }

        public DbSet<DefaultTable> DefaultTables { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserItemViewModel>().HasNoKey();
            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUsers");
        }
    }
}
