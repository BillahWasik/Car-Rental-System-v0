using Car_Rental_System.IdentityModel;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Car_Rental_System.Repository.AccountRepository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<CustomizeUser> _userManager;
        private readonly SignInManager<CustomizeUser> _signInManager;

        public AccountRepository(UserManager<CustomizeUser> _userManager , SignInManager<CustomizeUser> _signInManager)
        {
            this._userManager = _userManager;
            this._signInManager = _signInManager;
        }

        public async Task<IdentityResult> CreateUserAsync(Registration user)
        {
            var data = new CustomizeUser
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.Username,
                Email = user.Email,

            };
            var result = await _userManager.CreateAsync(data, user.Password);
            return result;
        }

        public async Task<SignInResult> SignInUser(SignIn user) 
        {
           var data = await _signInManager.PasswordSignInAsync(user.Email, user.Password , false , false);
            return data;
        }
    }

}
