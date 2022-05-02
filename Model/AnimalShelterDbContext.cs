using Microsoft.EntityFrameworkCore;

namespace ProyectoTFG.Model
{
    public class AnimalShelterDbContext : DbContext
    {
        public static User? CurrentUser;

        public DbSet<User> Users => Set<User>();
        public DbSet<Animal> Animals => Set<Animal>();

        public AnimalShelterDbContext(DbContextOptions<AnimalShelterDbContext> options) : base(options)
        {
        }

        public static void SeedDbContext(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();

            using var context = scope.ServiceProvider.GetRequiredService<AnimalShelterDbContext>();

            if (context.Database.EnsureCreated())
            {
                // Usuarios
                var admin = new User("Admin", "admin@happydog.com", Roles.Admin);
                var volunteer = new User("Borja", "borja@happydog.com", Roles.Volunteer);
                var client = new User("Andrea", "andrea@gmail.com");

                context.AddRange(new[] { admin, volunteer, client });

                // Animales
                var dog1 = new Animal(AnimalTypeEnum.Dog, "Naye", "Naye es una hembra de 6 años, mezcla de galso. Extremadamente cariñosa y amable con los niños.", 2, "1.jpg");
                var dog2 = new Animal(AnimalTypeEnum.Dog, "Zeta", "El perro de más bondad que tenemos. Macho de 8 años, ideal para tener en una casa con espacio.", 2 , "2.jpg");
                var dog3 = new Animal(AnimalTypeEnum.Dog, "Cuna", "Precioso macho de pastor alemán. Un perro con 3 años ideal para salir a hacer deporte con el.", 6, "adopcion1.jpg");
                var dog4 = new Animal(AnimalTypeEnum.Dog, "Kirian", "Hembra super juguetona de 4 años. Super cariñosa sobre todo con los más pequeños de la familia.", 2, "adopcion2.jpg");
                var dog5 = new Animal(AnimalTypeEnum.Dog, "Sito", "Sito es un galgo joven, de apenas 2 años y con todas las ganas del mundo de tener una familia.", 2, "3.jpg");
                var dog6 = new Animal(AnimalTypeEnum.Dog, "Kiran", "Preciosa hembra de 4 años de Bull Terrier siempre dispuesta para el juego.", 4, "5.jpg");

                context.AddRange(new[] { dog1, dog2, dog3, dog4, dog5, dog6 });


                var cat1 = new Animal(AnimalTypeEnum.Cat, "Apolo", "Apolo llegó a nuestra protectora hace ahora 2 meses. Este macho llegó lleno de heridas y con una fractura en una de sus patas, pero se ha recompuesto y busca una familia que le de el cariño que merece.", 2, "gato6.jpg");
                var cat2 = new Animal(AnimalTypeEnum.Cat, "Disha", "Esta preciosa gatita de 8 meses nos la encontramos en un parque y no paró de seguirnos hasta venirse con nosotros.", 2, "gato4.jpg");
                var cat3 = new Animal(AnimalTypeEnum.Cat, "Rayo", "Un año tiene Rayo y es un gato macho super cariñoso que se puede tirar jugando con las moscas horas y horas.", 2, "gato1.jpg");
                var cat4 = new Animal(AnimalTypeEnum.Cat, "Israel", "Más que un gato tiene caracter de perro, siempre encima de las personas", 2, "gato3.jpg");

                context.AddRange(new[] { cat1, cat2, cat3, cat4 });

                context.SaveChanges();
            }
        }
    }
}
