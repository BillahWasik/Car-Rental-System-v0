using Microsoft.AspNetCore.Mvc;

namespace Car_Rental_System.Controllers
{
    public class RentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
