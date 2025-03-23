using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
