using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
             enum Department
            {
            physics=10,
            chemistry,
            mathematics=15,
            }
        static void Main(string[] args)
        {
            Console.WriteLine("DepartmentID of mathematics:{0}", (int)Department.mathematics);

        }
           
        
    }
}
