using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace Car_Rental_System.CustomModels
{
    public class DriverModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Driver Name ")]
        [Display(Name = "Name")]
        public string Driver_Name { get; set; }
        [Required(ErrorMessage = "Please Enter City Name ")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter District Name ")]
        public string District { get; set; }
        [Required(ErrorMessage = "Please Enter Mobile Number ")]
        [Display(Name = "Mobile")]
        public string Mobile_Number { get; set; }
        [Required(ErrorMessage = "Please Enter the Age ")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please Enter the time  ")]
        [Display(Name ="Start Driving")]
        public DateTime Driving_Year { get; set; }

        public int Experience
        {
            get
            {
                return (DateTime.Now.Year - Driving_Year.Year);
            }

        }
        public string ImagePath { get; set; }
        public IFormFile DriverFile { get; set; }
    }
}
