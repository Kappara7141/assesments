using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        int a, b;

        public Calculate(int m, int n)
        {
            a = m;
            b = n;
        }
        public int add()
        {
            Console.WriteLine("addition of a:{0} and b:{1}:",a, b);
            return a + b;
        }
        public int sub()
        {
            Console.WriteLine("subtraction of a:{0} and b:{1}:",a, b);
            return a - b;
        }
        public int mul()
        {
            Console.WriteLine("Multiplication of a{0} and b:{1}:", a, b);
            return a * b;
        }
        public int div()
        {
            Console.WriteLine("division of a{0} and b:{1}:", a, b);
                return a / b;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Calculate c1 = new Calculate(10, 20);
            Calculate c2 = new Calculate(30, 40);
            Calculate c3 = new Calculate(10, 20);
            Calculate c4= new Calculate(20 ,10);
            Console.WriteLine( c1.add());
            Console.WriteLine( c2.sub());
            Console.WriteLine( c3.mul());
            Console.WriteLine(c4.div());
            Console.ReadKey();
        }
    }


}   

