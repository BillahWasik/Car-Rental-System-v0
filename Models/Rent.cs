using System;

namespace Car_Rental_System.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public DateTime Rent_Date { get; set; }
        public DateTime Return_Date { get; set; }
        public int Days
        {
            get 
            {
               return (Return_Date - Rent_Date).Days;
            }
        }
        public int TotalAmount
        {
            get
            {
                return (Days * Car.DailyHirePrice);
            }
        }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public string Status { get; set; }
       
    }
}
