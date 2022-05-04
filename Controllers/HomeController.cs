using Microsoft.AspNetCore.Mvc;
using ProyectoTFG.Models;
using System.Diagnostics;

namespace ProyectoTFG.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Adopta()
        {
            return View();
        }

        public IActionResult QuienesSomos()            
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }

        public IActionResult Reserva()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}