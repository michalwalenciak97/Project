using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Table
    {
        public string Place_start { get; set; }
        public string Place_end { get; set; }
        public string Time_arrival { get; set; }
        public string Time_departure { get; set; }
        public string Name { get; set; }
        public int Platform { get; set; }
        public int Track { get; set; }
        public int Train { get; set; }

        public Table(string nplace_start, string nplace_end, string ntime_arrival, string ntime_departure, string nname, int nplatform, int ntrack, int ntrain)
        {
            Place_start = nplace_start;
            Place_end = nplace_end;
            Time_arrival = ntime_arrival;
            Time_departure = ntime_departure;
            Name = nname;
            Platform = nplatform;
            Track = ntrack;
            Train = ntrain;
        }
    }
}
