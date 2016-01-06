using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class Student_head : System.Web.UI.MasterPage
    {
        string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
           // string id = "";
            if (Request.QueryString["stu"] != null)
            {
                id = Request.QueryString["stu"];
            }

            // 测试，先不验证登录
            if (Session[id] == null)
            {
                Response.Write("请登录");
            }

            if(Session[id] != null)
            {
                string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn = new MySqlConnection(connection);
                //string sqlQuery = "SELECT * FROM  course";//HERE good_name  like '" + id + "%'";
                string sqlQuery = "SELECT student_name from students where student_id = " + id;
                MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                while(dr.Read())
                {
                    head_show_name.Text = dr.GetString(0);
                }
                conn.Close();
            }
        }

        protected void head_for_select_Click(object sender, EventArgs e)
        {
            Response.Redirect("test_for_student_head.aspx?stu=" + id);
        }

        protected void head_for_query_Click(object sender, EventArgs e)
        {

        }

        protected void head_for_quit_Click(object sender, EventArgs e)
        {

        }
    }
}