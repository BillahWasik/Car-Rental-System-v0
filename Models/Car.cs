using System;

namespace Car_Rental_System.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Registration_Year { get; set; }
        public string Registration_Number { get; set; }
        public string Fuel_Type { get; set; }
        public string ImagePath { get; set; }
        public int Seating_Capacity { get; set; }
        public int DailyHirePrice { get; set; }
        public DateTime AddedDate { get; set; }

    }
}
