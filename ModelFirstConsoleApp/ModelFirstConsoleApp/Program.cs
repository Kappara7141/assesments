using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstConsoleApp
{
    class Program
    {
        static ModelFirstEntityContainer mc = new ModelFirstEntityContainer();
        static void Main(string[] args)
        {
            // InsertCatdata();
            // InsertProductdata();
            ShowPrductdata();
            showCategorydata();
            Console.ReadLine();
        }

        private static void showCategorydata()
        {
            var c = mc.Categories;
            Console.WriteLine("All category details");
            foreach (var k in c)
            {
                Console.WriteLine("{0}\t{1}", k.Id, k.CatTitle);
            }
        }

        private static void ShowPrductdata()
        {
            var p = mc.Products;
            Console.WriteLine("All product details");
            foreach (var i in p)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", i.PId, i.Ptitle, i.Price, i.Id);
            }
        }

        private static void InsertProductdata()
        {
            int ch;

            do
            {
                Console.WriteLine("Enter product id");
                var pid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter product Title");
                string ptitle = Console.ReadLine();
                Console.WriteLine("Enter product price");
                double pprice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Category id");
                var CId = int.Parse(Console.ReadLine());
                mc.Products.Add(new Product { PId = pid, Ptitle = ptitle, Price = pprice, Id = CId });
                Console.WriteLine("Do u want to add one more 1.yes 2.No");
                ch = int.Parse(Console.ReadLine());
                mc.SaveChanges();

            } while (ch == 1);
        }


        private static void InsertCatdata()
        {
            int ch;

            do
            {
                Console.WriteLine("Enter category id");
                var CId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Category Title");
                string CTitle = Console.ReadLine();
                mc.Categories.Add(new Category { Id = CId, CatTitle = CTitle });
                Console.WriteLine("Do u want to add one more 1.yes 2.No");
                ch = int.Parse(Console.ReadLine());
                mc.SaveChanges();

            } while (ch == 1);
        }
    }

}
