using Microsoft.AspNetCore.Mvc;
using Project_SE.Models;
using System.Collections.Generic;

namespace Project_SE.Controllers
{
    public class BikeController : Controller
    {
        public IActionResult Index()
        {
            // Date hardcodate
            var bikes = new List<Bike>
            {
                new Bike { Id = 1, Model = "Rockrider ST100", Type = "MTB", Price = 80 },
                new Bike { Id = 2, Model = "Triban RC100", Type = "Șosea", Price = 100 }
            };

            return View(bikes);
        }
    }
}