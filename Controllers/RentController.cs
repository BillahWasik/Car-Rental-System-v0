using Car_Rental_System.CustomModels;
using Car_Rental_System.Data;
using Car_Rental_System.Models;
using Car_Rental_System.Repository.CarRepository;
using Car_Rental_System.Repository.RentRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental_System.Controllers
{
    public class RentController : Controller
    {
        private readonly IRentRepository _db;
        private readonly ApplicationDbContext _context;

        public RentController(IRentRepository _db, ApplicationDbContext _context)
        {
            this._db = _db;
            this._context = _context;
        }
        private List<Car>  DropdownDataCar() 
        {
           var data = _context.Cars.ToList();
            return data;
        }
        private List<Customer> DropdownDataCustomer()
        {
            var data = _context.Customers.ToList();
            return data;
        }
        private List<Driver> DropdownDataDriver()
        {
            var data = _context.Drivers.ToList();
            return data;
        }
        public IActionResult Index()
        {
           var data = _db.GetAllRent();
            return View(data);
        }
        public IActionResult CreateBooking()
        {
            ViewBag.Car = new SelectList(DropdownDataCar(),"Id", "Brand");
            ViewBag.Driver = new SelectList(DropdownDataDriver(), "Id", "Driver_Name");
            ViewBag.Customer = new SelectList(DropdownDataCustomer(), "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult CreateBooking(RentModel obj)
        {
            ViewBag.Brand = new SelectList(DropdownDataCar(), "Id", "Brand");
            ViewBag.Driver = new SelectList(DropdownDataDriver(), "Id", "Driver_Name");
            ViewBag.Customer = new SelectList(DropdownDataCustomer(), "Id", "Name");
            if (ModelState.IsValid) 
            {
                _db.AddBooking(obj);
              
            }
            return View();
        }
    }
}
