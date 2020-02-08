using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Traineeeapp
{
    public partial class Selectrecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                DataLayer al = new DataLayer();
                var list = al.SelectRec();
                GridView1.DataSource = list;
                GridView1.DataBind();
            }
        }
    }
}