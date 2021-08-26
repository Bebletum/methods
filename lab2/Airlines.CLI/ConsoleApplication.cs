using Airlines.BLL;
using Airlines.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Airlines.CLI
{
    class ConsoleApplication
    {
        private EnterDataService _enterDataService;
        private ShowDataService _showDataService;

        private List<Airline> _airlines;

        private const string menu = "[1] - View all flights" +
                    "\n[2] - View delayed flights" +
                    "\n[3] - Find flights between towns by date" +
                    "\n[4] - Find flights by close date" +
                    "\n[5] - Get delay time by flight" +
                    "\n[6] - View price by flight" +
                    "\n[0] - Exit";

        private Airline _currentAirlines = null;

        private List<Flight> _allFlights = null;

        public ConsoleApplication()
        {
            _airlines = new AirlinesService().GetAirlines();

            _enterDataService = new EnterDataService();
            _showDataService = new ShowDataService();
        }

        private void selectCurrentAirlines()
        {
            Console.WriteLine("\t - Choose airlines below -");
            for (int i = 0; i < _airlines.Count; i++)
            {
                Console.WriteLine($"[{i}] - " + _airlines[i].Name);
            }
            int index = 0;
            do
            {
                Console.Write("Enter a number: ");
                string numberStr = Console.ReadLine();
                if (int.TryParse(numberStr, out index))
                    if (index >= 0 && index < _airlines.Count)
                        break;
                Console.WriteLine("Wrong format!");
            } while (true);

            _currentAirlines = _airlines.ElementAt(index);
            _allFlights = _currentAirlines.GetAllFlights();
            Console.Clear();
            Console.WriteLine("\t\tWelcome to " + _currentAirlines.Name + " airlines!");
            Thread.Sleep(1000);
            Console.Clear();
        }

        public void execute()
        {
            selectCurrentAirlines();
            string selector;
            do
            {
                Console.WriteLine(menu);
                Console.Write("Enter your choise: ");
                selector = Console.ReadLine();
                Console.Clear();

                switch (selector)
                {
                    case "1":
                        _showDataService.showAllFlights(_allFlights);
                        break;
                    case "2":
                       
                        var flights = new List<Flight>();
                        foreach (var fl in _allFlights)
                        {
                            if (fl.IsDelayed)
                                flights.Add(fl);
                        }
                        _showDataService.showAllFlights(flights);
                        break;
                    case "3":
                        showFlightsBetweenTownsByDate();
                        break;
                    case "4":
                        showFlightsByCloseDate();
                        break;
                    case "5":
                        showDelayTimeByFlight();
                        break;
                    case "6":
                        showPricesByFlight();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Wrong choise!");
                        break;
                }
            } while (true);
        }

        private void showFlightsByCloseDate()
        {
            var date = _enterDataService.enterDate("Enter close date: ");
           
            var flights = new List<Flight>();

            foreach (Flight fl in _allFlights)
            {
                if (fl.CloseTime <= date)
                    flights.Add(fl);
            }
            _showDataService.showAllFlights(flights);
        }

        private void showFlightsBetweenTownsByDate()
        {
            Console.Write("Enter start town: ");
            string startTown = Console.ReadLine();
            Console.Write("Enter destination town: ");
            string destinationTown = Console.ReadLine();
            var startDate = _enterDataService.enterDate("Enter start date: ");
            var endDate = _enterDataService.enterDate("Enter end date: ");
            _showDataService.showAllFlights(_currentAirlines.GetFlightsBetweenTownsByDate(startTown, destinationTown, startDate, endDate));
        }

        private void showPricesByFlight()
        {
            Console.Write("Enter flight number: ");
            string num = Console.ReadLine();
            var foundTickets = _currentAirlines.GetTicketsByFlightNumber(num);
            if (foundTickets.Count() == 0)
            {
                Console.WriteLine($"There no tickets are available for {num} flight");
                return;
            }
            var line = new string('-', 27);
            Console.WriteLine($"There {foundTickets.Count()} tickets are available for {num} flight");
            Console.WriteLine(line);
            Console.WriteLine($"    {"Boarding Pass",-15}{"Price",-7}");
            Console.WriteLine(line);
            foreach (var t in foundTickets)
            {
                Console.WriteLine($"    {t.BoardingPass,-15}{t.Price,-7}");
                Console.WriteLine(line);
            }
        }

        private void showDelayTimeByFlight()
        {
            Console.Write("Enter flight number: ");
            string num = Console.ReadLine();
            
            Flight fl = null;
            foreach (var f in _allFlights)
            {
                if (f.IsDelayed && f.Number == num)
                {
                    fl = f;
                    break;
                }
            }
            if (fl == null)
            {
                Console.WriteLine($"Flight {num} wasn`t found or wasn`t delayed");
                return;
            }
            Console.WriteLine("Flight #" + num + " was delayed from " + fl.Date + " to " + fl.Date.Add(fl.Delay.DelayTime));
        }


       
    }
}
