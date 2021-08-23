using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStorage
{
    public class Flight
    {
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        private Plane plane;

        public Plane Plane
        {
            get { return plane; }
            set { plane = value; }
        }

        private string startTown;

        public string StartTown
        {
            get { return startTown; }
            set { startTown = value; }
        }

        private string destinationTown;

        public string DestinationTown
        {
            get { return destinationTown; }
            set { destinationTown = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private bool isDelayed;

        public bool IsDelayed
        {
            get { return isDelayed; }
            set { isDelayed = value; }
        }

        private string delayReason;

        public string DelayReason
        {
            get { return delayReason; }
            set { delayReason = value; }
        }

        private TimeSpan? delayTime;

        public TimeSpan? DelayTime
        {
            get { return delayTime; }
            set { delayTime = value; }
        }

        private DateTime closeTime => Date.Subtract(new TimeSpan(3, 0, 0));

        public DateTime CloseTime
        {
            get { return closeTime; }
        }



        public override string ToString()
        {
            return $"Flight no. {Number}\nFrom {StartTown} To {DestinationTown}\nAt {Date}";
        }

    }
}
