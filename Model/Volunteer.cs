namespace ProyectoTFG.Model
{
    public class Volunteer
    {
        public int Id { get; set; }
        public VolunteerTypeEnum Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Volunteer(VolunteerTypeEnum type, string name, string description )
        {
            Type = type;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"Id:{Id} - Tipo:{Type} Nombre:{Name}";
        }
    }
}