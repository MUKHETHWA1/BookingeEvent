using BookingEvent.Data;
using BookingEvent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingEvent.Controllers
{
    public class LoginsController : Controller
    {
        private readonly DataContext _context;

        public LoginsController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Login model)
        {
            if (ModelState.IsValid)
            { // Check if the user exists in the database
                var user = await _context.Registers
                    .FirstOrDefaultAsync(u => u.Username == model.Username);
                if (model.Password == user.Password)
                {
                    // Redirect to a secure page after login
                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }
            return View(model);
        }
    }
}
