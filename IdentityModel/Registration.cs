using System.ComponentModel.DataAnnotations;

namespace Car_Rental_System.IdentityModel
{
    public class Registration
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password Do Not Match")]
        public string ConfirmPassword { get; set; }
    }
}
