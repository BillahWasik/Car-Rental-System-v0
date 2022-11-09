using Microsoft.AspNetCore.Mvc;

namespace Car_Rental_System.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
