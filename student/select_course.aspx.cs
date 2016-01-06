using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using student;
using System.Data;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class select_course : System.Web.UI.Page
    {
        BaseClass baseclass1 = new BaseClass();
        string student_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["stu"] != null)
            {
                student_id = Request.QueryString["stu"];
            }
            if (!Page.IsPostBack)
                getGoods();
        }

        private void getGoods()
        {
            string strsql = "SELECT * from course where course.course_id not in ( select course.course_id from course, select_course where course.course_id = select_course.course_id and select_course.student_id = " + student_id + ")";
            DataTable dt = baseclass1.ReadTable(strsql);
            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = dt.DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 5;
            int curpage = Convert.ToInt32(this.LabelPage.Text);
            objPds.CurrentPageIndex = curpage - 1;
            if (objPds.CurrentPageIndex < 0)
            {
                objPds.CurrentPageIndex = 0;
            }
            if (objPds.PageCount == 1)
            {
                LinkButtonPrev.Enabled = false;
                LinkButtonNext.Enabled = false;
            }
            else
            {
                if (curpage == 1)
                {
                    LinkButtonPrev.Enabled = false;
                    LinkButtonNext.Enabled = true;
                }
                if (curpage == objPds.PageCount)
                {
                    LinkButtonNext.Enabled = false;
                    LinkButtonPrev.Enabled = true;
                }
            }

            this.LableTotalPage.Text = Convert.ToString(objPds.PageCount);
            //  GridView1.DataNavigateUrlFields = "";
            GridView1.DataSource = objPds;
            GridView1.DataBind();
        }



        protected void LinkButtonFirst_Click(object sender, EventArgs e)
        {
            this.LabelPage.Text = "1";
            getGoods();
        }

        protected void LinkButtonPrev_Click(object sender, EventArgs e)
        {
            this.LabelPage.Text = Convert.ToString(int.Parse(this.LabelPage.Text) - 1);
            getGoods();
        }

        protected void LinkButtonNext_Click(object sender, EventArgs e)
        {
            this.LabelPage.Text = Convert.ToString(int.Parse(this.LabelPage.Text) + 1);
            getGoods();
        }

        protected void LinkButtonLast_Click(object sender, EventArgs e)
        {
            this.LabelPage.Text = this.LabelPage.Text;
            getGoods();
        }

        //protected void Button_select_Click(object sender, EventArgs e)
        //{
        //    Button btn = sender as Button;
        //    GridViewRow row = btn.Parent.Parent as GridViewRow;
        //    string a = row.Cells[0].Text;//获得第一个单元格的值   
        //    string b = row.Cells[1].ToString();
        //   // int c = this.GridView1.DataKeys[row.DataItemIndex].Value[0];
        //    Response.Write(a + b );  
        //}
        protected void Button_select_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = btn.Parent.Parent as GridViewRow;
            string tmp_course_id = row.Cells[0].Text;//获得第一个单元格的值   
            string tmp_rest = row.Cells[3].Text;
            if (tmp_rest == "0")
            {
                Response.Write("<script>alert('该课程人数已满！');</script>");
            }
            else
            {
                string init_connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
                MySqlConnection init_conn = new MySqlConnection(init_connection);
                string init_sqlQuery = "SELECT * FROM select_course WHERE course_id  = " + tmp_course_id;
                MySqlCommand init_comm = new MySqlCommand(init_sqlQuery, init_conn);
                init_conn.Open();
                MySqlDataReader init_dr = init_comm.ExecuteReader();
                string tmp_student_id = "";
                while (init_dr.Read())
                {
                    tmp_student_id = init_dr.GetString(2);
                }
                if (tmp_student_id == student_id)
                {
                    Response.Write("你已经选择此门课程了");
                    init_conn.Close();

                }
                else
                {
                    string insert_sql = "INSERT INTO select_course (course_id,student_id,grade) VALUES ( '" + tmp_course_id + "','" + student_id + "','" + 0 + "')";
                    baseclass1.execsql(insert_sql);
                    Response.Redirect("select_course.aspx?stu=" + student_id);
                }

            }
        }
    }
}