using ClassStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DataGenerator
    {
        public static List<Ticket> GenerateTickets()
        {
            var flights = GenerateFlights();
            return new List<Ticket>()
            {
                new Ticket()
                {
                    Flight = flights[0],
                    Price = 130,
                    BoardingPass = BoardingPass.ECONOMY
                },
                new Ticket()
                {
                    Flight = flights[0],
                    Price = 205,
                    BoardingPass = BoardingPass.STANDART
                },
                new Ticket()
                {
                    Flight = flights[0],
                    Price = 180,
                    BoardingPass = BoardingPass.BUSINESS
                },
                new Ticket()
                {
                    Flight = flights[1],
                    Price = 80,
                    BoardingPass = BoardingPass.ECONOMY
                },
                new Ticket()
                {
                    Flight = flights[2],
                    Price = 190,
                    BoardingPass = BoardingPass.STANDART
                },
                new Ticket()
                {
                    Flight = flights[3],
                    Price = 200,
                    BoardingPass = BoardingPass.BUSINESS
                },
                new Ticket()
                {
                    Flight = flights[4],
                    Price = 170,
                    BoardingPass = BoardingPass.ECONOMY
                },
                new Ticket()
                {
                    Flight = flights[5],
                    Price = 99,
                    BoardingPass = BoardingPass.STANDART
                },
                new Ticket()
                {
                    Flight = flights[6],
                    Price = 78,
                    BoardingPass = BoardingPass.BUSINESS
                },
                new Ticket()
                {
                    Flight = flights[7],
                    Price = 310,
                    BoardingPass = BoardingPass.ECONOMY
                },
                new Ticket()
                {
                    Flight = flights[8],
                    Price = 210,
                    BoardingPass = BoardingPass.STANDART
                },
                new Ticket()
                {
                    Flight = flights[9],
                    Price = 180,
                    BoardingPass = BoardingPass.BUSINESS
                },
                new Ticket()
                {
                    Flight = flights[2],
                    Price = 110,
                    BoardingPass = BoardingPass.ECONOMY
                },
                new Ticket()
                {
                    Flight = flights[1],
                    Price = 160,
                    BoardingPass = BoardingPass.STANDART
                },
                new Ticket()
                {
                    Flight = flights[4],
                    Price = 90,
                    BoardingPass = BoardingPass.BUSINESS
                }

            };
        }
        public static List<Flight> GenerateFlights()
        {
            var planes = GeneratePlanes();
            Random rnd = new Random();
            return new List<Flight>()
            {
                new Flight()
                {
                    Number = "DF2753",
                    Date = new DateTime(2021, 08, 25, 17, 35, 0),
                    StartTown = "New York",
                    DestinationTown = "London",
                    Plane = planes[rnd.Next(planes.Count)]
                },
                new Flight()
                {
                    Number = "LN3211",
                    Date = new DateTime(2021, 08, 28, 03, 50, 0),
                    StartTown = "Frankfurt",
                    DestinationTown = "Las Vegas",
                    Plane = planes[rnd.Next(planes.Count)]
                },
                new Flight()
                {
                    Number = "GT4638",
                    Date = new DateTime(2021, 09, 01, 11, 20, 0),
                    StartTown = "Toronto",
                    DestinationTown = "Bangkok",
                    Plane = planes[rnd.Next(planes.Count)],
                    IsDelayed = true,
                    DelayTime = new TimeSpan(3, 20, 0)
                },
                new Flight()
                {
                    Number = "KV3323",
                    Date = new DateTime(2021, 08, 23, 19, 10, 0),
                    StartTown = "London",
                    DestinationTown = "Glasgow",
                    Plane = planes[rnd.Next(planes.Count)]
                },
                new Flight()
                {
                    Number = "LV2317",
                    Date = new DateTime(2021, 08, 26, 11, 15, 0),
                    StartTown = "Washington",
                    DestinationTown = "Dallas",
                    Plane = planes[rnd.Next(planes.Count)]
                },
                new Flight()
                {
                    Number = "BD9032",
                    Date = new DateTime(2021, 08, 25, 1, 30, 0),
                    StartTown = "Sydney",
                    DestinationTown = "Berlin",
                    Plane = planes[rnd.Next(planes.Count)]
                },
                new Flight()
                {
                    Number = "FB5610",
                    Date = new DateTime(2021, 08, 27, 7, 40, 0),
                    StartTown = "Paris",
                    DestinationTown = "Kyiv",
                    Plane = planes[rnd.Next(planes.Count)],
                    IsDelayed = true,
                    DelayTime = new TimeSpan(5, 35, 0)
                },
                new Flight()
                {
                    Number = "EN4276",
                    Date = new DateTime(2021, 08, 22, 9, 10, 0),
                    StartTown = "Rome",
                    DestinationTown = "Vienna",
                    Plane = planes[rnd.Next(planes.Count)]
                },
                new Flight()
                {
                    Number = "GC5433",
                    Date = new DateTime(2021, 08, 24, 6, 05, 0),
                    StartTown = "Hong Kong",
                    DestinationTown = "Oslo",
                    Plane = planes[rnd.Next(planes.Count)]
                },
                new Flight()
                {
                    Number = "LY4488",
                    Date = new DateTime(2021, 08, 25, 19, 20, 0),
                    StartTown = "Tokyo",
                    DestinationTown = "Madrid",
                    Plane = planes[rnd.Next(planes.Count)],
                    IsDelayed = true,
                    DelayTime = new TimeSpan(2, 40, 0)
                }
            };
        }
        public static List<Plane> GeneratePlanes()
        {
            return new List<Plane>()
            {
                new Plane()
                {
                    Model = "Airbus A220",
                    PlacesCount = 160
                },
                new Plane()
                {
                    Model = "Airbus A320",
                    PlacesCount = 230
                },
                new Plane()
                {
                    Model = "Antonov An-148",
                    PlacesCount = 80
                },
                new Plane()
                {
                    Model = "Boeing 777",
                    PlacesCount = 368
                },
                new Plane()
                {
                    Model = "Comac ARJ21",
                    PlacesCount = 90
                },
                new Plane()
                {
                    Model = "Embraer E-Jet",
                    PlacesCount = 124
                },
                new Plane()
                {
                    Model = "Tupolev Tu-204 A220",
                    PlacesCount = 210
                },
                new Plane()
                {
                    Model = "Mitsubishi SpaceJet",
                    PlacesCount = 96
                },
                new Plane()
                {
                    Model = "Airbus A350",
                    PlacesCount = 285
                },
                new Plane()
                {
                    Model = "Boeing 747",
                    PlacesCount = 366
                },
            };

        }


    }
}
