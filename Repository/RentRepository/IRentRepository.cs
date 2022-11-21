using Car_Rental_System.CustomModels;
using Car_Rental_System.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Car_Rental_System.Repository.RentRepository
{
    public interface IRentRepository
    {
        List<RentModel> GetAllRent();
        int AddBooking(RentModel obj);
    }
}