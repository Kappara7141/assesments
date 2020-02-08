using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation1
{
    class Customer
    {
        public int cid;
        public string name, address;
        public void get(int i,string cname,string add)
        {
             cid = i;
             name = cname;
            address = add;
        }

    }
    class BankAccount
    {
        int acounumber,balance;
        Customer c;
        int principle = 1000, rate = 3, time = 2;
        public void bankDetail(int accnum,int bal,Customer c)
        {
            acounumber = accnum;
            balance = bal;
            this.c = c;
        }
        public virtual double interestamount(double p,int t,double r)
        {
            double simpleinterest = (p * t * r) / 100;
            return simpleinterest;
        }
        public void display()
        {
            Console.WriteLine("Customer ID:" + c.cid);
            Console.WriteLine("Customer name:" + c.name);
            Console.WriteLine("Customer Address:" + c.address);
            Console.WriteLine("account number:" + acounumber);
            Console.WriteLine("account balance:" + balance);
        }
    }
    class FixedAccount:BankAccount
    {
        public override double interestamount(double p,int t,double r)
        {
            double s1 = (p * t * r) / 100;
            double fi = s1 * 3 / 100;
            double total = fi + s1;
            Console.WriteLine("SimpleInterest +3% additional:");
            return total;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Customer c2 = new Customer();
            c2.get(10, "sravya", "chennai");
            BankAccount b = new BankAccount();
            b.bankDetail(67896, 4000, c2);
            b.display();
            Console.WriteLine(b.interestamount(1000, 2, 3));
            FixedAccount f = new FixedAccount();
            Console.WriteLine(f.interestamount(1000, 2, 3.03));
            Console.ReadKey();
        }
    }
       
        
    
}
