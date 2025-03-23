using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
