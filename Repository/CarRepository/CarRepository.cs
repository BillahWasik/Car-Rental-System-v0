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
                        Car_Number = item.Car_Number,
                        Engine = item.Engine,
                        Fuel_Type = item.Fuel_Type,
                        ImagePath = item.ImagePath,
                        Passing_Year = item.Passing_Year,
                        Seating_Capacity = item.Seating_Capacity,
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
                Engine = obj.Engine,
                ImagePath = obj.ImagePath,
                Car_Number = obj.Car_Number,
                Fuel_Type = obj.Fuel_Type,
                Passing_Year = obj.Passing_Year,
                Seating_Capacity = obj.Seating_Capacity
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
                Engine = obj.Engine,
                ImagePath = obj.ImagePath,
                Car_Number = obj.Car_Number,
                Fuel_Type = obj.Fuel_Type,
                Passing_Year = obj.Passing_Year,
                Seating_Capacity = obj.Seating_Capacity
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
                    Engine = obj.Engine,
                    ImagePath = obj.ImagePath,
                    Car_Number = obj.Car_Number,
                    Fuel_Type = obj.Fuel_Type,
                    Passing_Year = obj.Passing_Year,
                    Seating_Capacity = obj.Seating_Capacity

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
                Engine = obj.Engine,
                ImagePath = obj.ImagePath,
                Car_Number = obj.Car_Number,
                Fuel_Type = obj.Fuel_Type,
                Passing_Year = obj.Passing_Year,
                Seating_Capacity = obj.Seating_Capacity
            };

            _db.Cars.Remove(NewCar);
            _db.SaveChanges();
            return obj;
        }

    }
    }
