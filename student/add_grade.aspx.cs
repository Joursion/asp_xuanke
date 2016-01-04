using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class add_grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = "";
            if (Request.QueryString["teacher"] != null)
            {
                id = Request.QueryString["teacher"];
            }

            // 测试，先不验证登录
            //if (Session[id] == null)
            //{
            //    Response.Write("请登录");
            //}

            string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
            MySqlConnection conn = new MySqlConnection(connection);
            string sqlQuery = "SELECT  course.course_name ,  select_course.student_id from  course, select_course where select_course.course_id in (select course.course_id from course where course.course_teacher = " + id + ")  and select_course.student_id = " + "group by course.course_name";
            //string sqlQuery = "SELECT * from course where course.course_id not in ( select course.course_id from course, select_course where course.course_id = select_course.course_id and select_course.student_id = " + id + ")";
            MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                TableRow tr = new TableRow();
                TableCell tc1 = new TableCell();
                TableCell tc2 = new TableCell();
               
                tc1.Text = dr.GetString(1);
                tc2.Text = dr.GetString(0);
              
                //将单元格添加到行中
                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);

                Add_grade_list.Rows.Add(tr);
            }
            dr.Close();
            conn.Close();
        }
    }
}