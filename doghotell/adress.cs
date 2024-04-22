using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotell
{
    internal class adress
    {
        public string streetname;
        public string city;
        public string postcode;

        public adress(string sn, string city, string pc)
        {
            streetname = sn;
            this.city = city;
            postcode = pc;
        }
    }
}
