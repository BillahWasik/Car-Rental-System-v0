using Car_Rental_System.Models;
using System.Collections.Generic;

namespace Car_Rental_System.Repository.RentRepository
{
    public interface IRentRepository
    {
        List<Rent> GetAllRent();
        Rent AddBooking(Rent obj);
    }
}