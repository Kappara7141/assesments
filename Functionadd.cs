using System;
   namespace Addfunction
   {
    class Program
    {
        public static void add(int a , int b)
        {
            int c = a + b;
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);
        }
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            add(a, b);
        }
    }
}

