using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Data
{
    public class ApplicationDB : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
