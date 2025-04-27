// RegisterViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace Project_SE.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Email-ul este obligatoriu")]
        [EmailAddress(ErrorMessage = "Email invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Parola este obligatorie")]
        [StringLength(100, ErrorMessage = "Parola trebuie să aibă între {2} și {1} caractere.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmă parola")]
        [Compare("Password", ErrorMessage = "Parolele nu coincid.")]
        public string ConfirmPassword { get; set; }
    }
}