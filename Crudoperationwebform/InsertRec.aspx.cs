using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crudoperationwebform
{
    public partial class InsertRec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_submit(object sender, EventArgs e)
        {

            DataLayer d = new DataLayer();
            int sid = Convert.ToInt32(TextBox1.Text);
            string sname = TextBox2.Text;
            string saddr = TextBox3.Text;
            int cid = Convert.ToInt32(TextBox4.Text);
            
            string s = d.InsertStudentRec(sid,sname,saddr,cid);
            label1.Text = s;
        }
    }
}