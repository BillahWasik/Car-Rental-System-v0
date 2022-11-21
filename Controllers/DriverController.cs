using Car_Rental_System.CustomModels;
using Car_Rental_System.Repository.DriverRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace Car_Rental_System.Controllers
{
    public class DriverController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private readonly IDriverRepository _db;

        public DriverController(IWebHostEnvironment _env, IDriverRepository _db)
        {
            this._env = _env;
            this._db = _db;
        }
        public IActionResult Index()
        {
            var data = _db.GetAllDriver();
            return View(data);
        }
        public IActionResult Create(bool IsSuccess = false)
        {
            ViewBag.Success = IsSuccess;
            return View();
        }
        [HttpPost]
        public IActionResult Create(DriverModel obj)

        {
            if (ModelState.IsValid)
            {
                if (obj != null)
                {
                    string folder = "Image/Driver/";
                    folder += Guid.NewGuid().ToString() + "_" + obj.DriverFile.FileName;

                    string serverfolder = Path.Combine(_env.WebRootPath, folder);

                    obj.DriverFile.CopyTo(new FileStream(serverfolder, FileMode.Create));

                    obj.ImagePath = folder;
                }
                _db.AddNewDriver(obj);
                return RedirectToAction(nameof(Create), new { IsSuccess = true });
            }
            return View();
        }
        public IActionResult Edit(int id, bool IsSuccess = false)
        {
            var data = _db.GetDetails(id);
            ViewBag.Success = IsSuccess;
            return View(data);
        }
        [HttpPost]
        public IActionResult Edit(DriverModel obj)

        {
            if (ModelState.IsValid)
            {
                if (obj.DriverFile != null)
                {
                    string folder = "Image/Driver/";
                    folder += Guid.NewGuid().ToString() + "_" + obj.DriverFile.FileName;

                    string serverfolder = Path.Combine(_env.WebRootPath, folder);

                    if (obj.ImagePath != null)
                    {
                        var oldPath = Path.Combine(_env.WebRootPath, obj.ImagePath);

                        if (System.IO.File.Exists(oldPath))
                        {
                            System.IO.File.Delete(oldPath);
                        }
                    }

                    obj.DriverFile.CopyTo(new FileStream(serverfolder, FileMode.Create));

                    obj.ImagePath = folder;
                }
                _db.EditDriver(obj);
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
        public IActionResult Delete(DriverModel obj)

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
                _db.DeleteDriver(obj);
                return RedirectToAction(nameof(Edit), new { IsSuccess = true });
            }
            return View();
        }
    }
}
