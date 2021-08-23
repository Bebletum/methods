using ClassStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Airlines
{
    class Program
    {
        static void Main(string[] args)
        {
            var flights = DataGenerator.GenerateFlights();
            var tickets = DataGenerator.GenerateTickets();
            string selector;
            do
            {
                Console.WriteLine("[1] - View all flights" +
                    "\n[2] - View delayed flights" +
                    "\n[3] - Find flights between towns by date" +
                    "\n[4] - Find flights by close date" +
                    "\n[5] - Get delay time by flight" +
                    "\n[6] - View price by flight" + 
                    "\n[0] - Exit");
                Console.Write("Enter your choise: ");
                selector = Console.ReadLine();
                Console.Clear();
                switch (selector)
                {
                    case "1":
                        showAllFlights(flights);
                        break;
                    case "2":
                        showAllFlights(flights.Where(f => f.IsDelayed));
                        break;
                    case "3":
                        {
                            Console.Write("Enter start town: ");
                            string startTown = Console.ReadLine();
                            Console.Write("Enter destination town: ");
                            string destinationTown = Console.ReadLine();
                            var date = enterDate();
                            showAllFlights(flights.Where(f => f.StartTown == startTown && f.DestinationTown == destinationTown && f.Date == date));
                            break;
                        }
                    case "4":
                        {
                            var date = enterDate();
                            showAllFlights(flights.Where(f => f.CloseTime <= date));
                            break;
                        }
                    case "5":
                        {
                            Console.Write("Enter flight number: ");
                            string num = Console.ReadLine();
                            var fl = flights.FirstOrDefault(f => f.IsDelayed && f.Number == num);
                            if(fl == null)
                            {
                                Console.WriteLine($"Flight {num} wasn`t found or wasn`t delayed");
                                break;
                            }
                            Console.WriteLine("Flight #" + num + " was delayed from " + fl.Date + " to " + fl.Date.Add((TimeSpan)fl.DelayTime));
                            break;
                        }
                    case "6":
                        {
                            Console.Write("Enter flight number: ");
                            string num = Console.ReadLine();
                            var foundTickets = tickets.Where(t => t.Flight.Number == num);
                            if(foundTickets.Count() == 0)
                            {
                                Console.WriteLine($"There no tickets are available for {num} flight");
                                break;
                            }
                            var line = new string('-', 27);
                            Console.WriteLine($"There {foundTickets.Count()} tickets are available for {num} flight");
                            Console.WriteLine(line);
                            Console.WriteLine($"    {"Boarding Pass", -15}{"Price", -7}");
                            Console.WriteLine(line);
                            foreach (var t in foundTickets)
                            {
                                Console.WriteLine($"    {t.BoardingPass, -15}{t.Price, -7}");
                                Console.WriteLine(line);
                            }
                            break;
                        }
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Wrong choise!");
                        break;
                }
            } while (true);
        }
        static DateTime enterDate()
        {
            DateTime date;
            string yearStr;
            do
            {
                Console.Write("Enter date: ");
                yearStr = Console.ReadLine();
                if (!DateTime.TryParse(yearStr, out date))
                {
                    Console.WriteLine("Wrong date format!");
                }
                else return date;
            } while (true);
        }
        static void showAllFlights(IEnumerable<Flight> flights)
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
            Console.WriteLine($" {"Date",-DATE_LENGTH}{"From",-TOWN_LENGTH}{"To",-TOWN_LENGTH}{"Flight no.", -FLIGHT_LENGTH}  {"Remarks",-REMARKS_LENGTH}");
            Console.WriteLine(line);
            foreach (var fl in flights)
            {
                Console.WriteLine($" {fl.Date,-DATE_LENGTH}{fl.StartTown,-TOWN_LENGTH}{fl.DestinationTown,-TOWN_LENGTH}  {fl.Number, -FLIGHT_LENGTH}{(fl.IsDelayed ? "DELAYED" : "ON TIME"),-REMARKS_LENGTH}");
                Console.WriteLine(line);
            }
        }
    }
}
