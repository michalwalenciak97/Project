using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Stop
    {
        public string Place_Start { get; set; }
        public string Place_End { get; set; }
        public string Time_arrival { get; set; }
        public string Time_departure { get; set; }
        public DateTime Date { get; set; }
        public int Platform { get; set; }
        public int Track { get; set; }
        public int Train { get; set; }

        public Stop(string nplace_start, string nplace_end, string ntime_arrival, string ntime_departure, DateTime ndate, int nplatform, int ntrack, int ntrain)
        {
            Place_Start = nplace_start;
            Place_End = nplace_end;
            Time_arrival = ntime_arrival;
            Time_departure = ntime_departure;
            Date = ndate;
            Platform = nplatform;
            Track = ntrack;
            Train = ntrain;
        }
        public Stop(string nplace_start, string ntime_arrival, string ntime_departure, DateTime ndate, int nplatform, int ntrack, int ntrain)
        {
            Place_Start = nplace_start;
            Place_End = null;
            Time_arrival = ntime_arrival;
            Time_departure = ntime_departure;
            Date = ndate;
            Platform = nplatform;
            Track = ntrack;
            Train = ntrain;
        }
    }
}
