using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Services
{
    public class ReservationService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
