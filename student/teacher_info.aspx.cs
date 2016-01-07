using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
namespace student
{
    public partial class teacher_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string teacher_id = "10001";

            string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
            MySqlConnection conn = new MySqlConnection(connection);
            string sql_1 = "SELECT * FROM teachers WHERE teacher_id  = " + teacher_id;
            MySqlCommand cmd_1 = new MySqlCommand(sql_1, conn);
            conn.Open();
            MySqlDataReader dr = cmd_1.ExecuteReader();
            //TextBox 1:工号 2:姓名 3:学院 4:职称 5:入职时间 8:联系方式 6:身份证号 7:家庭地址
            //sql 0:id 1:name 2:pwd 3:rank 4:in_time 5:imageUrl 6:address 7:tel 8:ic 8:xueyuan
            if (!IsPostBack)
            {
                while (dr.Read())
                {
                    TextBox1.Text = dr[0].ToString();
                    TextBox2.Text = dr[1].ToString();
                    TextBox3.Text = dr[8].ToString();
                  
                    TextBox4.Text = dr[3].ToString();
                    TextBox7.Text = dr[6].ToString();
                    TextBox5.Text = dr[4].ToString();
                    TextBox6.Text = dr[9].ToString();
                    Image1.ImageUrl = dr[5].ToString();
                }
            }
            dr.Close();
            conn.Close();
            /*MySqlCommand cmd = new MySqlCommand("select course_id, course_name from course where course_id = (select course_id from select_course where student_id='100001')", conn);
            string sql_2 = "select course_id from select_course where student_id=" + student_id;
            MySqlCommand cmd_2 = new MySqlCommand(sql_2, conn);
            MySqlDataReader dr_1 = cmd_2.ExecuteReader();
            while (dr_1.Read())
            {
                TextBox9.Text = dr_1.GetString(0);
            }
             */
            string sql_3 = "select course_name, course_id, course_grade from course select_course where course_id in (select course_id from select_course where teacher_id=" + teacher_id + ")";
            MySqlConnection conn_3 = new MySqlConnection(connection);
            MySqlCommand comm_3 = new MySqlCommand(sql_3, conn_3);
            conn_3.Open();
            MySqlDataReader dr_3 = comm_3.ExecuteReader();

            while (dr_3.Read())
            {
                TableRow tr = new TableRow();
                TableCell tc1 = new TableCell();
                TableCell tc2 = new TableCell();
                TableCell tc3 = new TableCell();

                tc1.Text = dr_3.GetString(1);
                tc2.Text = dr_3.GetString(0);
                tc3.Text = dr_3.GetString(2);

                //将单元格添加到行中
                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);
                tr.Cells.Add(tc3);

                list.Rows.Add(tr);
            }
            conn.Close();
        }

        protected void img_commit_Click(object sender, EventArgs e)
        {
            /* string student_id = "100001";
             string connection = "server=localhost;user id=root;password=mysql_lxwen;database=collect_course; pooling=true;";
             MySqlConnection conn = new MySqlConnection(connection);
             string sqlQuery_1 = "Update students set tel = '"+TextBox6.Text+"' Where student_id = " + student_id;
                 MySqlCommand comm = new MySqlCommand(sqlQuery_1, conn);
                 conn.Open();
                 comm.ExecuteNonQuery();
                 conn.Close();
             */
        }

        protected void save_Click(object sender, EventArgs e)
        {

        }

    }
}