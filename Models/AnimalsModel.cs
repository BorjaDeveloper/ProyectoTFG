using ProyectoTFG.Model;

namespace ProyectoTFG.Models
{
    public class AnimalsModel
    {
        public List<List<Animal>> Dogs { get; set; } = new List<List<Animal>>();
        public List<List<Animal>> Cats { get; set; } = new List<List<Animal>>();
    }
}
