using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traineeeapp
{
    public partial class InsertRec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button_submit(object sender, EventArgs e)
        {

            DataLayer d = new DataLayer();
            int tid = Convert.ToInt32(TextBox1.Text);
            string tname = TextBox2.Text;
            string loc = TextBox3.Text;
            string domain = TextBox4.Text;
            DateTime dat = Convert.ToDateTime(TextBox5.Text);
            string s = d.InsertRow(tid, tname, loc, domain, dat);
            label1.Text = s;
        }
    }
}