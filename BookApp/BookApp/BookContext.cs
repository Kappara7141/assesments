using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BookApp
{
    class BookContext:DbContext
    {
        public BookContext() : base("BookContext") { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Details> details { get; set; }

    }
}
