using System;

namespace DelegateRectangle
{
    class Program
    {
        public delegate double delmethod(double x, double y);
        public double calrectarea(double x,double y)
        {
            return x * y;
        }
        public double caltriarea(double x,double y)
        {
            double z= 0.5 * x * y;
            return z;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            delmethod d = new delmethod(p.calrectarea);
            Console.WriteLine("Area of rectangle is {0}",d(20,30));
            delmethod d1 = new delmethod(p.caltriarea);
            Console.WriteLine("Area of triangle is {0}", d1(10, 20));
            Console.ReadLine();
        }
    }
}
