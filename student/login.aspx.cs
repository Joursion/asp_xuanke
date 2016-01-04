using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login_login_Click(object sender, EventArgs e)
        {
            string userName = Login_id.Text.ToString().Trim();
            string userPwd = Login_pwd.Text.ToString().Trim();
             Session[userName] = false;     
            if (userName == "" && userPwd == "")
            {
                wrong_message.Visible = true;
                errmsg.Text = "请输入账户名和密码";
            }
            else if (userName == "")
            {
                wrong_message.Visible = true;
                errmsg.Text = "请输入账户名";
            }
            else if (userPwd == "")
            {
                wrong_message.Visible = true;
                errmsg.Text = "请输入密码";
            }
            //用户名和密码错误 提示(你输入的密码和账户名不匹配，是否忘记密码或忘记会员名)
            if (userName != "" && userPwd != "")
            {
                string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn = new MySqlConnection(connection);
                string sqlQuery = "SELECT * FROM students WHERE student_id  = " + userName;
                MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                string tmp_psw = "";
                while (dr.Read())
                {
                    tmp_psw = dr.GetString(2);
                }
                if (tmp_psw == userPwd)
                {
                    Session[userName] = true;
                    Response.Redirect("index.aspx" + "?stu=" + userName + "");
                }
                else
                {
                    wrong_message.Visible = true;
                    errmsg.Text = "用户名和密码不匹配";
                }

                conn.Close();
            }
        }

        protected void Login_login_admin_Click(object sender, EventArgs e)
        {
            string userName = Login_id.Text.ToString().Trim();
            string userPwd = Login_pwd.Text.ToString().Trim();

            if (userName == "" && userPwd == "")
            {
                wrong_message.Visible = true;
                errmsg.Text = "请输入账户名和密码";
            }
            else if (userName == "")
            {
                wrong_message.Visible = true;
                errmsg.Text = "请输入账户名";
            }
            else if (userPwd == "")
            {
                wrong_message.Visible = true;
                errmsg.Text = "请输入密码";
            }
            //用户名和密码错误 提示(你输入的密码和账户名不匹配，是否忘记密码或忘记会员名)
            if (userName != "" && userPwd != "")
            {
                string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn = new MySqlConnection(connection);
                string sqlQuery = "SELECT * FROM teachers WHERE teacher_id  = " + userName;
                MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                string tmp_psw = "";
                while (dr.Read())
                {
                    tmp_psw = dr.GetString(2);
                }
                if (tmp_psw == userPwd)
                {
                    Session[userName] = true;
                    Response.Redirect("index.aspx" + "?stu=" + userName +"");
                }
                else
                {
                    wrong_message.Visible = true;
                    errmsg.Text = "用户名和密码不匹配";
                }

                conn.Close();
            }
        }
    }
}