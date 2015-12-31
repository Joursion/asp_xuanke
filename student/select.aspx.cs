using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class select : System.Web.UI.Page
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
               // Response.Redirect("404.html");
                Response.Write(student_id);
            }
            if (Session[student_id] == null)
            {
                Response.Write("请登录");
            }
            else
            {
                string course_id = "";
                if (Request.QueryString["course"] != null)
                {
                    course_id = Request.QueryString["course"];
                }
                else
                {
                    //Response.Redirect("404.html");
                    Response.Write(course_id);
                }

                // 将选课的数据插入到select_course的表中
                string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn = new MySqlConnection(connection);

                string sql = "INSERT INTO select_course (course_id,student_id,grade) VALUES ( '" + course_id + "','" + student_id + "','" + 0 + "')";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                //将选的课程在course中，剩余量减1
                string connection2course = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn2course = new MySqlConnection(connection2course);

                string sql_ = "UPDATE course SET course_rest = course_rest - 1  where course_id = " + course_id;
                conn2course.Open();
                MySqlCommand cmd_ = new MySqlCommand(sql_, conn2course);
                cmd_.ExecuteNonQuery();
                conn2course.Close();
                Response.Write("选课成功");
            }
        }
    }
}