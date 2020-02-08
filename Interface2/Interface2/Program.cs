using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
   abstract class Bike
    {
       abstract public void showbike();
    }
    interface IDrone
    {
        void show();
    }
    class BikeDrone : Bike, IDrone
    {
        public override void showbike()
        {
            Console.WriteLine("The interface method is defined");
        }
        public void show()
        {
            Console.WriteLine("The defined interface");
        }
        static void Main(string[] args)
        {
            BikeDrone bd = new BikeDrone();
            bd.showbike();
            bd.show();
            Console.ReadKey();
        }
    }
      
    
}
