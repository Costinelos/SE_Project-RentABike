using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Services
{
    public class NotificationService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
