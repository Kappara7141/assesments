using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADODemoex
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = @"Data Source=BLT1043\SQLEXPRESS2014;Initial Catalog=EmployeeDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                string insertquery="insert into Department1(Did,Dname) values("+""
                try
                {
                    string querystr = "select * from Employee";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
            

           
