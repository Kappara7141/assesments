using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examoop
{
    class Exam
    {
        string studentname;
        int class1,maths,physics;
        public void Getdata(string stname, int stdclass, int mat, int phy)
        {
        studentname=stname;
            class1=stdclass;
            maths=mat;
            physics=phy;
          }
    public void showData()
    {
        Console.WriteLine("studentname:" + studentname);
        Console.WriteLine("class1:" + class1);
        Console.WriteLine("maths:" + maths);
        Console.WriteLine("physics:" + physics);
    }
        class program
        {
            static void Main(string[] args)
            {
                Exam e = new Exam();
                e.Getdata("sravya", 8, 50, 90);
                e.showData();
                Exam e1 = new Exam();
                e1.Getdata("sindhu", 9, 80, 60);
                e1.showData();
            }
        }
}
       

    
}
