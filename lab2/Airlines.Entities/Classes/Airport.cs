using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Entities.Classes
{
    public class Airport
    {
        public string Name { get; set; }

        public ICollection<Plane> Planes { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

        public Airport()
        {
            Planes = new List<Plane>();
            Flights = new List<Flight>();
            Tickets = new List<Ticket>();
        }
    }
}
