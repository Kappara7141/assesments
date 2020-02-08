using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week
{
    class Program
    {
        enum Weekdays
        {
            Monday=1,tuesday=2,wednesday,thursday,friday,saturday,sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("tuesday:{0}", (int)Weekdays.tuesday);
        }
    }
}
