using Car_Rental_System.CustomModels;
using System.Collections.Generic;

namespace Car_Rental_System.Repository.CustomerRepository
{
    public interface ICustomerRepository
    {
        int CreateCustomer(CustomerModel obj);
        List<CustomerModel> GetAllCustomer();
    }
}