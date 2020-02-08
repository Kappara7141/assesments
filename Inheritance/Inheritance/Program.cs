using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public void showVehicle()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
    class Roadwayvehicles:Vehicle
    {
        public void showRoadwayvehicles()
        {
            Console.WriteLine("Roadway vehicles");
        }
    }
    class Train : Roadwayvehicles
    {
        public void showTrain()
        {
            Console.WriteLine("This is a Train");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Roadwayvehicles r = new Roadwayvehicles();
            Vehicle v = new Vehicle();
            Train t = new Train();
            t.showVehicle();
            r.showVehicle();
            v.showVehicle();
            t.showTrain();
            
        }
    }
}
