using Car_Rental_System.CustomModels;
using Car_Rental_System.Models;
using System.Collections.Generic;

namespace Car_Rental_System.Repository.CarRepository
{
    public interface ICarRepository
    {
        CarModel AddNewCar(CarModel obj);
        CarModel EditCar(CarModel obj);
        CarModel GetDetails(int id);
        CarModel DeleteCar(CarModel obj);
        List<CarModel> GetAllCar();
    }
}