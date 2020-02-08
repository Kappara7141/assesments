using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traineeeapp
{
    public partial class UpdateRec : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UPDATE_ButtonSubmit(object sender, EventArgs e)
        {
            DataLayer d = new DataLayer();
            d.Update(Convert.ToInt32(TextBox1.Text), TextBox2.Text);

        }
    }
}