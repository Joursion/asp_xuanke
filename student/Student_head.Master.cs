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

             //测试，先不验证登录
            if (Session[id] == null)
            {
                Response.Redirect("login.aspx");
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
                    head_show_name.Text = "欢迎您！ "+ dr.GetString(0); 
                }
                conn.Close();
            }
        }

        protected void head_for_select_course_Click(object sender, EventArgs e)
        {
            Response.Redirect("select_course.aspx?stu=" + id);
        }

        protected void head_for_show_my_course_Click(object sender, EventArgs e)
        {
            Response.Redirect("show_my_course.aspx?stu=" + id);
        }

        protected void head_for_show_my_course_grade_Click(object sender, EventArgs e)
        {
            Response.Redirect("show_my_course_grade.aspx?stu=" + id);
        }

        protected void head_log_out_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void head_for_show_my_Click(object sender, EventArgs e)
        {
            Response.Redirect("student_info.aspx?stu=" + id);
        }

        protected void head_for_pingjiao_Click(object sender, EventArgs e)
        {
            Response.Redirect("evaluate.aspx?stu=" + id);
        }
    }
}