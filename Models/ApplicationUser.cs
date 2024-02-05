using Microsoft.AspNetCore.Identity;

namespace ExpertPlanner.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; }
        public string UserName {  get; set; }
        public string NormalizedUserName {  get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public Position Position { get; set; }
        public UserRole Role { get; set; }
        public string PasswordHash { get; set; }
    }

    public enum Position
    {
        Lead,
        Expert,
        Senior,
        Middle,
        Junior,
        Intern
    }

    public enum UserRole
    {
        Admin,
        RegularUser
    }
}
