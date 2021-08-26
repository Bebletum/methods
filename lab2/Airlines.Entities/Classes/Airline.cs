using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Entities.Classes
{
    public class Airline
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<Airport> _airports;

        public List<Airport> Airports
        {
            get { return _airports; }
            set { _airports = value; }
        }


        public Airline()
        {
            _airports = new List<Airport>();
        }

        public List<Flight> GetAllFlights()
        {
            List<Flight> flights = new List<Flight>();
            foreach (var a in Airports)
            {
                foreach (var fl in a.Flights)
                {
                    flights.Add(fl);
                }
            }
            return flights;
        }

        public List<Flight> GetFlightsBetweenTownsByDate(string startTown, string destinationTown, DateTime startDate, DateTime endDate)
        {
            List<Flight> flights = new List<Flight>();
            foreach (var a in Airports)
            {
                foreach (var f in a.Flights)
                {
                    if(f.StartTown == startTown &&
                       f.DestinationTown == destinationTown &&
                       f.Date >= startDate &&
                       f.Date <= endDate)
                    {
                        flights.Add(f);
                    }
                }
            }
            return flights;
        }

        public List<Ticket> GetTicketsByFlightNumber(string number)
        {
            List<Ticket> tickets = new List<Ticket>();
            foreach (var a in Airports)
            {
                foreach (var t in a.Tickets)
                {
                    if (t.Flight.Number == number)
                        tickets.Add(t);
                }
            }
            return tickets;
        }
    }
}
