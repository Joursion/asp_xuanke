using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class change_psw : System.Web.UI.Page
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
                Response.Redirect("404.html");
                // Response.Writeggvv(student_id);
            }
            if (Session[student_id] == null)
            {
                Response.Write("请登录");
            }
            else
            {
                Response.Write("faljf");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string student_id = "100001";
            if (Request.QueryString["stu"] != null)
            {
                student_id = Request.QueryString["stu"];
            }
            else
            {
                Response.Redirect("404.html");
                // Response.Writeggvv(student_id);
            }
            if (Session[student_id] == null)
            {
                Response.Write("请登录");
            }
            else
            {
                string password = "";
                string change_pwd = "";
                string connection_1 = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn_1 = new MySqlConnection(connection_1);
                string sql_2 = "SELECT student_pwd FROM students WHERE student_id  = " + student_id;
                MySqlCommand cmd_1 = new MySqlCommand(sql_2, conn_1);
                conn_1.Open();
                MySqlDataReader dr_1 = cmd_1.ExecuteReader();
                try
                {
                    while(dr_1.Read())
                    {
                        password = dr_1[0].ToString();
                        if (password != TextBox1.Text)
                        {
                            Response.Write("原密码错误，请重新输入！");
                        }
                        else if (password == TextBox2.Text)
                        {
                            Response.Write("与原密码相同，退出修改或者重新输入密码");
                        }
                        else if (TextBox2.Text == TextBox3.Text)
                        {
                            change_pwd = TextBox3.Text;
                        }
                        else
                        {
                            Response.Write("两次输入密码不同");
                            
                        }
                    }
                    
                }
                
                catch
                {
                    Response.Write("错误！！！");
                }
                conn_1.Close();
                if(change_pwd != null)
                {
                    string connection_2 = "server=localhost;user id=root;password=mysql_lxwen;database=collect_course; pooling=true;";
                    MySqlConnection conn_2 = new MySqlConnection(connection_2);
                    string sql_3 = "UPDATE students set student_pwd ='" + TextBox3.Text + "' WHERE student_id  = " + student_id;
                    MySqlCommand cmd_2 = new MySqlCommand(sql_3, conn_2);
                    conn_2.Open();
                    cmd_2.ExecuteNonQuery();
                    conn_2.Close();
                    Response.Write("修改成功");
                }
            
            }
        }
    }
}
