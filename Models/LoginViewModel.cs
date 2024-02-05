using System.ComponentModel.DataAnnotations;

namespace ExpertPlanner.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле 'Логин' обязательно для заполнения")]
        [Display(Name = "Логин")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Поле 'Пароль' обязательно для заполнения")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня")]
        public bool RememberMe { get; set; }
    }
}
