using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello World";
            Console.WriteLine(data);
            string a = data.Insert(6, "My");
            String bn = "You are so nice";
            Console.WriteLine(a);
            Console.WriteLine(String.Concat(a, bn));
            String up = data.ToUpper();
            String lc = data.ToLower();
            Console.WriteLine("substring {0}", bn.Substring(4, 4));
            Console.WriteLine("{0}\t{1}", up, lc);
            string[] names = new string[] { "Anand", "Raju", "Munna" };
            foreach(string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",", names);
            Console.WriteLine(allnames);
            string st1 = "Welcome to the c#";
            String[] words = st1.Split();
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            string nstr = string.Copy(st1);
            Console.WriteLine("copied string is {0}", nstr);
            int i = st1.IndexOf("to");
            Console.WriteLine("index of is {0}", i);
            int l = st1.Length;
            Console.WriteLine("length of the string is {0}", l);
            string w1 = "hello";
            w1.Reverse();
            foreach(string w in words)
            {
                Console.WriteLine(w);
            }
            int nx = string.Compare("hello", "hello");
            Console.WriteLine("comparision is {0}", nx);
        }
    }
}
