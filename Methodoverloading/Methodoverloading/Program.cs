using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading
{
    class Overloading
    {
        public string area(int side)
        {
            int ar = side * side;
            return string.Format("square Area={0}", ar);
        }
        public string area(int l, int b)
        {
            int ar = l * b;
            return string.Format("Rectangle area={0}", ar);
        }
        public string area(double r)
        {
            double ar = Math.PI * r * r;
            return string.Format("Area of circle={0}", ar);
        }
        public string area(double b, int h)
        {
            double ar = 0.5 * b * h;
            return string.Format("Triangle area is {0}", ar);
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            // MethodOverload();
            program p = new program();
            p.Nonstaticmethod();
        }
        public void Nonstaticmethod()
        {
            Console.WriteLine("It is a nonstatic method ");
        }
        private static void MethodOverload()
        {
            Overloading o = new Overloading();
            o.area(12);
            Console.WriteLine(o.area(12));
            Console.WriteLine(o.area(10, 20));
            Console.WriteLine(o.area(15.7));
            Console.WriteLine(o.area(10.6, 9));
        }
    }
}        
