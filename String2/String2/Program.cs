using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder("hello");
            Console.WriteLine(stb);
            stb.Append(23445);
            Console.WriteLine("Appended long values {0}", stb);
            int i = stb.Capacity;
            Console.WriteLine("Initial capacity of stringBuilder is {0}", i);
            stb.Insert(6, "World");
            Console.WriteLine("insert at 6 is {0}", stb);
            stb.Remove(7, 4);
            Console.WriteLine("After removing {0}", stb);
            stb.Replace("lo", "arious");
            Console.WriteLine("After replacing {0}", stb);
            stb.Clear();
            Console.WriteLine("After clear {0}", stb);
            Console.ReadKey();
        }
    }
}
