using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample
{
    class Program
    {
        static void Main(string[] args)
        {    
            ThreadStart tsd = new ThreadStart(getNumbers);
            Thread th = new Thread(tsd);
            th.Start();
           
        }
        public static void getNumbers()
        {
            for(int i=1;i<10;i++)
            {
                
                Console.WriteLine("{0}", i);
                Thread.Sleep(400);
            }
        }
    }
}
