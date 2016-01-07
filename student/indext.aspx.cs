using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student
{
    public partial class indext : System.Web.UI.Page
    {
        BaseClass baseclass1 = new BaseClass();
        string teacher_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["teacher"] != null)
            {
                teacher_id = Request.QueryString["teacher"];
            }
            Func func = new Func();
            teacher_gg_title.Text = func.get_gg_title();
            teacher_gg_content.Text = func.get_gg_content();
        }
    }
}