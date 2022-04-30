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
                var dog2 = new Animal(AnimalTypeEnum.Dog, "Naye1", "Naye es una hembra de 6 años, mezcla de galso. Extremadamente cariñosa y amable con los niños.", 2, "1.jpg");
                var dog3 = new Animal(AnimalTypeEnum.Dog, "Naye2", "Naye es una hembra de 6 años, mezcla de galso. Extremadamente cariñosa y amable con los niños.", 2, "1.jpg");
                var dog4 = new Animal(AnimalTypeEnum.Dog, "Naye3", "Naye es una hembra de 6 años, mezcla de galso. Extremadamente cariñosa y amable con los niños.", 2, "1.jpg");
                var dog5 = new Animal(AnimalTypeEnum.Dog, "Naye4", "Naye es una hembra de 6 años, mezcla de galso. Extremadamente cariñosa y amable con los niños.", 2, "1.jpg");
                var dog6 = new Animal(AnimalTypeEnum.Dog, "Naye5", "Naye es una hembra de 6 años, mezcla de galso. Extremadamente cariñosa y amable con los niños.", 2, "1.jpg");

                context.AddRange(new[] { dog1, dog2, dog3, dog4, dog5, dog6 });


                var cat1 = new Animal(AnimalTypeEnum.Cat, "Cat1", "Naye es una hembra de 6 años, mezcla de galso. Extremadamente cariñosa y amable con los niños.", 2, "1.jpg");
                var cat2 = new Animal(AnimalTypeEnum.Cat, "Cat2", "Naye es una hembra de 6 años, mezcla de galso. Extremadamente cariñosa y amable con los niños.", 2, "1.jpg");
                var cat3 = new Animal(AnimalTypeEnum.Cat, "Cat3", "Naye es una hembra de 6 años, mezcla de galso. Extremadamente cariñosa y amable con los niños.", 2, "1.jpg");
                var cat4 = new Animal(AnimalTypeEnum.Cat, "Cat4", "Naye es una hembra de 6 años, mezcla de galso. Extremadamente cariñosa y amable con los niños.", 2, "1.jpg");

                context.AddRange(new[] { cat1, cat2, cat3, cat4 });

                context.SaveChanges();
            }
        }
    }
}
