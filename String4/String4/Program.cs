using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String4
{
    class String1
    {
        string firstname, lastname;
       public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public String1(string fname, string lname)
        {
            firstname = fname;
            lastname = lname;
        }
        public string fullName()
        {
            string x = firstname + " " + lastname;
            return x;
        }
    }
    class program
    {
        static void Main(string[]args)
        {
            String1 x = new String1("sravya", "Kappara");
            Console.WriteLine("{0}", x.fullName());
        }
    }
}
