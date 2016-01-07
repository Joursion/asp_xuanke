using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class Teacher : System.Web.UI.MasterPage
    {

        string teacher_id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["teacher"] != null)
            {
                teacher_id = Request.QueryString["teacher"];
            }

            //测试，先不验证登录
            if (Session[teacher_id] == null)
            {
                Response.Redirect("login.aspx");
            }

            if (Session[teacher_id] != null)
            {
                string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn = new MySqlConnection(connection);
                //string sqlQuery = "SELECT * FROM  course";//HERE good_name  like '" + id + "%'";
                string sqlQuery = "SELECT teacher_name from teachers where student_id = " + teacher_id;
                MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    taecher_show_name.Text = "欢迎您！ " + dr.GetString(0);
                }
                conn.Close();
            }
        }

        protected void teacher_log_out_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void teacher_add_course_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_course.aspx?teacher=" + teacher_id);
        }

        protected void teacher_add_grade_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_grade.aspx?teacher=" + teacher_id);
        }
    }
}