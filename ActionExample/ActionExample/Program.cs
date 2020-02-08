using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> Multiply = (x, y) => Console.WriteLine("{0}", x * y);
            Func<int, int,int> add = (x, y) => (x + y);
            List<Student> lst = new List<Student>
            {
                new Student{ID=1,StudentName="Aravind",Course="C#"},
                new Student{ID=2,StudentName="Kamal",Course="java"},
                new Student{ID=3,StudentName="sravya",Course="CSS"}
            };
            Predicate<Student> fst = x => x.ID == 3;
            Student st = lst.Find(fst);
            Console.WriteLine("{0}\t{1}\t{2}", st.ID, st.StudentName, st.Course);
            Console.ReadKey();
        }
        
    }
    
}
