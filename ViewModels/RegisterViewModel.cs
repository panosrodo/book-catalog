using System.ComponentModel.DataAnnotations;

namespace BookCatalog.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Όνομα χρήστη")]
        public string Username { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Κωδικός")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Επιβεβαίωση Κωδικού")]
        [Compare("Password", ErrorMessage = "Οι κωδικοί δεν ταιριάζουν.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}