using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStorage
{
    public class Plane
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        private int placesCount;

        public int PlacesCount
        {
            get { return placesCount; }
            set { placesCount = value; }
        }

        private List<Flight> flights;

        public List<Flight> Flights
        {
            get { return flights; }
            set { flights = value; }
        }


    }
}
