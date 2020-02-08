using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collectionstack
{
    class Stacks
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            Console.WriteLine("stack items...........");
            stk.Push("Choclate");
            stk.Push("Biscuit");
            stk.Push("Cake");
            foreach (string s in stk)
            {
                Console.WriteLine(s);
            }
            
            
            Console.WriteLine("Queue............");
            Queue q = new Queue();
            q.Enqueue("Choclates");
            q.Enqueue("Biscuits");
            q.Enqueue("Cake");
            foreach(string s in q)
            {
                Console.WriteLine(s);
            }
            SortedList sl = new SortedList();
            sl.Add("Zameer", 234);
            sl.Add("Anand", 123);
            sl.Add("sravs", 646);
            foreach(string k in sl.Keys)
            {
                Console.WriteLine(k);
            }
            Console.ReadKey();
        }
    }
}
