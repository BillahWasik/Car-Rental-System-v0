using Car_Rental_System.Data;
using Car_Rental_System.Models;
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
        public Car AddNewCar(Car obj)
        {
            _db.Cars.Add(obj);
            _db.SaveChanges();
            return obj;
        }
    }
}
