using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptiontry
{
    public class divide
    { 

        int result;
        divide()
        {
             result = 0;
        }
        public void division(int num1, int num2)
        {
        
            try
            {
               int result = num1 / num2;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("rest of code");
            }

        }
        static void Main(string[] args)
        {
            divide d = new divide();
            d.division(25, 0);
            d.division(20, 2);
            Console.ReadKey();
        }
    }
}
