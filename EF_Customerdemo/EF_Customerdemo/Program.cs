using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Customerdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerContext x = new CustomerContext();
            Console.WriteLine("Enter the cid");
            int CID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cname");
            string CNAME = Console.ReadLine();
            List<Product> p = new List<Product>();
            int ch = 1;
            do
            {
                Console.WriteLine("Enter the product id");
                int prid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter product name");
                string prname = Console.ReadLine();
                Console.WriteLine("Enter product price");
                int pprice = int.Parse(Console.ReadLine());
                p.Add(new Product { pid = prid, pname = prname, price = pprice });
                Console.WriteLine("Do u want to add more product:1.Yes\n2.No");
                ch = int.Parse(Console.ReadLine());
            } while (ch == 1);
            x.Customers.Add(new Customer { cid = CID, cname = CNAME });
            x.SaveChanges();
            var e = x.Customers;
            var pt = x.Products;
            var query = (from cust in e
                         join pro in pt
          on cust.cid equals pro.pid
                         select new
                         {
                             cust.cid,
                             cust.cname,
                             pro.pid,
                             pro.pname
                         });
            Console.Write("Enter the id of customer");
            int id1 = int.Parse(Console.ReadLine());
            var get = from a in query
                      where a.cid == id1
                      select a;
            foreach (var m in get)
            {
                Console.WriteLine($"{m.cname}\t{m.pname}");
            }

        }
    }
}
