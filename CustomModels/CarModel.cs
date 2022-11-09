using Microsoft.AspNetCore.Http;

namespace Car_Rental_System.CustomModels
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Passing_Year { get; set; }
        public string Car_Number { get; set; }
        public string Engine { get; set; }
        public string Fuel_Type { get; set; }
        public string ImagePath { get; set; }
        public int Seating_Capacity { get; set; }
        public IFormFile Carfile { get; set; }
    }
}
