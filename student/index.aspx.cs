using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class index : System.Web.UI.Page
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
                Response.Redirect("login.aspx");
            }
            else 
            {
                string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn = new MySqlConnection(connection);
                //string sqlQuery = "SELECT * FROM  course";//HERE good_name  like '" + id + "%'";
                string sqlQuery = "SELECT * from course where course.course_id not in ( select course.course_id from course, select_course where course.course_id = select_course.course_id and select_course.student_id = " + id + ")";
                MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    TableRow tr = new TableRow();
                    TableCell tc1 = new TableCell();
                    TableCell tc2 = new TableCell();
                    TableCell tc3 = new TableCell();
                    TableCell tc4 = new TableCell();
                    tc1.Text = dr.GetString(1);
                    tc2.Text = dr.GetString(2);
                    int course_rest = dr.GetInt32(4);
                    tc3.Text = course_rest.ToString();//dr.GetString(4);
                    if (course_rest > 0)
                    {
                        HyperLink hl = new HyperLink();
                        //构建单元格中的内容
                        hl.NavigateUrl = "select.aspx?stu=" + id + "&course=" + dr.GetString(0);
                        hl.Text = "选课";
                        tc4.Controls.Add(hl);

                    }
                    else
                    {
                        tc4.Text = "已满";
                    }
                    //将单元格添加到行中
                    tr.Cells.Add(tc1);
                    tr.Cells.Add(tc2);
                    tr.Cells.Add(tc3);
                    tr.Cells.Add(tc4);
                    Course_List.Rows.Add(tr);
                }
                dr.Close();
                conn.Close();



                // 显示已经选修的课程
                string had_select_connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection had_select_conn = new MySqlConnection(had_select_connection);
                string had_select_sqlQuery = "SELECT course.course_name FROM  course ,select_course  WHERE  select_course.student_id =" + id + " and select_course.course_id = course.course_id";
                MySqlCommand had_select_comm = new MySqlCommand(had_select_sqlQuery, had_select_conn);
                had_select_conn.Open();
                MySqlDataReader had_select_dr = had_select_comm.ExecuteReader();
                while(had_select_dr.Read())
                {
                    TableRow tr = new TableRow();
                    TableCell tc1 = new TableCell();
                    TableCell tc2 = new TableCell();
                    tc1.Text = had_select_dr.GetString(0);
                    HyperLink h2 = new HyperLink();
                    //构建单元格中的内容
                    h2.NavigateUrl = "select.aspx?stu=" + id + "&course=" + had_select_dr.GetString(0);
                    h2.Text = "我要退选";
                    tc2.Controls.Add(h2);
                    tr.Cells.Add(tc1);
                    tr.Cells.Add(tc2);
                    Course_had_select.Rows.Add(tr);
                }
                had_select_conn.Close();
            }
        }

        protected void index_select_Click(object sender, EventArgs e)
        {
            string id = "";
            if (Request.QueryString["stu"] != null)
            {
                id = Request.QueryString["stu"];
            }

            // 测试，先不验证登录
            if (Session[id] == null)
            {
                Response.Redirect("login.aspx");
            }

            Response.Redirect("index.aspx?stu=" + id);
        }

        protected void index_show_Click(object sender, EventArgs e)
        {
            string id = "";
            if (Request.QueryString["stu"] != null)
            {
                id = Request.QueryString["stu"];
            }

            // 测试，先不验证登录
            if (Session[id] == null)
            {
                Response.Redirect("login.aspx");
            }

            Response.Redirect("show_course.aspx?stu=" + id);
        }

        protected void index_query_Click(object sender, EventArgs e)
        {
            string id = "";
            if (Request.QueryString["stu"] != null)
            {
                id = Request.QueryString["stu"];
            }

            // 测试，先不验证登录
            if (Session[id] == null)
            {
                Response.Redirect("login.aspx");
            }

            Response.Redirect("query_grade.aspx?stu=" + id);
        }
    }
}