using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class query_grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = "";
            if (Request.QueryString["stu"] != null)
            {
                id = Request.QueryString["stu"];
            }

            // 测试，先不验证登录
            if (Session[id] == null)
            {
                Response.Write("请登录");
            }
            else
            {
                string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn = new MySqlConnection(connection);
                string sqlQuery = "SELECT course.course_name, select_course.grade from course, select_course where select_course.course_id = course.course_id and select_course.student_id = " + id;
                MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    TableRow tr = new TableRow();
                    TableCell tc1 = new TableCell();
                    TableCell tc2 = new TableCell();
                    tc1.Text = dr.GetString(0);
                    tc2.Text = dr.GetString(1);
                    tr.Cells.Add(tc1);
                    tr.Cells.Add(tc2);
                    Show_query_grade.Rows.Add(tr);
                }
                dr.Close();
                conn.Close();
            }
        }
    }
}