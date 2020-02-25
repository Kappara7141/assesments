using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crudoperationwebform
{
    public partial class updatecoursedetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_submit(object sender, EventArgs e)
        {
            DataLayer d = new DataLayer();
            int cid = int.Parse(TextBox1.Text);
            string cname = TextBox2.Text;
            d.Updatecourse(cid, cname);
        }
    }
}