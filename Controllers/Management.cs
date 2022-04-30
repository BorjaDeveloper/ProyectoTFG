using Microsoft.AspNetCore.Mvc;



namespace ProyectoTFG.Controllers
{
    public class Management : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Voluntarios()
        {
            return View();
        }
    }
}
