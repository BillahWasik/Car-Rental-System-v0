using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace Car_Rental_System.CustomModels
{
    public class CarModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Brand Name ")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Please Enter Model Name ")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Registration Year must be given ")]
        [Display(Name ="Reg-Year")]
        public int Registration_Year { get; set; }
        [Required(ErrorMessage = "Registration Number must be given ")]
        [Display(Name = "Reg-Number")]
        public string Registration_Number { get; set; }
        [Required(ErrorMessage = "Please Enter Fuel Type ")]
        [Display(Name = "Fuel Type")]
        public string Fuel_Type { get; set; }
        public string ImagePath { get; set; }
        [Display(Name = "Capacity")]
        [Required(ErrorMessage = "Please Enter Seating Capacity")]
        public int Seating_Capacity { get; set; }
        [Display(Name = "Daily Hire Price")]
        [Required(ErrorMessage = "Please Enter Daily Hire Price")]
        public int DailyHirePrice { get; set; }
        [Required(ErrorMessage = "Please Enter Vehicle Added Time")]
        [Display(Name = "Added On")]
        public DateTime AddedDate { get; set; }
        public IFormFile Carfile { get; set; }
    }
}
