using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversearray
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] arr=new int[]{1, 2, 3, 4, 5};
            int Length=arr.Length-1;
            int n=null;
            while(Length>=0)
            {
              n=n+arr[Length];
                Length--;
            }
            Console.WriteLine();
            Console.WriteLine("Reverse array is "+" "+n);
            Console.ReadLine();
        }
    }

}
