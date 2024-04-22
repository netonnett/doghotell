using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotell
{
    internal class Dog
    {
        public Owner owner;
        public string name;
        public string chipNumber;
       

        public Dog(string name, string chipNumber, Owner owner)
        {
            this.name = name;
            this.chipNumber = chipNumber;
            this.owner = owner;
        }

        internal string Name()
        {

            string fullinfo = name + chipNumber + owner; 
            return fullinfo;
        }

        internal string GetOwner()
        {
            string firstnamee = owner.firtsname;
            string lastnamee = owner.lastname;
            string adress = owner.Getadress();
            string info = firstnamee + lastnamee + adress;
            return info;
        }
    }
}
