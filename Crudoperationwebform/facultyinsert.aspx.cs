using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crudoperationwebform
{
    public partial class facultyinsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button_submit(object sender, EventArgs e)
        {

            DataLayer d = new DataLayer();
            int fid = Convert.ToInt32(TextBox1.Text);
            string fname = TextBox2.Text;
            string sub = TextBox3.Text;
            

            string s = d.InsertFacultyRec(fid, fname, sub);
            label1.Text = s;
        }
    }
}