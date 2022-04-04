using Microsoft.AspNetCore.Mvc;

namespace ProyectoTFG.Controllers
{
    public class Interno : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
