using Car_Rental_System.CustomModels;
using Car_Rental_System.Data;
using Car_Rental_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Rental_System.Repository.RentRepository
{
    public class RentRepository : IRentRepository
    {
        private readonly ApplicationDbContext _db;
        public RentRepository(ApplicationDbContext _db)
        {
            this._db = _db;
        }

        public List<RentModel> GetAllRent()
        {
            var NewRent = new List<RentModel>();
            var data = _db.Rents.Include(x => x.Car).Include(y => y.Driver).ToList();
            if (data?.Any() == true) 
            {
                foreach (var obj in data)
                {
                    NewRent.Add(new RentModel
                    {
                        Id = obj.Id,
                        CustomerName = obj.CustomerName,
                        Customer_Phone = obj.Customer_Phone,
                        Rent_Date = obj.Rent_Date,
                        Return_Date = obj.Return_Date,
                        Status = obj.Status,
                        Driver_Name = obj.Driver.Driver_Name,
                        Car_Name = obj.Car.Brand,
                        CarId = obj.Car.Id,
                        DriverId = obj.Driver.Id,
                        TotalAmount = obj.TotalAmount,

                    });
                    
                }
            }
            return NewRent;
        }
        public int AddBooking(RentModel obj)
        {
            var data = new Rent()
            {
                Id = obj.Id,
                CustomerName = obj.CustomerName,
                Customer_Phone = obj.Customer_Phone,
                Rent_Date = obj.Rent_Date,
                Return_Date = obj.Return_Date,
                Status = obj.Status,
                DriverId = obj.DriverId,
                CarId = obj.CarId,
            };
            _db.Rents.Add(data);
            _db.SaveChanges();
            return obj.Id;
        }
    }
}
