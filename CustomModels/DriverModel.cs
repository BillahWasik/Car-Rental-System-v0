using Microsoft.AspNetCore.Http;

namespace Car_Rental_System.CustomModels
{
    public class DriverModel
    {
        public int Id { get; set; }
        public string Driver_Name { get; set; }
        public string Address { get; set; }
        public string Mobile_Number { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public string ImagePath { get; set; }
        public IFormFile DriverFile { get; set; }
    }
}
