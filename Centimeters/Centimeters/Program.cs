using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centimeters
{
    class Centimeters
    {
        double inch;
        double Centimeter;
        public double Inch
        {
            get { return Centimeter * 2.54; }
            set {
                
                Centimeter = value / 2.54;
            }
        }

        public void showcent()
        {
            Console.WriteLine("{0} inch: {1} centimeter", inch, Centimeter);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Centimeters c = new Centimeters();
            c.Inch = 25;
            Console.WriteLine(c.Inch);
            c.showcent();

        }
    }

}   

