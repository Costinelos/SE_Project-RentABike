using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
