namespace TheWorld.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string namespace { get; set; }
        public DateTime DateCreated { get; set; }
        public string Username { get; set; }

        public ICollection<Stop> Stops { get; set; }
    }
}