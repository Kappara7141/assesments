using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_DBApproach
{
    class Program
    {
        static EmployeeDBEntities1 mdb = new EmployeeDBEntities1();
        
        static void Main(string[] args)
        {
            //Cateogrydata();
            //Productdata();
            //  insertCatData ();
            insertProdData();

            Console.ReadKey();
        }

        private static void insertProdData()
        {
            int ch;

            do
            {
                Console.WriteLine("Enter pid");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter title");
                string ptitle = Console.ReadLine();
                Console.WriteLine("Enter price");
                var pr = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter cid");
                var Cid = int.Parse(Console.ReadLine());
                mdb.Products.Add(new Product { pid = id, title = ptitle, price = pr, cid = Cid });
                Console.WriteLine("Do u want to add one more 1.yes 2.No");
                ch = int.Parse(Console.ReadLine());
            } while (ch == 1);
            mdb.SaveChanges();

        }

        private static void insertCatData()
        {
            int ch;

            do
            {
                Console.WriteLine("Enter cid");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter cname");
                string name = Console.ReadLine();
                mdb.Categories.Add(new Category { cid = id, cname = name });
                Console.WriteLine("Do u want to add one more 1.yes 2.No");
                ch = int.Parse(Console.ReadLine());
            } while (ch == 1);
            mdb.SaveChanges();
        }

        private static void Productdata()
        {
            Console.WriteLine("Product data...\n");
            var product = mdb.Products;
            foreach (var p in product)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", p.pid, p.title, p.price, p.cid);
            }
        }

        private static void Cateogrydata()
        {
            Console.WriteLine("Category data...\n");
            var category = mdb.Categories;
            foreach (var c in category)
            {
                Console.WriteLine("{0}\t{1}", c.cid, c.cname);
            }
        }
    }
}
