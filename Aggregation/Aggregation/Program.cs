using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    public class Product
    {
        public int pid;
        public string pname;
        public double pprice;
        public void pro(int i, string name, double price)
        {
            pid = i;
            pname = name;
            pprice = price;
        }
    }
    public class Category
    {
        public int cid;
        public string description;
        Product p;
        public void cat(int id, string desc, Product p)
        {
            cid = id;
            description = desc;
            this.p = p;
        }
        public void display()
        {
            Console.WriteLine("product id:" + p.pid);
            Console.WriteLine("product name:" + p.pname);
            Console.WriteLine("product price:" + p.pprice);
            Console.WriteLine("Category id:" + cid);
            Console.WriteLine("Category description:" + description);
        }
    }
    class Test
    {
        public static void Main(string[] args)
        {
            Product pr = new Product();
            pr.pro(11, "choclate", 4000);
            Category c = new Category();
            c.cat(10, "choclate is tasty",pr);
            c.display();
            Console.ReadKey();
        }
    }


}   

