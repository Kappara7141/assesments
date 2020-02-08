using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringarray
{
    class Array
    {
        public string JoinstrArray(string[] arr)
        {
            return string.Join(" ", arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] ary = new string[size];
            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine("Enter word {0}", i + 1);
                ary[i] = Console.ReadLine();
            }
            Array a = new Array();
            Console.WriteLine(a.JoinstrArray(ary));
            Console.ReadKey();

        }
    }
}


