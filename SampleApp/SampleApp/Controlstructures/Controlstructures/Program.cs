using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlstructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());
            if(n<10)
            {
                Console.WriteLine("Good mrng..!");
            }
            else
            {
                Console.WriteLine("GoodNight..!");
            }
            Console.WriteLine("Enter a number:");
            int c = 10;
            c = int.Parse(Console.ReadLine());
            switch(c)
            {
                case 1:Console.WriteLine("It is 10"); break;
                case 2:Console.WriteLine("It is 5"); break;
                default:Console.WriteLine("it is not 10 not 5"); break;
            }
            Console.WriteLine("For statement number:");
            int m;
            m= int.Parse(Console.ReadLine());
            for(int i=1;i<=m;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("while statement number:");
            int j;
            j = int.Parse(Console.ReadLine());
            while(j<=10)
            {
                Console.WriteLine(j);
                j++;
            }
        }
    }
}
