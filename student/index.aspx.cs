using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student
{
    public partial class index1 : System.Web.UI.Page
    {
        BaseClass baseclass1 = new BaseClass();
        string student_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["stu"] != null)
            {
                student_id = Request.QueryString["stu"];
            }
            else
            {
                Response.Redirect("login.aspx");
            }
            Func func = new Func();
            student_gg_title.Text = func.get_gg_title();
            student_gg_content.Text = func.get_gg_content();
        }
    }
}