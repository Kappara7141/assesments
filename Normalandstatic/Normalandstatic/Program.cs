using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normalandstatic
{
    class Sample
    {
        int no = 0;
        static int cnt = 0;
        public Sample()
        {
            no++;
            cnt++;
            Console.WriteLine("no:{0}\ncount:{1}", no, cnt);
        }
        public static void show()
        {
            Console.WriteLine("from static show method");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            Sample s1 = new Sample();
            Sample s2 = new Sample();
            Sample.show();
        }
    }


}
