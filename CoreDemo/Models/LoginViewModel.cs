using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
