using System.ComponentModel.DataAnnotations;

namespace Authentication.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class RegisterModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
