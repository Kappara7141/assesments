using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examplestatic
{
    class Sales
    {
        string Productname;
        int Quantity;
        double price;
        static double totalsales = 0;
        double Salesamount;
        public string prdname
        {
            get { return Productname; }
            set { Productname = value; }
        }
        public int Quantity1
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public double price1
        {
            get { return price; }
            set { price = value; }
        }
        public double Saleamount
        {
            get { return price * Quantity; }
        }
        public double Totalsales
        {
            get { return totalsales += Salesamount; }
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            Sales s = new Sales();
            s.prdname = "Icecream";
            s.Quantity1 = 5;
            s.price1 = 10;
            Console.WriteLine(s.Saleamount);
            Console.WriteLine(s.Totalsales);
            Console.ReadKey();
        }
    }
}
