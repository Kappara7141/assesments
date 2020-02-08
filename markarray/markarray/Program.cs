using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace markarray
{
    class Program
    {
        public static double average(int[] marks,int l)
        {
            double sum = 0, avg = 0;
            for (int i = 0; i < l; i++)
            {
                sum = sum + marks[i];
            }
                 avg= sum / l;
                return avg;
            
        }
        static void Main(string[] args)
        {
            int[] marks = new int[] { 85, 89, 90, 93, 94, 95 };
            int l = marks.Length;
            
                Console.WriteLine(average(marks,l));
                Console.ReadKey();
            
        }
    }
}
