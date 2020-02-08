using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\New Folder\hello.text";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("Enter your Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your city");
                    string city = Console.ReadLine();
                    Console.WriteLine("Enter your Id");
                    string id = Console.ReadLine();
                    sw.WriteLine("name:" + name);
                    sw.WriteLine("city:" + city);
                    sw.WriteLine("Id:" + id);
                    //  sw.Flush();
                }
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }

                }
                Console.ReadKey();
            }
        }
        
    }
}
