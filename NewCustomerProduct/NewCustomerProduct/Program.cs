using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCustomerProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertData();
            CustomerContext ctx = new CustomerContext();
            var customers = ctx.Customers;
            Console.WriteLine("Customers..\n");
            foreach(var cst in customers)
            {
                Console.WriteLine("{0}\t{1}\t{2}", cst.Cid, cst.Cname, cst.Cadress);
            }
            Console.WriteLine("\nProducts...\n");
            var products = ctx.Products;
            foreach(var prd in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}", prd.Pid, prd.Pname, prd.Price);
            }
            Console.WriteLine("\n Purchases ....\n");
            var purchases = ctx.Purchase;
            foreach(var pr in purchases)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", pr.Id, pr.orderDate,
                    pr.Pid, pr.Cid);
            }
        }
      private static void InsertData()
        {
            CustomerContext ctx = new CustomerContext();
            var customers = new List<Customer> 
            {
                new Customer{ Cid=1,Cname="keerthi",Cadress="chennai"},
                new Customer{ Cid=2,Cname="sravya",Cadress="chennai"},
                new Customer{Cid=3,Cname="sameera",Cadress="vijayawada"},
                new Customer{Cid=4,Cname="sindhu",Cadress="chennai"}
            };
            customers.ForEach(cst => ctx.Customers.Add(cst));
            ctx.SaveChanges();
            var products = new List<Product> 
            {
                new Product{Pid=1,Pname="chocolate",Price=100 },
                new Product{Pid=2,Pname="biscuits",Price=50},
                new Product{Pid=3,Pname="Cake",Price=450},
                new Product{Pid=4,Pname="Sweets",Price=250}
                };
            products.ForEach(pr => ctx.Products.Add(pr));
            ctx.SaveChanges();
            var purchases = new List<Purchase> 
            {
                new Purchase{orderDate=Convert.ToDateTime("09-02-2020"),Pid=1,Cid=2 },
            new Purchase { orderDate = Convert.ToDateTime("10-02-2020"), Pid = 2, Cid = 1},
                new Purchase{orderDate=Convert.ToDateTime("10-02-2020"),Pid=3,Cid=2 },
                new Purchase{orderDate=Convert.ToDateTime("11-02-2020"),Pid=3,Cid=3 },
                new Purchase{orderDate=Convert.ToDateTime("12-02-2020"),Pid=4,Cid=4},
                new Purchase{orderDate=Convert.ToDateTime("12-02-2020"),Pid=1,Cid=2 } 
            };
            purchases.ForEach(pr => ctx.Purchase.Add(pr));
            ctx.SaveChanges();
            Console.ReadKey();
        }
    }
}
    

