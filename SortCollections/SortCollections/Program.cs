using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> lst = new List<Student>
            {
                new Student{ID=1,StudentName="Sravya",Course="C#" },
                new Student{ID=2,StudentName="Kamal",Course="CSS"},
                new Student{ID=3,StudentName="sri",Course="webapps"}
            };
            lst.Sort();
            Console.WriteLine();
            Console.WriteLine("sorted list items.....");
            foreach(Student s in lst) 
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
