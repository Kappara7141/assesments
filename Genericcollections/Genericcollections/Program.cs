using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericcollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courseList = new List<Course>();
            courseList.Add(new Course
            {
                Cid = 1,
                Cname = "C#",
                StartDate = DateTime.Today,
                Fees = 6000
            });
            courseList.Add(new Course
            {
                Cid = 2,
                Cname = "Webapps",
                StartDate = DateTime.Parse("05-02-2020"),
                Fees = 8000
            });
            courseList.Add(new Course
            {
                Cid = 3,
                Cname = "python",
                StartDate =Convert.ToDateTime("08-02-2020"),
                Fees = 5000
            });
            foreach(Course cr in courseList)
            {
                Console.WriteLine("{0}\t{1}\n{2}\t{3}", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }
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
