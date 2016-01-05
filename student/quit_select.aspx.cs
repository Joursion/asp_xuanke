using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student
{
    public partial class quit_select : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string student_id = "";
            if (Request.QueryString["stu"] != null)
            {
                student_id = Request.QueryString["stu"];
            }
            else
            {
                Response.Redirect("404.html");
                // Response.Write(student_id);
            }
            if (Session[student_id] == null)
            {
                Response.Write("请登录");
            }


        }
    }
}