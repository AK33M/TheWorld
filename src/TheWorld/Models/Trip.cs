using System;
using System.Collections.Generic;

namespace TheWorld.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public string Username { get; set; }

        public ICollection<Stop> Stops { get; set; }
    }
}