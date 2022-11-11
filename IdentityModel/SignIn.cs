using System.ComponentModel.DataAnnotations;

namespace Car_Rental_System.IdentityModel
{
    public class SignIn
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }    

    }
}
