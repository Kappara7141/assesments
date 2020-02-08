using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            { "Amma","Raj","Munna","Krish","Sajid","Chandu"};
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            al.Sort();
            string[] r = new string[] { "Cat", "Mat" };
            al.SetRange(4, r);
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.RemoveRange(2, 2);
            Console.WriteLine();
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
            al.Add("sam");
            al.Add("sravs");
            foreach(string a in al)
            {
                Console.WriteLine(a);
            }
        }
    }
}
