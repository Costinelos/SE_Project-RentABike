using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Models
{
    public class Notification : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
