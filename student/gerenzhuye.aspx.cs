using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class gerenzhuye : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stu_id = "13401010409";
            string connection = "server=localhost;user id=root;password=mysql_lxwen;database=collect_course; pooling=true;";
            MySqlConnection conn = new MySqlConnection(connection);
            string sqlQuery = "SELECT * FROM students WHERE student_id  = " + stu_id;
            MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                
                TextBox1.Text = dr.GetString(1);
            }

        }
    }
}