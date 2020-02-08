using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Delegates
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);
        public delegate void square(int side, int s);

        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        // method "subtract" 
        public void subtract(int a, int b)
        {
            Console.WriteLine("(100 - 60) = {0}", a - b);
        }
        public void area(int side,int s)
        {
            Console.WriteLine("Area is={0}", (side * s));
        }
        public void perimeter(int side,int s)
        {
            Console.WriteLine("perimeter={0}", 4 * (side + s));
        }

        // Main Method 
        public static void Main(String[] args)
        {

            // creating object "obj" of class "Geeks" 
            Delegates obj = new Delegates();
            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);
            square del_obj3 = new square(obj.area);
            del_obj1(100, 40);
            del_obj2(100, 60);
           del_obj3 += obj.perimeter;
            del_obj3.Invoke(3, 4);
            Console.WriteLine();
            Console.ReadKey();
            

        }
    }
}


