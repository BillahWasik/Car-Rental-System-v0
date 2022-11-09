using Car_Rental_System.Models;
using System.Collections.Generic;

namespace Car_Rental_System.Repository.CarRepository
{
    public interface ICarRepository
    {
        Car AddNewCar(Car obj);
        List<Car> GetAllCar();
    }
}