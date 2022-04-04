using Microsoft.AspNetCore.Mvc;

namespace ProyectoTFG.Views.Management
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
