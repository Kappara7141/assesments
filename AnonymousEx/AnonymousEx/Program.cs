using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousEx
{
    class Program
    {
        public delegate void Mydelg(string s);
        static void Main(string[] args)
        {
            /* Mydelg delgt = a => Console.WriteLine(a);
             delgt("helloo.......");
             Func<int, double, double> Calc = (x, y) => x * y;
             Console.WriteLine(Calc(12, 10.8));
            Func<int, int, double> triangle = (x, y) => 0.5 * x * y;
            Console.WriteLine(triangle(4, 5));*/
            Circle circle = new Circle();
            Console.WriteLine("Enter radius of the circle");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(circle.Calculate(r => 2 * Math.PI * p));
            Console.WriteLine();
            Console.WriteLine(circle.Calculate(r => Math.PI * p * p));
            Console.WriteLine(circle.Calculate(a => p * p * p));
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            Console.WriteLine(circle.Changecase(a => s.ToUpper()));
            string t = "IN UPPER CASE";
        }
    }
}
