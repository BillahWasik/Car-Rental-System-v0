using Car_Rental_System.CustomModels;
using Car_Rental_System.Models;
using Car_Rental_System.Repository.CarRepository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

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
           var data =  _db.GetAllCar();
            return View(data);
        }
        public IActionResult Create(bool IsSuccess = false) 
        {
            ViewBag.Success = IsSuccess;
            return View();
        }
        [HttpPost]
        public IActionResult Create(CarModel obj)
        
        {
            if (ModelState.IsValid)
            {
                if (obj != null)
                {
                    string folder = "Image/Car/";
                    folder += Guid.NewGuid().ToString() + "_" + obj.Carfile.FileName;

                    string serverfolder = Path.Combine(_env.WebRootPath, folder);

                    obj.Carfile.CopyTo(new FileStream(serverfolder, FileMode.Create));

                    obj.ImagePath = folder;
                }
                _db.AddNewCar(obj);
               return RedirectToAction(nameof(Create), new { IsSuccess = true });
            }
            return View();
        }

        public IActionResult Edit(int id , bool IsSuccess = false)
        {
            var data = _db.GetDetails(id);
            ViewBag.Success = IsSuccess;
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(CarModel obj)

        {
            if (ModelState.IsValid)
            {
                if (obj != null)
                {
                    string folder = "Image/Car/";
                    folder += Guid.NewGuid().ToString() + "_" + obj.Carfile.FileName;

                    string serverfolder = Path.Combine(_env.WebRootPath, folder);

                    if(obj.ImagePath != null) 
                    {
                        var oldPath = Path.Combine(_env.WebRootPath, obj.ImagePath);

                        if (System.IO.File.Exists(oldPath)) 
                        {
                            System.IO.File.Delete(oldPath);
                        }
                    }

                    obj.Carfile.CopyTo(new FileStream(serverfolder, FileMode.Create));

                    obj.ImagePath = folder;
                }
                _db.EditCar(obj);
                return RedirectToAction(nameof(Edit), new { IsSuccess = true });
            }
            return View();
        }

        public IActionResult Delete(int id, bool IsSuccess = false)
        {
            var data = _db.GetDetails(id);
            ViewBag.Success = IsSuccess;
            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(CarModel obj)

        {
            if (ModelState.IsValid)
            {
                if (obj != null)
                {
                 
                    if (obj.ImagePath != null)
                    {
                        var oldPath = Path.Combine(_env.WebRootPath, obj.ImagePath);

                        if (System.IO.File.Exists(oldPath))
                        {
                            System.IO.File.Delete(oldPath);
                        }
                    }
                }
                _db.DeleteCar(obj);
                return RedirectToAction(nameof(Edit), new { IsSuccess = true });
            }
            return View();
        }
    }
}
