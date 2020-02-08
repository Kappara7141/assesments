using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    interface lairborne
    {
        void fly();
    }
    class Helicopter : lairborne
    {
       public void fly()
        {
            Console.WriteLine("Helicopter is flying");
        }
    }
    class Aeroplane : lairborne
    {
        public void fly()
        {
            Console.WriteLine("Aeroplane is flying");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Helicopter h = new Helicopter();
            Aeroplane a = new Aeroplane();
            h.fly();
            a.fly();
        }
    } 
}
