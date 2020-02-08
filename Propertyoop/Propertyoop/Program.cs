using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertyoop
{
    class Student
    {
        string firstname,lastname;
        int idno;
        string course;
        DateTime joindate;
        public Student(string fn,string ln)
        {
            firstname = fn;
            lastname = ln;
        }
        public string Name
        {
            get { return string.Format("{0} {1}",firstname,lastname); }
            
        }
        public int Idno
        {
            get { return idno; }
            set { idno = value; }
        }
        public string Course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime JoinDate
        {
            get { return joindate; }
            set { joindate = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            studentobj();
        }

        private static void NewMethod()
        {
            Student std = new Student("Lakshmi", "sravya");
            std.Idno = 123;
            std.Course = "C#";
            std.JoinDate = DateTime.Parse("01-10-2020");
            Console.WriteLine("name is {0}\n ID is {1}", std.Name, std.Idno);
            Console.WriteLine("Course:{0}\n Joining date:{1}", std.Course, std.JoinDate);
        }
    }

}   

