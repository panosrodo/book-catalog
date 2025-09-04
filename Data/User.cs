using System.ComponentModel.DataAnnotations;

namespace BookCatalog.Data
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty; // "Admin" ή "User"
    }
}