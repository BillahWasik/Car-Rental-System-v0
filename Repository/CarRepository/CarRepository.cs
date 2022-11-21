using Car_Rental_System.CustomModels;
using Car_Rental_System.Data;
using Car_Rental_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Car_Rental_System.Repository.CarRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _db;

        public CarRepository(ApplicationDbContext _db)
        {
            this._db = _db;
        }

        public List<CarModel> GetAllCar()
        {
            var data = _db.Cars.ToList();

            var Car = new List<CarModel>();

            if (data?.Any() == true)
            {
                foreach (var item in data)
                {
                    Car.Add(new CarModel
                    {
                        Id = item.Id,
                        Brand = item.Brand,
                        Model = item.Model,
                        Registration_Number = item.Registration_Number,
                        Fuel_Type = item.Fuel_Type,
                        ImagePath = item.ImagePath,
                        Registration_Year = item.Registration_Year,
                        Seating_Capacity = item.Seating_Capacity,
                        AddedDate = item.AddedDate,
                        DailyHirePrice = item.DailyHirePrice,
                    });
                }
               
            }
            return Car;
        }
        public CarModel AddNewCar(CarModel obj)
        {
            var NewCar = new Car()
            {
                Id = obj.Id,
                Brand = obj.Brand,
                Model = obj.Model,
                Registration_Number = obj.Registration_Number,
                Fuel_Type = obj.Fuel_Type,
                ImagePath = obj.ImagePath,
                Registration_Year = obj.Registration_Year,
                Seating_Capacity = obj.Seating_Capacity,
                AddedDate = obj.AddedDate,
                DailyHirePrice = obj.DailyHirePrice,
            };

            _db.Cars.Add(NewCar);
            _db.SaveChanges();
            return obj;
        }

        public CarModel EditCar(CarModel obj)
        {
            var NewCar = new Car()
            {
                Id = obj.Id,
                Brand = obj.Brand,
                Model = obj.Model,
                Registration_Number = obj.Registration_Number,
                Fuel_Type = obj.Fuel_Type,
                ImagePath = obj.ImagePath,
                Registration_Year = obj.Registration_Year,
                Seating_Capacity = obj.Seating_Capacity,
                AddedDate = obj.AddedDate,
                DailyHirePrice = obj.DailyHirePrice,
            };

            _db.Cars.Update(NewCar);
            _db.SaveChanges();
            return obj;
        }
        public CarModel GetDetails(int id) 
        {
          var obj = _db.Cars.Where(x => x.Id==id).FirstOrDefault();

            if (obj != null)
            {
                var CarDetails = new CarModel()
                {
                    Id = obj.Id,
                    Brand = obj.Brand,
                    Model = obj.Model,
                    Registration_Number = obj.Registration_Number,
                    Fuel_Type = obj.Fuel_Type,
                    ImagePath = obj.ImagePath,
                    Registration_Year = obj.Registration_Year,
                    Seating_Capacity = obj.Seating_Capacity,
                    AddedDate = obj.AddedDate,
                    DailyHirePrice = obj.DailyHirePrice,

                };
                return CarDetails;
            }
            return null;
        }
        public CarModel DeleteCar(CarModel obj)
        {
            var NewCar = new Car()
            {
                Id = obj.Id,
                Brand = obj.Brand,
                Model = obj.Model,
                Registration_Number = obj.Registration_Number,
                Fuel_Type = obj.Fuel_Type,
                ImagePath = obj.ImagePath,
                Registration_Year = obj.Registration_Year,
                Seating_Capacity = obj.Seating_Capacity,
                AddedDate = obj.AddedDate,
                DailyHirePrice = obj.DailyHirePrice,
            };

            _db.Cars.Remove(NewCar);
            _db.SaveChanges();
            return obj;
        }

    }
    }
