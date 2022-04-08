using Microsoft.AspNetCore.Mvc;

namespace ProyectoTFG.Controllers
{
    public class Voluntario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
