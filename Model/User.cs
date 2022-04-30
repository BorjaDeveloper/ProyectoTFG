namespace ProyectoTFG.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Rol { get; set; }

        public User(string name, string email, string? rol = null)
        {
            Name = name;
            Email = email;
            Rol = rol;
        }
    }
}
