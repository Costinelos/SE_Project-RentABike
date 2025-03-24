using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Services
{
    public class BikeService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
