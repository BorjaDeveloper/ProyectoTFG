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

        public IActionResult Booking(int animalId, DateTime date)
        {
            var booking = new Booking
            {
                AnimalId = animalId,
                ClientId = AnimalShelterDbContext.CurrentUser!.Id,
                Date = date
            };

            _context.Add(booking);

            _context.SaveChanges();

            return View("BookingDone");
        }
    }
}
