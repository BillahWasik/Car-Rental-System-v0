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
                        Address = item.Address,
                        Age = item.Age,
                        Driver_Name = item.Driver_Name,
                        Experience = item.Experience,
                        Id = item.Id,
                        ImagePath = item.ImagePath,
                        Mobile_Number = item.Mobile_Number,
                    });
                }

            }
            return Driver;
        }
        public DriverModel AddNewDriver(DriverModel obj)
        {
            var NewDriver = new Driver()
            {
                Address = obj.Address,
                Age = obj.Age,
                Driver_Name = obj.Driver_Name,
                Experience = obj.Experience,
                Id = obj.Id,
                ImagePath = obj.ImagePath,
                Mobile_Number = obj.Mobile_Number,
            };

            _db.Drivers.Add(NewDriver);
            _db.SaveChanges();
            return obj;
        }

        public DriverModel EditDriver(DriverModel obj)
        {
            var NewCar = new Driver()
            {
                Address = obj.Address,
                Age = obj.Age,
                Driver_Name = obj.Driver_Name,
                Experience = obj.Experience,
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

                    Address = obj.Address,
                    Age = obj.Age,
                    Driver_Name = obj.Driver_Name,
                    Experience = obj.Experience,
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
                Address = obj.Address,
                Age = obj.Age,
                Driver_Name = obj.Driver_Name,
                Experience = obj.Experience,
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
