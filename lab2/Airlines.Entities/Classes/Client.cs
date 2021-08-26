using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Entities.Classes
{
    public class Client
    {
        private List<Ticket> tickets;

        public List<Ticket> Tickets
        {
            get { return tickets; }
            set { tickets = value; }
        }

    }
}
