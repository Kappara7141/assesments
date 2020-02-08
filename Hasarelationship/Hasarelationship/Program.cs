using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasarelationship
{
    public class Department
    {
       public int d_id;
       public string d_name;
        public void dept(int i, string name)
        {
           d_id = i;
            d_name = name;
        }
    }
    public class Employee
    {
        int id;
        string name, address;
        Department d;
        public void Emp(int empid, string ename, string addr, Department d)
        {
            id = empid;
            name = ename;
            address = addr;
           this. d = d;
        }

        public void display()
        {
            Console.WriteLine("EmpId:" + id+ "empname:"+name+ "address:"+address+ "Dept_ID"+d.d_id+ "Dept_name"+d.d_name);
         }
    }
    class Test
    {
        public static void Main(string[] args)
        {
            Department d = new Department();
            d.dept(11, "maths");
            Employee e = new Employee();
            e.Emp(10, "sravya", "chennai",d);
            e.display();
        }
    }
        
    
}
