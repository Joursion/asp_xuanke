using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class add_course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_confirm_Click(object sender, EventArgs e)
        {
            // 获取填写信息
            string course_id = Add_course_id.Text.ToString().Trim();
            string course_name = Add_course_name.Text.ToString().Trim();
            // string course_teacher = Add_course_teacher.Text.ToString().Trim();
            string tmp_course_grade = Add_course_grade.Text.ToString().Trim();
            int course_grade = Convert.ToInt32(tmp_course_grade);
            string tmp_course_class = Add_course_grade.Text.ToString().Trim();
            string tmp_course_rest = Add_course_rest.Text.ToString().Trim();
            int course_rest = Convert.ToInt32(tmp_course_rest);
            string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
            MySqlConnection conn = new MySqlConnection(connection);

            //string sql = "INSERT INTO course (course_id,course_name,course_grade,course_class) VALUES ('''+       ?course_id + ''',''' + ?course_name + ''','''+ ?course_teacher+ ''',''' + ?couse_grade + ''')";
            string sql = "INSERT INTO course (course_id,course_name,course_grade,course_class,course_rest) VALUES ( '" + course_id + "','" + course_name + "','" + course_grade + "','" + tmp_course_class + "','" + course_rest + "')";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Add_success.Text = "添加成功！";
        }
    }
}