using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listcollections
{
    class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Designation { get; set; }
        public int salary { get; set; }
    }
    class EmpColection
    {

        List<Employee> lstEmp = new List<Employee>();
        Employee e = new Employee();
        public void adddata(int id, string name, string Desig, int sal)
        {
            lstEmp.Add(new Employee
            {
                Eid = id,
                Ename = name,
                Designation = Desig,
                salary = sal,
            });
        }
        public void show()
        {
            foreach (Employee e1 in lstEmp)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", e1.Eid, e1.Ename, e1.Designation, e1.salary);
            }
        }
        public void remove()
        {

        }
        static void Main(string[] args)
        {
            EmpColection ee = new EmpColection();
            ee.adddata(2222, "sravya", "software", 6000);
            ee.adddata(1111, "sindhu", "officer", 8000);
            ee.show();
            
            Console.ReadKey();
        }
    }
}
        
       
                    
    
