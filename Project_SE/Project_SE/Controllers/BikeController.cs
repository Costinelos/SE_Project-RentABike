using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_SE.Interfaces;
using Project_SE.Models;

namespace Project_SE.Controllers
{
    public class BikeController : Controller
    {
        private readonly IBikeService _bikeService;

        public BikeController(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }

        // GET: Bike
        public async Task<IActionResult> Index()
        {
            var bikes = await _bikeService.GetAllBikesAsync();
            return View(bikes);
        }

        // GET: Bike/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var bike = await _bikeService.GetBikeByIdAsync(id);
            if (bike == null)
            {
                return NotFound();
            }
            return View(bike);
        }

        // GET: Bike/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bike/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(Bike bike)
        {
            if (ModelState.IsValid)
            {
                await _bikeService.AddBikeAsync(bike);
                return RedirectToAction(nameof(Index));
            }
            return View(bike);
        }

        // GET: Bike/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            var bike = await _bikeService.GetBikeByIdAsync(id);
            if (bike == null)
            {
                return NotFound();
            }
            return View(bike);
        }

        // POST: Bike/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, Bike bike)
        {
            if (id != bike.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _bikeService.UpdateBikeAsync(bike);
                return RedirectToAction(nameof(Index));
            }
            return View(bike);
        }

        // GET: Bike/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var bike = await _bikeService.GetBikeByIdAsync(id);
            if (bike == null)
            {
                return NotFound();
            }
            return View(bike);
        }

        // POST: Bike/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _bikeService.DeleteBikeAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}