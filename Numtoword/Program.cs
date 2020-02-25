using System;

namespace Numtoword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting number to word......");
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            NumberToWord(n);
        }
        private static int NumberToWord(int n)
        {
            int rev = 0, i = 0;
            string[] a = new string[10];
            do
            {
                rev = n % 10;
                switch (rev)
                {
                    case 0:
                        a[i] = "ZERO";
                        break;
                    case 1:
                        a[i] = "ONE";
                        break;
                    case 2:
                        a[i] = "TWO";
                        break;
                    case 3:
                        a[i] = "THREE";
                        break;
                    case 4:
                        a[i] = "FOUR";
                        break;
                    case 5:
                        a[i] = "FIVE";
                        break;
                    case 6:
                        a[i] = "SIX";
                        break;
                    case 7:
                        a[i] = "SEVEN";
                        break;
                    case 8:
                        a[i] = "EIGHT";
                        break;
                    case 9:
                        a[i] = "NINE";
                        break;
                }
                i++;
                n = n / 10;
            } while (n > 0);
            i--;
            for (; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
            return n;
        }
    }
}
