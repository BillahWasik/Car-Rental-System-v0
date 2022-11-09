using Car_Rental_System.Data;
using Car_Rental_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Car_Rental_System.Repository.RentRepository
{
    public class RentRepository : IRentRepository
    {
        private readonly ApplicationDbContext _db;
        public RentRepository(ApplicationDbContext _db)
        {
            this._db = _db;
        }

        public List<Rent> GetAllRent()
        {
            var NewRent = new List<Rent>();
            var data = _db.Rents.Include(x => x.Car).Include(y => y.Driver).ToList();
            if (data?.Any() == true) 
            {
                foreach (var obj in data)
                {
                    NewRent.Add(new Rent
                    {
                        Id = obj.Id,
                        PickUp = obj.PickUp,
                        DropOff = obj.DropOff,
                        PickUp_Date = obj.PickUp_Date,
                        DropOff_Date = obj.DropOff_Date,
                        TotalRun = obj.TotalRun,
                        TotalAmount = obj.Rate * obj.TotalRun,
                        Rate = obj.Rate,
                        CarId = obj.CarId,
                        DriverId = obj.DriverId,
                        CustomerName = obj.CustomerName,
                        Customer_Phone = obj.Customer_Phone,
                        Brand = obj.Car.Brand,
                        Model = obj.Car.Model,
                        Driver_Name = obj.Driver.Driver_Name,
                        
                });
                    return NewRent;
                }
            }
            return data;
        }
        public Rent AddBooking(Rent obj)
        {
            var data = new Rent();

            if(obj != null) 
            {
                data.Id = obj.Id;
                data.PickUp = obj.PickUp;
                data.DropOff = obj.DropOff;
                data.PickUp_Date = obj.PickUp_Date;
                data.DropOff_Date = obj.DropOff_Date;
                data.TotalRun = obj.TotalRun;
                data.TotalAmount = obj.TotalAmount;
                data.Rate = obj.Rate;
                data.CarId = obj.CarId;
                data.DriverId = obj.DriverId;
                data.CustomerName = obj.CustomerName;
                data.Customer_Phone = obj.Customer_Phone;
            }
            _db.Add(data);
            _db.SaveChanges();

            return obj;
        }
    }
}
