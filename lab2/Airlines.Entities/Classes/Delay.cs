using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airlines.Entities.Classes
{
    public class Delay
    {
        private string delayReason;

        public string DelayReason
        {
            get { return delayReason; }
            set { delayReason = value; }
        }

        private TimeSpan delayTime;

        public TimeSpan DelayTime
        {
            get { return delayTime; }
            set { delayTime = value; }
        }
    }
}
