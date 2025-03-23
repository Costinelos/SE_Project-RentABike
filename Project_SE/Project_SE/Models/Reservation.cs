using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Models
{
    public class Reservation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
