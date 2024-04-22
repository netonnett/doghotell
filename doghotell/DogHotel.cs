using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doghotell
{
    internal class DogHotel
    {
         Dog[] dogArray = new Dog[10];
        

       

        public void SetDog(int cageNumber, Dog dog)
        {
            dogArray[cageNumber] = dog;
        }

        public Dog GetDog(int cageNumber)
        {
            return dogArray[cageNumber];
        }

        public void PrintInfo()
        {
            for(int i = 0; i < dogArray.Length; i++)
            {
                Dog dog = dogArray[i];
                if(dog != null)
                {
                    Console.WriteLine("\r\n" + "Bur " + i + ": innehåller hund: " + dog.name + "\r\n" + " owner:" + "\r\n" + dogArray[i].GetOwner());
                }
            }
        }

    }
}
