using Car_Rental_System.Data;
using Car_Rental_System.Models;
using Car_Rental_System.ViewModel;
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

        public List<Car> GetAllCar()
        {
            var data = _db.Cars.ToList();
            return data;
        }
        public CarVM AddNewCar(CarVM obj)
        {
            var NewCar = new Car()
            {
                Id = obj.Car.Id,
                Brand = obj.Car.Brand,
                Model = obj.Car.Model,
                Engine = obj.Car.Engine,
                ImagePath = obj.Car.ImagePath,
                Car_Number = obj.Car.Car_Number,
                Fuel_Type = obj.Car.Fuel_Type,
                Passing_Year = obj.Car.Passing_Year,
                Seating_Capacity = obj.Car.Seating_Capacity
            };

            _db.Cars.Add(NewCar);
            _db.SaveChanges();
            return obj;
        }
    }
}
