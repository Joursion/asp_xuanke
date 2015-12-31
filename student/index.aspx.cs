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
            if(Session[id] == null)
            {
                Response.Write("请登录");
            }
            else
            {
                string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection conn = new MySqlConnection(connection);
                string sqlQuery = "SELECT * FROM  course";//HERE good_name  like '" + id + "%'";
                MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
                conn.Open();
                MySqlDataReader dr = comm.ExecuteReader();
                int btn_cnt = 0;
                //读取 商品信息
                while (dr.Read())
                {
                    btn_cnt++;
                    TableRow tr = new TableRow();
                    TableCell tc1 = new TableCell();
                    TableCell tc2 = new TableCell();
                    TableCell tc3 = new TableCell();
                    TableCell tc4 = new TableCell();
                    tc1.Text = dr.GetString(1);
                    tc2.Text = dr.GetString(2);
                    tc3.Text = dr.GetString(4);
                    HyperLink hl = new HyperLink();
                    //构建单元格中的内容
                    hl.NavigateUrl = "select.aspx?stu=" + id + "&course=" + dr.GetString(0);
                    hl.Text = "选课";
                    tc4.Controls.Add(hl);
                    //Button btn = new Button();
                    //btn.ID = "select_btn" + btn_cnt;
                    //btn.Click += new EventHandler(select.aspx);
                    //tc4.Controls.Add(btn);

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