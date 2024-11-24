using ETS_Go_ASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETS_Go_ASP.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public IActionResult Index()
        {
            return View(new LoginModel());
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Dummy login check (replace this with your actual authentication logic)
                if (model.Username == "admin" && model.Password == "password")
                {
                    // Redirect to a different action (e.g., Welcome page after successful login)
                    return RedirectToAction("Welcome");
                }
                else
                {
                    TempData["ErrorMessage"] = "Invalid login attempt.";
                }
            }

            // If we reach this point, it means the model is invalid or login failed, so return to the login page
            return View(model);
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}