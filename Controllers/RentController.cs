using Car_Rental_System.Data;
using Car_Rental_System.Models;
using Car_Rental_System.Repository.CarRepository;
using Car_Rental_System.Repository.RentRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

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
        private List<Driver> DropdownDataDriver()
        {
            var data = _context.Drivers.ToList();
            return data;
        }
        public IActionResult Index()
        {
           var data = _db.GetAllRent().ToList();
            return View(data);
        }
        [Authorize]
        public IActionResult CreateBooking()
        {
            ViewBag.Brand = new SelectList(DropdownDataCar(),"Id","Brand");
            ViewBag.Model = new SelectList(DropdownDataCar(), "Id", "Model");
            ViewBag.Driver = new SelectList(DropdownDataDriver(), "Id", "Driver_Name");
            return View();
        }
        [HttpPost]
        public IActionResult CreateBooking(Rent obj)
        {
            ViewBag.Brand = new SelectList(DropdownDataCar(), "Id", "Brand");
            ViewBag.Brand = new SelectList(DropdownDataCar(), "Id", "Model");
            if (ModelState.IsValid) 
            {
                if(obj != null) 
                {
                    _db.AddBooking(obj);
                    return RedirectToAction(nameof(CreateBooking));
                }
              
            }
            return View();
        }
    }
}
