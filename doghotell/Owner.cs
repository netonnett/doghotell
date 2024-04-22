using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotell
{
    internal class Owner
    {
        public string firtsname;
        public string lastname;
        public adress adress;

        public Owner(string firtsname, string lastname, adress adress)
        {
            this.firtsname = firtsname;
            this.lastname = lastname;
            this.adress = adress;
        }

        internal string Getadress()
        {
            string streetnamee = adress.streetname;
            string cityy = adress.city;
            string postcodee = adress.postcode;
            string infoadress = streetnamee + " " + cityy + " " + postcodee;
            return infoadress;
        }
    }
}
