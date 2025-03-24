using Microsoft.AspNetCore.Mvc;

namespace Project_SE.Services
{
    public class PaymentService : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
