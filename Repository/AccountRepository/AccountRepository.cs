using Car_Rental_System.IdentityModel;
using Car_Rental_System.Service;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Car_Rental_System.Repository.AccountRepository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<CustomizeUser> _userManager;
        private readonly SignInManager<CustomizeUser> _signInManager;
        private readonly IUserService _userService;

        public AccountRepository(UserManager<CustomizeUser> _userManager , SignInManager<CustomizeUser> _signInManager, IUserService _userService)
        {
            this._userManager = _userManager;
            this._signInManager = _signInManager;
           this._userService = _userService;
        }

        public async Task<IdentityResult> CreateUserAsync(Registration user)
        {
            var data = new CustomizeUser()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.Email,
                Email = user.Email,

            };
            var result = await _userManager.CreateAsync(data, user.Password);
            return result;
        }

        public async Task<SignInResult> SignInUserAsync(SignIn user) 
        {
            var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, user.RememberMe, false);
            return result;
        }
        public async Task SignOutAsync() 
        {
           await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> ChangePassword(PasswordChange obj)
        {
           var userId = _userService.GetUserId();
            var user = await _userManager.FindByIdAsync(userId);

           return await _userManager.ChangePasswordAsync(user,obj.CurrentPassword,obj.NewPassword);
        }
    }

}
