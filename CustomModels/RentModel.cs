using Car_Rental_System.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Car_Rental_System.CustomModels
{
    public class RentModel
    {
        public int Id { get; set; }
        [Display(Name = "Rent Date")]
        public DateTime Rent_Date { get; set; }
        [Display(Name = "Return Date")]
        public DateTime Return_Date { get; set; }
        public int TotalAmount { get; set; } 
        //[Display(Name = "Customer Name")]
        public int CustomerId { get; set; }
        //[Display(Name = "Phone")]
        public Customer Customer { get; set; }
        [Display(Name = "Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
        [Display(Name ="Driver")]
        public int DriverId { get; set; }
        public Driver Driver { get; set; }
        public string Status { get; set; }
        public string Driver_Name { get; set; }
        public string Car_Name { get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Phone { get; set; }

    }
}
