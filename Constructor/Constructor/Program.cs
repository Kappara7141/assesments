using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Car
    {
        string regno, model, color;
        double price;
       public Car() { }
       public Car(string reg)
        {
            regno = reg;
        }
       public Car(string reg, string mod)
        {
            regno = reg;
            model = mod;

        }
        public Car(string regno, string model, string color, double pr)
        {
            this.regno = regno;
           this. model = model;
           this.color = color;
            price = pr;
        }
        public void show()
        {
            Console.WriteLine("regno:{0},model:{1},color:{2},price:{3}", regno, model, color, price);
        }
    }
      class program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.show();
            Car c1 = new Car("ADPIJ0999");
            c1.show();
            Car c2 = new Car("ap6789", "ee32", "black", 6000);
            c2.show();
            Console.ReadKey();
        }
    }
        
        
    
}
