using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Traineeeapp
{
    public class DataLayer
    {
        DataSet ds = new DataSet();
        string constr = "";
        
        public DataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet SelectRec()
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SelectRec";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                
               
            }
           
            return ds;

        }
        public string InsertRow(int tid, string tname, string loc, string domain, DateTime date1)
        {
            string err = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@id", tid);
                    cmd.Parameters.AddWithValue("@tname", tname);
                    cmd.Parameters.AddWithValue("@tlocation", loc);
                    cmd.Parameters.AddWithValue("@ttechdomain", domain);
                    cmd.Parameters.AddWithValue("@tStartDate", date1);
                    cmd.CommandText = "InsertRec";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }

            catch (Exception e)
            {
                err = e.Message;
            }
            return err;
        }
        public void Update(int tid,string dom)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@id", tid);
                cmd.Parameters.AddWithValue("@domain", dom);
                cmd.CommandText = "Update";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                sda.Update(ds);
            }
            catch(Exception e)
            {
               
            }
        }
    }
}