using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crudoperationwebform
{
    public partial class Courseinsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_submit(object sender, EventArgs e)
        {

            DataLayer d = new DataLayer();
            int cid = Convert.ToInt32(TextBox1.Text);
            string cname = TextBox2.Text;
            int fees= Convert.ToInt32(TextBox3.Text);


            string s = d.InsertCourseRec(cid, cname, fees);
            label1.Text = s;
        }
    }
}