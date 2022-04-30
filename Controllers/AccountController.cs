using Microsoft.AspNetCore.Mvc;
using ProyectoTFG.Model;
using ProyectoTFG.Models;

namespace ProyectoTFG.Controllers
{
    public class AccountController : Controller
    {
        private readonly AnimalShelterDbContext _context;

        public AccountController(AnimalShelterDbContext context)
        {
            _context = context;
        }

        public IActionResult Login(string returnUrl)
        {
            var model = new AccountModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        public IActionResult SignIn(string username, string password, string returnUrl)
        {
            var user = _context.Users.FirstOrDefault(u => u.Name.ToLower() == username.ToLower());

            if (user != null)
            {
                AnimalShelterDbContext.CurrentUser = user;

                return Redirect(returnUrl);
            }

            var model = new AccountModel
            {
                ReturnUrl = returnUrl,
                ErrorMessage = "El usuario no existe"
            };

            return View("Login", model);
        }
    }
}
