namespace ProyectoTFG.Model
{
    public class Animal
    {
        public int Id { get; set; }
        public AnimalTypeEnum Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }

        public Animal(AnimalTypeEnum type, string name, string description, int age, string image)
        {
            Type = type;
            Name = name;
            Description = description;
            Age = age;
            Image = image;
        }

        public override string ToString()
        {
            return $"Id:{Id} - Tipo:{Type} Nombre:{Name}";
        }
    }
}
