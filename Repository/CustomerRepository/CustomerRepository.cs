using Car_Rental_System.CustomModels;
using Car_Rental_System.Data;
using Car_Rental_System.Models;
using System.Collections.Generic;
using System.Linq;

namespace Car_Rental_System.Repository.CustomerRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext db;

        public CustomerRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public List<CustomerModel> GetAllCustomer()
        {
            var Customer = new List<CustomerModel>();
            var data = db.Customers.ToList();
            if (data?.Any() == true)
            {
                foreach (var item in data)
                {
                    Customer.Add(new CustomerModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Address = item.Address,
                        Phone = item.Phone,
                        ImageUrl = item.ImageUrl,
                    });
                }
            }
            return Customer;
        }
        public int CreateCustomer(CustomerModel obj)
        {
            var data = new Customer()
            {
                Id = obj.Id,
                Name = obj.Name,
                Address = obj.Address,
                Phone = obj.Phone,
                ImageUrl = obj.ImageUrl,
            };
            db.Add(data);
            db.SaveChanges();
            return data.Id;
        }
    }
}
