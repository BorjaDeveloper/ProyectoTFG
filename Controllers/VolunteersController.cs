using Microsoft.AspNetCore.Mvc;
using ProyectoTFG.Model;
using ProyectoTFG.Models;

namespace ProyectoTFG.Controllers
{
    public class VolunteersController : Controller
    {
        private readonly AnimalShelterDbContext _context;

        const int ColumnNumber = 3;

        public VolunteersController(AnimalShelterDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VolunteersModel model = BuildVolunteersModel();

            return View(model);
        }

        private VolunteersModel BuildVolunteersModel()
        {
            var model = new VolunteersModel
            {
                Mañana = BuildVolunteerTable(VolunteerTypeEnum.Mañana),
                Tarde = BuildVolunteerTable(VolunteerTypeEnum.Tarde)
            };

            return model;
        }

        private List<List<Volunteer>> BuildVolunteerTable(VolunteerTypeEnum volunteerType)
        {
            var result = new List<List<Volunteer>>();
            var current = new List<Volunteer>();

            foreach (var volunteer in _context.Volunteers.Where(a => a.Type == volunteerType))
            {
                if (current.Count >= ColumnNumber)
                {
                    result.Add(current);
                    current = new List<Volunteer>();
                }

                current.Add(volunteer);
            }

            result.Add(current);

            return result;
        }
    }
}