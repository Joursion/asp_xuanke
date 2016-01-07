using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace student
{
    public partial class add_announcement : System.Web.UI.Page
    {
        BaseClass baseclass1 = new BaseClass();
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
         protected void gg_submit_Click(object sender, EventArgs e)
        {
             string title = gg_title.Text.ToString().Trim();
             string content = gg_content.Text.ToString().Trim();
             //DateTime date = DateTime.Now.ToString();
             DateTime date = DateTime.Now;
             string id = date.ToString().Substring(0,16);
             string gg_sql = "INSERT INTO announcement (announcement_id,announcement_title,announcement_content,announcement_date) VALUES ( '" + id + "','" + title + "','" + content + "','" + date + "')";
             baseclass1.execsql(gg_sql);
             Response.Redirect("indexa.aspx?admin=" + admin_id);
        }
    }
}