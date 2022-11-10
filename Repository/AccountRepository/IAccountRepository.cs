using Car_Rental_System.IdentityModel;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Car_Rental_System.Repository.AccountRepository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(Registration user);
        Task<SignInResult> SignInUser(SignIn user);
    }
}