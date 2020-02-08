using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericollections
{
    class Class1
    {
        static void Main(string[] args)
        {
            List<Course> clst = new List<Course>()
            {
                    new Course{Cid=1,Cname="C#",Fees=7000, StartDate=Convert.ToDateTime("01-01-2020") },
                    new Course { Cid = 2, Cname = "CSS", Fees = 4000,StartDate = Convert.ToDateTime("01-01-2020")},
                     new Course { Cid = 3, Cname = "python", Fees = 9000,StartDate = Convert.ToDateTime("01-01-2020")},
                      new Course { Cid = 4, Cname = "webapps", Fees = 5000,StartDate = Convert.ToDateTime("01-01-2020")},
            };
            var v = from a in clst
                    orderby a.Fees
                    select a;
            foreach (var q in v)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", q.Cid, q.Cname, q.StartDate, q.Fees);
            }
            Console.ReadKey();
        }
    }
       class Course
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
        public DateTime StartDate { get; set; }
        public int Fees { get; set; }
    }
}
    