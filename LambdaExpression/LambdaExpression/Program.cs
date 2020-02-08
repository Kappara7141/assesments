using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        
            private static void Lambdaexpression()
            {
                Func<int, int> Cube = a => a * a * a;
                Console.WriteLine("Enter Any Number");
                int cr = int.Parse(Console.ReadLine());
                Console.WriteLine(Cube(cr));
            }
            private static void LambdaLinqOrdr()
            {
                int[] nos = { 45, 23, 12, 98, 65 };
                var sort = nos.OrderBy(x => x);
                Console.WriteLine(string.Join(" ", sort));
            }
        }
    }
