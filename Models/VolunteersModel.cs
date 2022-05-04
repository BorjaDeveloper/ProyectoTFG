using ProyectoTFG.Model;

namespace ProyectoTFG.Models
{
    public class VolunteersModel
    {
        public List<List<Volunteer>> Mañana { get; set; } = new List<List<Volunteer>>();
        public List<List<Volunteer>> Tarde { get; set; } = new List<List<Volunteer>>();
    }
}