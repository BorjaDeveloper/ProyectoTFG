using Microsoft.AspNetCore.Mvc;

namespace ProyectoTFG.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login(string returnUrl)
        {
            return View();
        }
    }
}
