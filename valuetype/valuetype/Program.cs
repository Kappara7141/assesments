using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuetype
{
    class Program
    {
        public static void Showdata(int m , int n)
        {
            double sum = m + n;
            Console.WriteLine("sum={0}", sum);
            m += 5; n += 5;
        }
        static void Main(string[] args)
        {
            int a, b;
            a = 10; b = 20;
            Showdata(a, b);
            Console.ReadKey();
        }
    }
}
