using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student
{
    public partial class indexa : System.Web.UI.Page
    {
        string admin_id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["admin"] != null)
            {
                admin_id = Request.QueryString["admin"];
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}