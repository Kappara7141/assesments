using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertData();
            BookContext btx = new BookContext();
            var books = btx.Books;
            Console.WriteLine("Books...\n");
            foreach(var bst in books)
            {
                Console.WriteLine("{0}\t{1}\t{2}", bst.bid, bst.title, bst.price);
            }
            Console.WriteLine("Authors...\n");
            var authors = btx.Authors;
            foreach(var aut in authors )
            {
                Console.WriteLine("{0}\t{1}\t{2}", aut.aid, aut.name, aut.adress);
            }
            Console.WriteLine("Details...\n");
            var Details = btx.details;
            foreach(var dt in Details)
            {
                Console.WriteLine("{0}\t{1}", dt.bid, dt.aid);
            }
        }
        private static void InsertData()
        {
            BookContext btx = new BookContext();
            var books = new List<Book>
            {
                 new Book{ bid=1,title="aaaa",price=230},
                 new Book{ bid=2,title="bbbb",price=300},
                 new Book{ bid=3,title="cccc",price=530}
            };
            books.ForEach(bst => btx.Books.Add(bst));
            btx.SaveChanges();
            var authors = new List<Author>
            {
                new Author{aid=1,name="john",adress="sfsf"},
                new Author{aid=2,name="peter",adress="ghgh"},
                new Author{aid=3,name="messy",adress="svsv"}
            };
            authors.ForEach(aut => btx.Authors.Add(aut));
            btx.SaveChanges();
            var details = new List<Details>
            {
                new Details{bid=1,aid=1},
                new Details{bid=2,aid=2},
                new Details{bid=3,aid=3}
            };
            details.ForEach(dt => btx.details.Add(dt));
            btx.SaveChanges();
            Console.ReadKey();

        }
    }
}
