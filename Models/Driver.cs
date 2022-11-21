using System;

namespace Car_Rental_System.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Driver_Name { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        public string Mobile_Number { get; set; }
        public int Age { get; set; }
        public DateTime Driving_Year { get; set; }

        public int Experience {
            get 
            {
                return  (DateTime.Now.Year - Driving_Year.Year);
            }
       
        }
        public string ImagePath { get; set; }
    }
}
