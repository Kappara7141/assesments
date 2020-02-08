using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx2
{
    class Program
    {
        public delegate void Deleventhandler();
        public static event Deleventhandler handler;
        static void Main(string[] args)
        {
            handler += new Deleventhandler(Square);
            handler += new Deleventhandler(Circle);
            handler.Invoke();
        }
        static void Circle()
        {
            double r = 5;
            double ar = Math.PI * r * r;
            Console.WriteLine("Area of Circle:{0}", ar);
        }
        static void Square()
        {
            double s = 5;
            double sr = s * s;
            Console.WriteLine("Area of Square:{0}", sr);
        }
    }
}
