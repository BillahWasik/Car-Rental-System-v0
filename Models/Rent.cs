using System;

namespace Car_Rental_System.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public string PickUp { get; set; }
        public string DropOff { get; set; }
        public DateTime PickUp_Date { get; set; }
        public DateTime DropOff_Date { get; set; }
        public int TotalRun { get; set; }
        public int Rate { get; set; }
        public int TotalAmount { get; set; }
        public string CustomerName { get; set; }
        public string Customer_Phone { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
    }
}
