using Microsoft.AspNetCore.Mvc;
using Project_SE.Services;  // Asigură-te că ai serviciile necesare importate
using Project_SE.Models;    // Importă modelul Profile

namespace Project_SE.Controllers
{
    // Definirea rutei de bază pentru acest controller
    [Route("profile")]
    public class ProfileController : Controller
    {
        private readonly IProfileService _profileService;

        // Constructor pentru injectarea serviciilor necesare
        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        // Ruta pentru vizualizarea profilului (accesibilă la /profile)
        [HttpGet("")]
        public IActionResult Index()
        {
            var profile = _profileService.GetProfileByUserIdAsync(User.Identity.Name); // Presupunând că user-ul este logat
            if (profile == null)
            {
                return NotFound();
            }
            return View(profile);  // Vei returna un View cu datele de profil
        }

        // Ruta pentru editarea profilului (accesibilă la /profile/edit)
        [HttpGet("edit")]
        public IActionResult Edit()
        {
            var profile = _profileService.GetProfileByUserIdAsync(User.Identity.Name);  // Obține profilul utilizatorului
            if (profile == null)
            {
                return NotFound();
            }
            return View(profile);  // Vei returna un View de editare a profilului
        }

        // Adaugă metode pentru salvarea modificărilor, dacă e necesar
        [HttpPost("edit")]
        public IActionResult Edit(Profile profile)
        {
            if (ModelState.IsValid)
            {
                _profileService.UpdateProfileAsync(profile);  // Apel la serviciul de actualizare a profilului
                return RedirectToAction("Index");
            }
            return View(profile);  // Dacă modelul nu este valid, returnezi din nou formularul de editare
        }
    }
}
