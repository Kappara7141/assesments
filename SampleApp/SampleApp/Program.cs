using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ename;
            Console.WriteLine("Enter your name");
            ename = Console.ReadLine();
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("congratulations Mr/Ms {0} on your {1} birthday", ename, age);
            Console.ReadKey();
        }
    }
}
