using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oopsdemos
{
    class Trainee
    {
        string name, address;
        int age,id;
        public void Getdata(string nm, int id, string adr, int ag)
        {
            name = nm;
            this.id = id;
            address = adr;
            age = ag;
        }
        public void showData()
        {
            Console.WriteLine("name:{0},id:{1},address:{2},age:{3}", name, id, address, age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            geTrObj();
            Trainee tr1 = new Trainee();
            Console.WriteLine();
            tr1.Getdata("sindhu", 670008, "chennai", 15);
            tr1.showData();
        }

        private static void geTrObj()
        {
            Trainee tr = new Trainee();
            tr.Getdata("sravya", 850006, "chennai", 21);
            tr.showData();
        }
    }
}
