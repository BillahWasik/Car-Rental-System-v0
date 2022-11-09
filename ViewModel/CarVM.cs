using Car_Rental_System.Models;
using Microsoft.AspNetCore.Http;

namespace Car_Rental_System.ViewModel
{
    public class CarVM
    {
        public Car Car { get; set; }
        public IFormFile Carfile { get; set; }
    }
}
