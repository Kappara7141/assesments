using System;
namespace productnum
{
      public class Product
     { 
     public static void Main()
      {
            float a, b;
            double c;
            Console.WriteLine("Enter First Number");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = float.Parse(Console.ReadLine());
            c = (a * b);
            Console.WriteLine("product of {0} and {1} is {2}", a, b, c);
            Console.ReadKey();
       }
      }
}
