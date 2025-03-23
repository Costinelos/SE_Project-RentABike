using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Models
{
    public class Bike : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
