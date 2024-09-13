using FirstProject.Context;
using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Controllers
{
    public class UserController : Controller
    {
        

        ContextClass _context = new ContextClass();

        // Action method to register a new user
        [HttpPost]
        public IActionResult Register(User user)
        {
            var IsRegistered = _context.Users.Any(e => e.Email == user.Email);

            if (IsRegistered)
            {
                ModelState.AddModelError("", "User Already Registered");
                return View();
            }

            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);
        }

        // Action method for user login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                // Logic for successful login
                return RedirectToAction("Index", "Product");
            }
            ModelState.AddModelError("", "Invalid login attempt.");
            return View();
        }

        // GET method for Register view
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // GET method for Login view
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }

}
