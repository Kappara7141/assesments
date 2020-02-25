using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBfirstEFconsoleApp
{
    class Program
    {
        static EmployeeDBEntities edb = new EmployeeDBEntities();
        static void Main(string[] args)
        {
            coursedata();
            Traineedata();
            Console.ReadKey();
        }

        private static void Traineedata()
        {
            Console.WriteLine("Trainee data...\n");
            var trainee = edb.Traineees;
            foreach (var t in trainee)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", t.TId, t.Name, t.Location, t.TechDomain, t.StartDate);
            }
        }

        private static void coursedata()
        {
            Console.WriteLine("All Students are..");
            var courses = edb.Courses;
            foreach (var c in courses)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", c.Course_id, c.coursename, c.Startdate, c.Fees);
            }
        }
    }
}
