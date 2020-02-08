using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mulfunction
{
    class Program
    {
        public static void mul(int a , int b)
        {
            int c = a * b;
            Console.WriteLine("multiplication of {0} and {1} is {2}", a, b, c);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = int.Parse(Console.ReadLine());
             mul(a, b);
            
            
        }
    }
}
