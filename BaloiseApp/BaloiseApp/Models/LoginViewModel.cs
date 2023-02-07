using BaloiseApp.Validators;
using System.ComponentModel.DataAnnotations;

namespace BaloiseApp.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email obligatoire")]
        //[EmailAddress]
        [MyEmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
