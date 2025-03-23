using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Controllers
{
    public class BikeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
