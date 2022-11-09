using Car_Rental_System.Models;
using Car_Rental_System.ViewModel;
using System.Collections.Generic;

namespace Car_Rental_System.Repository.CarRepository
{
    public interface ICarRepository
    {
        CarVM AddNewCar(CarVM obj);
        List<Car> GetAllCar();
    }
}