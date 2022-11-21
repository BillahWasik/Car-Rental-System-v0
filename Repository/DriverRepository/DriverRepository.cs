using Car_Rental_System.CustomModels;
using Car_Rental_System.Data;
using Car_Rental_System.Models;
using System.Collections.Generic;
using System.Linq;

namespace Car_Rental_System.Repository.DriverRepository
{
    public class DriverRepository : IDriverRepository
    {
        private readonly ApplicationDbContext _db;

        public DriverRepository(ApplicationDbContext _db)
        {
            this._db = _db;
        }

        public List<DriverModel> GetAllDriver()
        {
            var data = _db.Drivers.ToList();

            var Driver = new List<DriverModel>();

            if (data?.Any() == true)
            {
                foreach (var item in data)
                {
                    Driver.Add(new DriverModel
                    {
                        City = item.City,
                        District = item.District,
                        Age = item.Age,
                        Driver_Name = item.Driver_Name,
                        Driving_Year = item.Driving_Year,
                        Id = item.Id,
                        ImagePath = item.ImagePath,
                        Mobile_Number = item.Mobile_Number,
                    }); ;
                }

            }
            return Driver;
        }
        public int AddNewDriver(DriverModel obj)
        {
            var NewDriver = new Driver()
            {
                City = obj.City,
                District = obj.District,
                Driving_Year = obj.Driving_Year,
                Age = obj.Age,
                Driver_Name = obj.Driver_Name,
                Id = obj.Id,
                ImagePath = obj.ImagePath,
                Mobile_Number = obj.Mobile_Number,
            };

            _db.Drivers.Add(NewDriver);
            _db.SaveChanges();
            return obj.Id;
        }

        public DriverModel EditDriver(DriverModel obj)
        {
            var NewCar = new Driver()
            {
                City = obj.City,
                District = obj.District,
                Age = obj.Age,
                Driver_Name = obj.Driver_Name,
                Driving_Year=obj.Driving_Year,
                Id = obj.Id,
                ImagePath = obj.ImagePath,
                Mobile_Number = obj.Mobile_Number,
            };

            _db.Drivers.Update(NewCar);
            _db.SaveChanges();
            return obj;
        }
        public DriverModel GetDetails(int id)
        {
            var obj = _db.Drivers.Where(x => x.Id == id).FirstOrDefault();

            if (obj != null)
            {
                var DrivrDetails = new DriverModel()
                {

                    City = obj.City,
                    District = obj.District,
                    Age = obj.Age,
                    Driver_Name = obj.Driver_Name,
                    Driving_Year = obj.Driving_Year,
                    Id = obj.Id,
                    ImagePath = obj.ImagePath,
                    Mobile_Number = obj.Mobile_Number,

                };
                return DrivrDetails;
            }
            return null;
        }
        public DriverModel DeleteDriver(DriverModel obj)
        {
            var NewDriver = new Driver()
            {
                City = obj.City,
                District = obj.District,
                Age = obj.Age,
                Driver_Name = obj.Driver_Name,
                Driving_Year = obj.Driving_Year,
                Id = obj.Id,
                ImagePath = obj.ImagePath,
                Mobile_Number = obj.Mobile_Number,
            };

            _db.Drivers.Remove(NewDriver);
            _db.SaveChanges();
            return obj;
        }
    }
}
