using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.BLL
{
    public class EnterDataService
    {
        public DateTime enterDate(string message)
        {
            DateTime date;
            string yearStr;
            do
            {
                Console.Write(message);
                yearStr = Console.ReadLine();
                if (!DateTime.TryParse(yearStr, out date))
                {
                    Console.WriteLine("Wrong date format!");
                }
                else return date;
            } while (true);
        }
    }
}
