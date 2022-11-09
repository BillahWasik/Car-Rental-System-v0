using Car_Rental_System.Models;
using Car_Rental_System.Repository.CarRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Car_Rental_System.Controllers
{
    public class CarController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly ICarRepository _db;

        public CarController(IWebHostEnvironment _env, ICarRepository _db)
        {
            this._env = _env;
            this._db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Car obj, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (obj != null)
                {
                    string folder = "Image/Car";
                    folder += Guid.NewGuid().ToString() + "_" + file.FileName;

                    string serverfolder = Path.Combine(_env.WebRootPath, folder);

                    file.CopyTo(new FileStream(serverfolder, FileMode.Create));

                    obj.ImagePath = folder;
                }
                _db.AddNewCar(obj);
                RedirectToAction("Index");
            }
            return View();
        }
    }
}
