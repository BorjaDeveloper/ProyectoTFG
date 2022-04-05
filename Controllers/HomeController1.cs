using Microsoft.AspNetCore.Mvc;

namespace ProyectoTFG.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
