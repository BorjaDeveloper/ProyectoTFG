using Microsoft.AspNetCore.Mvc;
using ProyectoTFG.Model;

namespace ProyectoTFG.Controllers
{
    public class ClientController : Controller
    {
        private readonly AnimalShelterDbContext _context;

        public ClientController(AnimalShelterDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
