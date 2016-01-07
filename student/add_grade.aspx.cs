using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class add_grade : System.Web.UI.Page
    {
        string teacher_id = "";
        BaseClass baseclass1 = new BaseClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            teacher_id = Request.QueryString["teacher"];
            if (!Page.IsPostBack)
                getCourses();
        }

        private void getCourses()
        {
            string strsql = "SELECT  course.course_name ,  course.course_id, students.student_id, students.student_name from  course, select_course, students where select_course.course_id in (select course.course_id from course where course.course_teacher = " + teacher_id + ") and select_course.course_id = course.course_id and select_course.student_id = students.student_id ";
            DataTable dt = baseclass1.ReadTable(strsql);
            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = dt.DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 4;
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
                else if (curpage == objPds.PageCount)
                {
                    LinkButtonNext.Enabled = false;
                    LinkButtonPrev.Enabled = true;
                }
                else
                {
                    LinkButtonNext.Enabled = true;
                    LinkButtonPrev.Enabled = true;
                }
            }

            this.LableTotalPage.Text = Convert.ToString(objPds.PageCount);
            //  GridView1.DataNavigateUrlFields = "";
            GridView3.DataSource = objPds;
            GridView3.DataBind();
        }



        protected void LinkButtonFirst_Click(object sender, EventArgs e)
        {
            this.LabelPage.Text = "1";
            getCourses();
        }

        protected void LinkButtonPrev_Click(object sender, EventArgs e)
        {
            this.LabelPage.Text = Convert.ToString(int.Parse(this.LabelPage.Text) - 1);
            getCourses();
        }

        protected void LinkButtonNext_Click(object sender, EventArgs e)
        {
            this.LabelPage.Text = Convert.ToString(int.Parse(this.LabelPage.Text) + 1);
            getCourses();
        }

        protected void LinkButtonLast_Click(object sender, EventArgs e)
        {
            this.LabelPage.Text = this.LabelPage.Text;
            getCourses();
        }

        protected void Button_save_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = btn.Parent.Parent as GridViewRow;
            string tmp_course_id = row.Cells[0].Text;//获得第一个单元格的值   
            string tmp_student_id = row.Cells[2].Text;
          //  TextBox ttt = (TextBox) row.Cells[3].Controls[0];
           // string tmp_rest = row.Cells[2].Text;
            //int tmp_rest = row.RowIndex;
            //string input_id = "ContentPlaceHolder1_GridView3_Lable_grade_edit_" + tmp_rest;
        //    ContentPlaceHolder1_GridView3_Lable_grade_edit_0.
          //  string sb =  GridView3.DataKeys[e.RowIndex].Value.ToString();
         
            TextBox txt = (TextBox) row.Cells[3].FindControl("Lable_grade_edit");
            string tmp_grade = txt.Text.ToString();
            int grade = Convert.ToInt32(tmp_grade);
            string connection = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
            MySqlConnection conn = new MySqlConnection(connection);

            //string sql = "INSERT INTO course (course_id,course_name,course_grade,course_class) VALUES ('''+       ?course_id + ''',''' + ?course_name + ''','''+ ?course_teacher+ ''',''' + ?couse_grade + ''')";
            //string sql = "INSERT INTO select_course (course_id,student_id, grade) VALUES ( '" + tmp_course_id + "','" + tmp_student_id + "','" + grade + "')";
            string sql = "UPDATE select_course set grade = " + grade + " where course_id = " + tmp_course_id + " and student_id = " + tmp_student_id;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            txt.Enabled = false;
        }
        protected void Button_edit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow row = btn.Parent.Parent as GridViewRow;
            TextBox txt = (TextBox)row.Cells[3].FindControl("Lable_grade_edit");
            txt.Enabled = true;
        }
    }
}