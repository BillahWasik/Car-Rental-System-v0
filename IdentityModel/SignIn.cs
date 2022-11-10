using System.ComponentModel.DataAnnotations;

namespace Car_Rental_System.IdentityModel
{
    public class SignIn
    {
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
