using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Crudoperationwebform
{
    public class DataLayer
    {
        DataSet ds = new DataSet();
        string constr = "";

        public DataLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        
        public string InsertStudentRec(int sid, string sname, string saddress, int cid)
        {
            return studentinsert(sid, sname, saddress, cid);
        }

        private string studentinsert(int sid, string sname, string saddress, int cid)
        {
            string err = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@sid", sid);
                    cmd.Parameters.AddWithValue("@sname", sname);
                    cmd.Parameters.AddWithValue("@saddress", saddress);
                    cmd.Parameters.AddWithValue("@cid", cid);

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

        public string InsertCourseRec(int cid, string cname, int fees)
        {
            return Courseinsert(cid, cname, fees);
        }

        private string Courseinsert(int cid, string cname, int fees)
        {
            string err = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@cname", cname);
                    cmd.Parameters.AddWithValue("@fee", fees);


                    cmd.CommandText = "insertcourserec";
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

        public string InsertFacultyRec(int fid, string fname, string sub)
        {
            return Facultyinsert(fid, fname, sub);
        }

        private string Facultyinsert(int fid, string fname, string sub)
        {
            string err = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@fid", fid);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@sub", sub);


                    cmd.CommandText = "insertfacultyrec";
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
        public DataSet displaycoursedetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "selectcourserec";
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
        public DataSet displayfacultydetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "selectfacultyrec";
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

        public DataSet Update(int i,string s)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@sid", i);
                cmd.Parameters.AddWithValue("@sname", s);
                cmd.CommandText = "updatestudents";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                sda.Update(ds);
            }
            catch (Exception ex)
            {


            }

            return ds;

        }
        public DataSet Updatecourse(int i, string s)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@cid", i);
                cmd.Parameters.AddWithValue("@cname", s);
                cmd.CommandText = "updatecourses";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                sda.Update(ds);
            }
            catch (Exception ex)
            {


            }

            return ds;

        }
        public DataSet Updatefaculty(int i, string s)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@fid", i);
                cmd.Parameters.AddWithValue("@fname", s);
                cmd.CommandText = "facultyupdate";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                sda.Update(ds);
            }
            catch (Exception ex)
            {


            }

            return ds;

        }
        public DataSet deletestudent(int i)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@sid", i);
                
                cmd.CommandText = "deleteStudent";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                sda.Update(ds);
            }
            catch (Exception ex)
            {


            }

            return ds;

        }
        public DataSet deletecourse(int i)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@cid", i);

                cmd.CommandText = "deletecourse";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                sda.Update(ds);
            }
            catch (Exception ex)
            {


            }

            return ds;

        }
        public DataSet deletefaculty(int i)
        {
            try
            {
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@fid", i);

                cmd.CommandText = "deletefaculty";
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                sda.Update(ds);
            }
            catch (Exception ex)
            {


            }

            return ds;

        }
    }


    }

    
