using Microsoft.AspNetCore.Mvc;
using ProyectoTFG.Model;
using ProyectoTFG.Models;

namespace ProyectoTFG.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly AnimalShelterDbContext _context;

        const int columnNumber = 3;

        public AnimalsController(AnimalShelterDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            AnimalsModel model = BuildAnimalsModel();

            return View(model);
        }

        private AnimalsModel BuildAnimalsModel()
        {
            var model = new AnimalsModel
            {
                Dogs = BuildAnimalTable(AnimalTypeEnum.Dog),
                Cats = BuildAnimalTable(AnimalTypeEnum.Cat)
            };

            return model;
        }

        private List<List<Animal>> BuildAnimalTable(AnimalTypeEnum animalType)
        {
            var result = new List<List<Animal>>();
            var current = new List<Animal>();

            foreach (var animal in _context.Animal.Where(a => a.Type == animalType))
            {
                if (current.Count >= columnNumber)
                {
                    result.Add(current);
                    current = new List<Animal>();
                }

                current.Add(animal);
            }

            result.Add(current);

            return result;
        }
    }
}
