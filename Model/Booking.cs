namespace ProyectoTFG.Model
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }
        public User Client { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }

    }
}
