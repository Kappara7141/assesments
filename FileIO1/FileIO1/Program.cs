using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO1
{
    class Program
    {
        
            string path = @"D:\New Folder\sravs1.Text";
            public void createfile()
            {
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        Console.WriteLine("Enter Your Name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter your city");
                        string city = Console.ReadLine();
                        Console.WriteLine("Enter your Id");
                        string id = Console.ReadLine();
                        sw.WriteLine("name:" + name);
                        sw.WriteLine("city:" + city);
                        sw.WriteLine("id:" + id);

                    }
                }
            }
            public void displayfile()
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    Console.ReadKey();
                }
            }
            public void appendsontext()
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("It is a famous city which i have been living.");
                Console.WriteLine("Enter some text");
                    string s = Console.ReadLine();
                    sw.WriteLine(s);
                }
            }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.createfile();
            p.displayfile();
            p.appendsontext();
            p.displayfile();


        }
    }
}

