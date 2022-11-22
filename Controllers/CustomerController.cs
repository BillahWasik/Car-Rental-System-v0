using Car_Rental_System.CustomModels;
using Car_Rental_System.Repository.CustomerRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace Car_Rental_System.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository db;
        private readonly IWebHostEnvironment env;

        public CustomerController(ICustomerRepository _db, IWebHostEnvironment env)
        {
            db = _db;
            this.env = env;
        }
        public IActionResult Index()
        {
           var data = db.GetAllCustomer().ToList();
            return View(data);
        }
        public IActionResult Create(bool Success = false) 
        {
            ViewBag.Success = Success;
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerModel obj)
        {
            if (ModelState.IsValid)
            {
                string folder = "Image/Customer/";
                folder += Guid.NewGuid().ToString() + "_" + obj.ImageFile.FileName;

                string serverfolder = Path.Combine(env.WebRootPath, folder);

                obj.ImageFile.CopyTo(new FileStream(serverfolder, FileMode.Create));

                obj.ImageUrl = folder;

                db.CreateCustomer(obj);
                return RedirectToAction(nameof(Create),new {Success = true});
            }
            return View(obj);
        }
    }
}
