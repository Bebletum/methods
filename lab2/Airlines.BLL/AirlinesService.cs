using Airlines.DAL;
using Airlines.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.BLL
{
    public class AirlinesService
    {
        public List<Airline> GetAirlines()
        {
            return new DataGenerator().GenerateAirlines();
        }
    }
}
