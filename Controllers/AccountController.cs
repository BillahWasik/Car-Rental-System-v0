using Car_Rental_System.IdentityModel;
using Car_Rental_System.Repository.AccountRepository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Car_Rental_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _db;
        public AccountController(IAccountRepository _db)
        {
            this._db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
       [HttpPost]
        public async Task<IActionResult>  SignUp(Registration obj)
        {
            if (ModelState.IsValid) 
            {
                var result = await _db.CreateUserAsync(obj);
                if (!result.Succeeded) 
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(SignIn obj, string returnUrl)
        {
            if (ModelState.IsValid) 
            {
                var result = await _db.SignInUserAsync(obj);
                if (result.Succeeded) 
                {
                    if (!string.IsNullOrEmpty(returnUrl)) 
                    {
                        return LocalRedirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                    
                }
                ModelState.AddModelError("", "Login Failed");
            }
            return View(obj);
        }

        public async Task<IActionResult> LogOut() 
        {
            await _db.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
