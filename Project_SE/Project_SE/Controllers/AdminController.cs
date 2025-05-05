using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_SE.Interfaces;
using Project_SE.Models;

namespace Project_SE.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IBikeService _bikeService;

        public AdminController(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            var bikes = await _bikeService.GetAllBikesAsync();
            return View(bikes);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Bike bike)
        {
            if (ModelState.IsValid)
            {
                await _bikeService.AddBikeAsync(bike);
                return RedirectToAction(nameof(Index));
            }
            return View(bike);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var bike = await _bikeService.GetBikeByIdAsync(id);
            if (bike == null) return NotFound();
            return View(bike);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Bike bike)
        {
            if (id != bike.Id) return NotFound();

            if (ModelState.IsValid)
            {
                await _bikeService.UpdateBikeAsync(bike);
                return RedirectToAction(nameof(Index));
            }
            return View(bike);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var bike = await _bikeService.GetBikeByIdAsync(id);
            if (bike == null) return NotFound();
            return View(bike);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _bikeService.DeleteBikeAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}