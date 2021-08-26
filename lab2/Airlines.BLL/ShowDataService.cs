using Airlines.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.BLL
{
    public class ShowDataService
    {
        public void showAllFlights(IEnumerable<Flight> flights)
        {
            if (flights.Count() == 0)
            {
                Console.WriteLine("There are 0 flights are available");
                return;
            }
            string line = new string('-', 77);
            const short DATE_LENGTH = 23;
            const short TOWN_LENGTH = 15;
            const short REMARKS_LENGTH = 7;
            const short FLIGHT_LENGTH = 12;
            Console.WriteLine($" {"Date",-DATE_LENGTH}{"From",-TOWN_LENGTH}{"To",-TOWN_LENGTH}{"Flight no.",-FLIGHT_LENGTH}  {"Remarks",-REMARKS_LENGTH}");
            Console.WriteLine(line);
            foreach (var fl in flights)
            {
                Console.WriteLine($" {fl.Date,-DATE_LENGTH}{fl.StartTown,-TOWN_LENGTH}{fl.DestinationTown,-TOWN_LENGTH}  {fl.Number,-FLIGHT_LENGTH}{(fl.IsDelayed ? "DELAYED" : "ON TIME"),-REMARKS_LENGTH}");
                Console.WriteLine(line);
            }
        }

    }
}
