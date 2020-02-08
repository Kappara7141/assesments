using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetingsbday
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "name:{0} , Age:{1}";
            string msg = string.Format(s, "congratulations Mr/Miss {0} on your {1} Birthday", name,age);
            Console.WriteLine("Format result:{0}", msg);
            Console.WriteLine("\n press enter key to exit");
            Console.ReadLine();
        }
    }
}
