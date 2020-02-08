using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automaticproprties
{
    class Product
    {
        public int Id { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }
    }
    class program
    {
        static void Main(string[] args)
        {
            Product pd = new Product { Id = 1, Pname = "choclate", Price = 40 };
            Console.WriteLine("{0}\n{1}\n{2}", pd.Id, pd.Pname, pd.Price);
        }
    }

}   

