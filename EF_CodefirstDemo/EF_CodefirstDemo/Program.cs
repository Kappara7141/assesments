using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodefirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Insert();
            //showallEmployees();
            // Linqoperations();
            Updateoperation();
        }

        private static void Updateoperation()
        {
            EmployeeContext empctx2 = new EmployeeContext();
            var employees = empctx2.Employees;
            Console.WriteLine("Enter ID");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter salary u want to update");
            var sal = double.Parse(Console.ReadLine());
            var e = from em in employees
                    where em.Eid == id
                    select em;
            foreach (var i in e)
            {
                i.Salary = sal;
            }
            foreach (var i in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", i.Eid, i.Ename, i.Designation, i.Salary);
            }
        }

        private static void Linqoperations()
        {
            EmployeeContext empctx1 = new EmployeeContext();
            var employees = empctx1.Employees;
            var linqQuery = from data in employees
                            where data.Eid == 1
                            select data;
            foreach (var i in linqQuery)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", i.Eid, i.Ename, i.Designation, i.Salary);
            Console.ReadKey();
        }

        private static void showallEmployees()
        {
            EmployeeContext empctx = new EmployeeContext();
            var employees = empctx.Employees;
            foreach (var emp in employees)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", emp.Eid, emp.Ename, emp.Designation, emp.Salary);
            }
        }

        private static void Insert()
        {
            EmployeeContext ect = new EmployeeContext();
            Console.WriteLine("Enter Employee name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Designation");
            string desg = Console.ReadLine();
            Console.WriteLine("Enter salary");
            double sal = Convert.ToDouble(Console.ReadLine());
            ect.Employees.Add(new Employee { Ename = name,
                Designation = desg, 
                Salary = sal 
            });
            ect.SaveChanges();
        }
    }
}
