using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibCalculation;

namespace ConsoleApusingCalculateLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation cl = new Calculation();
            cl.No1 = 400;
            cl.No2 = 50;
           Console.WriteLine( cl.Add());
            Console.WriteLine(cl.Difference());
            Console.WriteLine(cl.Division());
            Console.WriteLine(cl.Multiply());
        }
    }
}
