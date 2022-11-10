using Car_Rental_System.IdentityModel;
using Car_Rental_System.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Car_Rental_System.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomizeUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Rent> Rents { get; set; }
    }
}
