using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_ExaminationProject
{
    class Program
    {
        static EF_ExaminationprojectEntities edb = new EF_ExaminationprojectEntities();
        static void Main(string[] args)
        {
            //UserTabledata();
            // LoginTabledata();
            // StudentTabledata();
            // ExamTabledata();
            //SubjectTabledata();
            Console.ReadLine();
        }

        private static void SubjectTabledata()
        {
            int ch;

            do
            {
                Console.WriteLine("Enter student rollnumber");
                var stdid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Exam id");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter English marks");
                var eng = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Maths marks");
                var math = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Science marks");
                var sci = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Social marks");
                var soc = int.Parse(Console.ReadLine());
                edb.SubjectTables.Add(new SubjectTable { Stdrollno = stdid, ExamId = id, English = eng, Maths = math, Science = sci, Social = soc });
                Console.WriteLine("Do u want to add one more 1.yes 2.No");
                ch = int.Parse(Console.ReadLine());
                edb.SaveChanges();
            } while (ch == 1);
        }

        private static void ExamTabledata()
        {
            int ch;

            do
            {
                Console.WriteLine("Enter Exam id");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Exam type");
                string type = Console.ReadLine();
                Console.WriteLine("Enter student rollnumber");
                var stdid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter total marks");
                var tmrks = int.Parse(Console.ReadLine());
                edb.ExamTables.Add(new ExamTable { ExamId = id, ExamType = type, Stdrollno = stdid, Tmarks = tmrks });
                Console.WriteLine("Do u want to add one more 1.yes 2.No");
                ch = int.Parse(Console.ReadLine());
                edb.SaveChanges();
            } while (ch == 1);
        }

        private static void StudentTabledata()
        {
            int ch;

            do
            {
                Console.WriteLine("Enter student rollnumber");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter school name");
                string sname = Console.ReadLine();
                Console.WriteLine("Enter school ID");
                var sid = int.Parse(Console.ReadLine());
                edb.StudentTables.Add(new StudentTable { Stdrollno = id, stdname = name, schlname = sname, schlId = sid });
                Console.WriteLine("Do u want to add one more 1.yes 2.No");
                ch = int.Parse(Console.ReadLine());
                edb.SaveChanges();
            } while (ch == 1);
        }

        private static void LoginTabledata()
        {
            int ch;

            do
            {
                Console.WriteLine("Enter userid");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter password");
                string pass = Console.ReadLine();

                edb.LoginTables.Add(new LoginTable { UserId = id, Password = pass });
                Console.WriteLine("Do u want to add one more 1.yes 2.No");
                ch = int.Parse(Console.ReadLine());
                edb.SaveChanges();
            } while (ch == 1);
        }

        private static void UserTabledata()
        {
            int ch;

            do
            {
                Console.WriteLine("Enter userid");
                var id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter username");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();
                Console.WriteLine("Enter Address");
                var addr = Console.ReadLine();
                edb.UserTables.Add(new UserTable { UserID = id, Uname = name, Email = email, Address = addr });
                Console.WriteLine("Do u want to add one more 1.yes 2.No");
                ch = int.Parse(Console.ReadLine());
                edb.SaveChanges();
            } while (ch == 1);
        }
    }
}
