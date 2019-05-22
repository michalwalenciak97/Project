using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Ride
    {
        public string Starting_Place { get; set; }
        public string Destination { get; set; }
        public string Time_start { get; set; }
        public string Time_end { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Platform { get; set; }
        public int Track { get; set; }
        public int Numer { get; set; }

        public Ride(string nstarting_place, string ndestination, string ntime_start,
            string ntime_end, string nname, string ntype, int nplatform, int ntrack, int nnumer)
        {
            Starting_Place = nstarting_place;
            Destination = ndestination;
            Time_start = ntime_start;
            Time_end = ntime_end;
            Name = nname;
            Type = ntype;
            Platform = nplatform;
            Track = ntrack;
            Numer = nnumer;
        }
    }
}
