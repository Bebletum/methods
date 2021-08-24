using Airlines.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines
{
    class DataGenerator
    {
        public List<Airline> GenerateAirlines()
        {
            return new List<Airline>()
            {
                new Airline()
                {
                    Name = "MAU",
                    Airports = GenerateFirstAirlineAirports()
                },
                new Airline()
                {
                    Name = "British airlines",
                    Airports = GenerateSecondAirlineAirports()

                }
            };
        }

        private List<Plane> GetFirstAirlinePlanes()
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
                    Model = "Boeing 777",
                    PlacesCount = 368
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
                }
            };
        }

        private Plane GenerateFirstAirlinesPlane()
        {
            var planes = GetFirstAirlinePlanes();
            return planes[new Random().Next(planes.Count)];
        }

        private List<Plane> GetSecondAirlinePlanes()
        {
            return new List<Plane>()
            {
                new Plane()
                {
                    Model = "Antonov An-148",
                    PlacesCount = 80
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
                }
            };
        }

        private Plane GenerateSecondAirlinesPlane()
        {
            var planes = GetSecondAirlinePlanes();
            return planes[new Random().Next(planes.Count)];
        }

        private List<Flight> GetFirstAirlineFlights()
        {
            return new List<Flight>()
            {
                new Flight()
                {
                    Number = "GC5433",
                    Date = new DateTime(2021, 08, 25, 6, 05, 0),
                    StartTown = "Hong Kong",
                    DestinationTown = "Oslo",
                    Plane = GenerateFirstAirlinesPlane()
                },
                new Flight()
                {
                    Number = "BD9032",
                    Date = new DateTime(2021, 08, 25, 1, 30, 0),
                    StartTown = "Sydney",
                    DestinationTown = "Berlin",
                    Plane = GenerateFirstAirlinesPlane()
                },
                new Flight()
                {
                    Number = "FB5610",
                    Date = new DateTime(2021, 08, 27, 7, 40, 0),
                    StartTown = "Paris",
                    DestinationTown = "Kyiv",
                    Plane = GenerateFirstAirlinesPlane(),
                    Delay = GenerateRandomDelay()
                },
                new Flight()
                {
                    Number = "EN4276",
                    Date = new DateTime(2021, 08, 22, 9, 10, 0),
                    StartTown = "Rome",
                    DestinationTown = "Vienna",
                    Plane = GenerateFirstAirlinesPlane()
                },
                new Flight()
                {
                    Number = "LY4488",
                    Date = new DateTime(2021, 08, 25, 19, 20, 0),
                    StartTown = "Tokyo",
                    DestinationTown = "Madrid",
                    Plane = GenerateFirstAirlinesPlane(),
                    Delay = GenerateRandomDelay()
                }
            };

        }
        private List<Flight> GetSecondAirlineFlights()
        {
            return new List<Flight>()
            {
                new Flight()
                {
                    Number = "DF2753",
                    Date = new DateTime(2021, 08, 25, 17, 35, 0),
                    StartTown = "New York",
                    DestinationTown = "London",
                    Plane = GenerateSecondAirlinesPlane()
                },
                new Flight()
                {
                    Number = "LN3211",
                    Date = new DateTime(2021, 08, 28, 03, 50, 0),
                    StartTown = "Frankfurt",
                    DestinationTown = "Las Vegas",
                    Plane = GenerateSecondAirlinesPlane()
                },
                new Flight()
                {
                    Number = "GT4638",
                    Date = new DateTime(2021, 09, 01, 11, 20, 0),
                    StartTown = "Toronto",
                    DestinationTown = "Bangkok",
                    Plane = GenerateSecondAirlinesPlane(),
                    Delay = GenerateRandomDelay()
                },
                new Flight()
                {
                    Number = "KV3323",
                    Date = new DateTime(2021, 08, 23, 19, 10, 0),
                    StartTown = "London",
                    DestinationTown = "Glasgow",
                    Plane = GenerateSecondAirlinesPlane()
                },
                new Flight()
                {
                    Number = "LV2317",
                    Date = new DateTime(2021, 08, 26, 11, 15, 0),
                    StartTown = "Washington",
                    DestinationTown = "Dallas",
                    Plane = GenerateSecondAirlinesPlane(),
                    Delay = GenerateRandomDelay()
                },
            };
        }

        private Delay GenerateRandomDelay()
        {
            var allDelays = new List<Delay>()
            {
                new Delay()
                {
                    DelayReason = "Visibility",
                    DelayTime = new TimeSpan(5, 30, 0)
                },
                new Delay()
                {
                    DelayReason = "Unsafe Weather Conditions",
                    DelayTime = new TimeSpan(2, 45, 0)
                },
                new Delay()
                {
                    DelayReason = "Mechanical Trouble",
                    DelayTime = new TimeSpan(15, 50, 0)
                },
                new Delay()
                {
                    DelayReason = "Windshield Damage",
                    DelayTime = new TimeSpan(13, 20, 0)
                },
                new Delay()
                {
                    DelayReason = "Waiting On Cargo",
                    DelayTime = new TimeSpan(0, 50, 0)
                },
                new Delay()
                {
                    DelayReason = "Covid-19",
                    DelayTime = new TimeSpan(8, 10, 0)
                }
            };
            return allDelays[new Random().Next(allDelays.Count)];
        }

        private List<Ticket> GetFirstAirlineTickets()
        {
            var flights = GetFirstAirlineFlights();
            return new List<Ticket>()
            {
                new Ticket()
                {
                    Flight = flights[0],
                    Price = 130,
                    BoardingPass = BoardingPass.ECONOMY,
                    PriceCoeff = AirlinesPriceCoeffs.MAU_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[1],
                    Price = 205,
                    BoardingPass = BoardingPass.STANDART,
                    PriceCoeff = AirlinesPriceCoeffs.MAU_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[2],
                    Price = 180,
                    BoardingPass = BoardingPass.BUSINESS,
                    PriceCoeff = AirlinesPriceCoeffs.MAU_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[2],
                    Price = 80,
                    BoardingPass = BoardingPass.ECONOMY,
                    PriceCoeff = AirlinesPriceCoeffs.MAU_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[3],
                    Price = 120,
                    BoardingPass = BoardingPass.BUSINESS,
                    PriceCoeff = AirlinesPriceCoeffs.MAU_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[4],
                    Price = 90,
                    BoardingPass = BoardingPass.STANDART,
                    PriceCoeff = AirlinesPriceCoeffs.MAU_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[4],
                    Price = 190,
                    BoardingPass = BoardingPass.STANDART,
                    PriceCoeff = AirlinesPriceCoeffs.MAU_AIRLINES
                }
                };
        }

        private List<Ticket> GetSecondAirlineTickets()
        {
            var flights = GetSecondAirlineFlights();
            return new List<Ticket>()
            {
                 new Ticket()
                {
                    Flight = flights[3],
                    Price = 200,
                    BoardingPass = BoardingPass.BUSINESS,
                    PriceCoeff = AirlinesPriceCoeffs.BRITISH_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[4],
                    Price = 170,
                    BoardingPass = BoardingPass.ECONOMY,
                    PriceCoeff = AirlinesPriceCoeffs.BRITISH_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[1],
                    Price = 99,
                    BoardingPass = BoardingPass.STANDART,
                    PriceCoeff = AirlinesPriceCoeffs.BRITISH_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[0],
                    Price = 78,
                    BoardingPass = BoardingPass.BUSINESS,
                    PriceCoeff = AirlinesPriceCoeffs.BRITISH_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[0],
                    Price = 310,
                    BoardingPass = BoardingPass.ECONOMY,
                    PriceCoeff = AirlinesPriceCoeffs.BRITISH_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[0],
                    Price = 210,
                    BoardingPass = BoardingPass.STANDART,
                    PriceCoeff = AirlinesPriceCoeffs.BRITISH_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[1],
                    Price = 180,
                    BoardingPass = BoardingPass.BUSINESS,
                    PriceCoeff = AirlinesPriceCoeffs.BRITISH_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[2],
                    Price = 110,
                    BoardingPass = BoardingPass.ECONOMY,
                    PriceCoeff = AirlinesPriceCoeffs.BRITISH_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[1],
                    Price = 160,
                    BoardingPass = BoardingPass.STANDART,
                    PriceCoeff = AirlinesPriceCoeffs.BRITISH_AIRLINES
                },
                new Ticket()
                {
                    Flight = flights[4],
                    Price = 90,
                    BoardingPass = BoardingPass.BUSINESS,
                    PriceCoeff = AirlinesPriceCoeffs.BRITISH_AIRLINES
                }
            };
        }



        private List<Airport> GenerateFirstAirlineAirports()
        {
            return new List<Airport>()
            {
                new Airport()
                {
                    Flights = GetFirstAirlineFlights(),
                    Name = "Boryspil airport",
                    Planes = GetFirstAirlinePlanes(),
                    Tickets = GetFirstAirlineTickets()
                }
            };
        }
        private List<Airport> GenerateSecondAirlineAirports()
        {
            return new List<Airport>()
            {
                new Airport()
                {
                    Flights = GetSecondAirlineFlights(),
                    Name = "British airport",
                    Planes = GetSecondAirlinePlanes(),
                    Tickets = GetSecondAirlineTickets()
                }
            };
        }

    }
}
