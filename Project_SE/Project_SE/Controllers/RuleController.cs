using Project_SE.Models;
using Project_SE.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Project_SE.Controllers
{
    public class RuleController : Controller
    {
        private readonly IRuleService _ruleService;

        public RuleController(IRuleService ruleService)
        {
            _ruleService = ruleService;
        }

        public async Task<IActionResult> Index()
        {
            var rules = await _ruleService.GetAllAsync();
            return View(rules);
        }

        public async Task<IActionResult> Details(int id)
        {
            var rule = await _ruleService.GetByIdAsync(id);
            if (rule == null)
                return NotFound();

            return View(rule);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Rule rule)
        {
            if (ModelState.IsValid)
            {
                await _ruleService.AddAsync(rule);
                return RedirectToAction(nameof(Index));
            }
            return View(rule);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var rule = await _ruleService.GetByIdAsync(id);
            if (rule == null)
                return NotFound();

            return View(rule);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Rule rule)
        {
            if (id != rule.RuleID)
                return NotFound();

            if (ModelState.IsValid)
            {
                await _ruleService.UpdateAsync(rule);
                return RedirectToAction(nameof(Index));
            }
            return View(rule);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var rule = await _ruleService.GetByIdAsync(id);
            if (rule == null)
                return NotFound();

            return View(rule);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _ruleService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
