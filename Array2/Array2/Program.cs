﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    class Evenarray
    {
        public int Evensum(int[] arr)
        {
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2==0)
                {
                    sum = sum + arr[i];
                }
            }
            return sum;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Evenarray e = new Evenarray();
                int[] arr1 = { 1, 2, 3, 4 };
                Console.WriteLine( e.Evensum(arr1));

             
            }
        }
        
    }
}
