using Airlines.Entities;
using Airlines.Entities.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Entities.Classes
{
    public class Ticket
    {
        private Flight flight;

        public Flight Flight
        {
            get { return flight; }
            set { flight = value; }
        }

        private decimal price;

        public decimal Price
        {
            get 
            {
                return price; 
            }
            set 
            {
                price = value;
                switch (BoardingPass)
                {
                    case BoardingPass.ECONOMY:
                        price += ((short)BoardingPass.ECONOMY);
                        break;
                    case BoardingPass.STANDART:
                        price += ((short)BoardingPass.STANDART);
                        break;
                    case BoardingPass.BUSINESS:
                        price += ((short)BoardingPass.BUSINESS);
                        break;
                }
                switch (PriceCoeff)
                {
                    case AirlinesPriceCoeffs.MAU_AIRLINES:
                        price *= (short)AirlinesPriceCoeffs.MAU_AIRLINES;
                        break;
                    case AirlinesPriceCoeffs.BRITISH_AIRLINES:
                        price *= (short)AirlinesPriceCoeffs.BRITISH_AIRLINES;
                        break;
                }
            }
        }

        private BoardingPass boardingPass;

        public BoardingPass BoardingPass
        {
            get { return boardingPass; }
            set { boardingPass = value; }
        }

        private AirlinesPriceCoeffs priceCoeff;

        public AirlinesPriceCoeffs PriceCoeff
        {
            get { return priceCoeff; }
            set { priceCoeff = value; }
        }


    }
}
