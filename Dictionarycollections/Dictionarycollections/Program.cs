using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarycollections
{
    class Course
    {
        public int Cid { get; set; }
        public string Cname { get; set; }
        public DateTime StartDate { get; set; }
        public int Fees { get; set; }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Dictionary<int,Course> d = new Dictionary<int,Course>();
            d.Add(1,new Course
            {
                Cid = 1,
                Cname = "c#",
                StartDate = DateTime.Today,
                Fees = 6000
            });
            d.Add(2,new Course
            {
                Cid = 2,
                Cname = "Webapps",
                StartDate = DateTime.Parse("05-02-2020"),
                Fees = 8000
            });
            d.Add(3,new Course
            {
                Cid = 3,
                Cname = "python",
                StartDate = Convert.ToDateTime("08-02-2020"),
                Fees = 5000
            });
            foreach (KeyValuePair<int, Course> cr in d)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", cr.Key, cr.Value.Cid, cr.Value.Cname, cr.Value.StartDate, cr.Value.Fees);
            }
            

        }
    }
    
}
