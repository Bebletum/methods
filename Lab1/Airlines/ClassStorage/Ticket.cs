using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStorage
{
    public class Ticket
    {
        private Flight flight;

        public Flight Flight
        {
            get { return flight; }
            set { flight = value; }
        }

        private double price;

        public double Price
        {
            get 
            {
                return price; 
            }
            set 
            { 
                price = value;
                switch (boardingPass)
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
            }
        }

        private BoardingPass boardingPass;

        public BoardingPass BoardingPass
        {
            get { return boardingPass; }
            set { boardingPass = value; }
        }

    }
}
