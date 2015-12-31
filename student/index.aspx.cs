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
            if (Session[id] != null)
            {
                //Response.Write("请登录");
            }
            else if (Session[id] == null)
            {

                string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn = new MySqlConnection(connection);
                string sqlQuery = "SELECT * FROM  course";//HERE good_name  like '" + id + "%'";
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
                    Response.Write(course_rest);
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
                        tc4.Text = "";
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
            }
        }
    }
}