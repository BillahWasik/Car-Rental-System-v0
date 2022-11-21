using Car_Rental_System.CustomModels;
using System.Collections.Generic;

namespace Car_Rental_System.Repository.DriverRepository
{
    public interface IDriverRepository
    {
        int AddNewDriver(DriverModel obj);
        DriverModel DeleteDriver(DriverModel obj);
        DriverModel EditDriver(DriverModel obj);
        List<DriverModel> GetAllDriver();
        DriverModel GetDetails(int id);
    }
}