using Microsoft.AspNetCore.Identity;

namespace Car_Rental_System.IdentityModel
{
    public class CustomizeUser : IdentityUser 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
