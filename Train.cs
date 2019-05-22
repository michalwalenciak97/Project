using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Train
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Numer { get; set; }

        public Train(string nname, string ntype, int nnumer)
        {
            Name = nname;
            Type = ntype;
            Numer = nnumer;
        }
    }
}
