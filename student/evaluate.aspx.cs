using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Student
{
    public partial class evaluate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string courseid = select_course.SelectedValue;         //读取当前课程的id
            string connection = "server = localhost; user id = root; password = 7723; database = collect_course; pooling = true;";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd1 = new MySqlCommand();
            MySqlCommand cmd2 = new MySqlCommand();
            MySqlCommand cmd3 = new MySqlCommand();
            MySqlCommand cmd4 = new MySqlCommand();
            MySqlCommand cmd5 = new MySqlCommand();
            MySqlCommand cmd6 = new MySqlCommand();
            cmd1.Connection = cmd2.Connection = cmd3.Connection = cmd4.Connection = cmd5.Connection = cmd6.Connection = conn;
            conn.Open();
            cmd1.CommandText = "select course_id, course_name, teacher_name from evaluate where course_id = "+ courseid +" LIMIT 1";
            MySqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                TableRow tr = new TableRow();
                TableCell tc1 = new TableCell();
                TableCell tc2 = new TableCell();
                TableCell tc3 = new TableCell();
                tc1.Text = dr.GetString(0);
                tc2.Text = dr.GetString(1);
                tc3.Text = dr.GetString(2);
                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);
                tr.Cells.Add(tc3);
                evaluate_level.Rows.Add(tr);
            };
            
            conn.Close();
            conn.Open();
            cmd2.CommandText = "update evaluate set level1 = '" + level1.SelectedValue + "'" + "where course_id = " + courseid;
            cmd2.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            cmd3.CommandText = "update evaluate set level2 = '" + level2.SelectedValue + "'" + "where course_id = " + courseid;
            cmd3.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            cmd4.CommandText = "update evaluate set level3 = '" + level3.SelectedValue + "'" + "where course_id = " + courseid;
            cmd4.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            cmd5.CommandText = "update evaluate set level4 = '" + level4.SelectedValue + "'" + "where course_id = " + courseid;
            cmd5.ExecuteNonQuery();
            cmd1 = cmd2 = cmd3 = cmd4 = cmd5 = null;
            conn.Close();
            //int a, b, c, d;
            //a = b = c = d = 0;
            //if (level1.Text == "优秀" || level2.Text == "优秀" || level3.Text == "优秀" || level4.Text == "优秀")
            //    a += 1;
            //if (level1.Text == "良好" || level2.Text == "良好" || level3.Text == "良好" || level4.Text == "良好")
            //    b += 1;
            //if (level1.Text == "中等" || level2.Text == "中等" || level3.Text == "中等" || level4.Text == "中等")
            //    c += 1;
            //if (level1.Text == "差" || level2.Text == "差" || level3.Text == "差" || level4.Text == "差")
            //   d += 1;
            //string level = null;
            //if (a >= b && a >= c && a >= d)
            //    level = "优秀";
            //else if (b>a && b>=c && b>=d)
            //    level = "良好";
            //else if (c > a && c>b && c>=d)
            //    level = "中等";
            //else if (d > a && d > b && d > c)
            //    level = "差";
            //a = b = c = d = 0;
            //conn.Open();
            //cmd6.CommandText = "update evaluate set level = '" + level + "'" + "where course_id = " + courseid;
            //cmd6.ExecuteNonQuery();
            //cmd1 = cmd2 = cmd3 = cmd4 = cmd5 = cmd6 = null;
            //conn.Close();
        }
    }
}