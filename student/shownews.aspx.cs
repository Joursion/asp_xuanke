using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using student;
using System.Data;

namespace student
{
    public partial class shownews : System.Web.UI.Page
    {
        BaseClass baseclass1 = new BaseClass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                getGoods();
        }

        private void getGoods()
        {
            string strsql = "select * from course";
            DataTable dt = baseclass1.ReadTable(strsql);
            PagedDataSource objPds = new PagedDataSource();
            objPds.DataSource = dt.DefaultView;
            objPds.AllowPaging = true;
            objPds.PageSize = 5;
            int curpage = Convert.ToInt32(this.LabelPage.Text);
            objPds.CurrentPageIndex = curpage - 1;
            if(objPds.CurrentPageIndex < 0)
            {
                objPds.CurrentPageIndex = 0;
            }
            if(objPds.PageCount == 1)
            {
                LinkButtonPrev.Enabled = false;
                LinkButtonNext.Enabled = false;
            }
            else
            {
                if(curpage == 1)
                {
                    LinkButtonPrev.Enabled = false;
                    LinkButtonNext.Enabled = true;
                }
                if(curpage == objPds.PageCount)
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
            string a = row.Cells[0].Text;//获得第一个单元格的值   
            string b = row.Cells[1].ToString();
            // int c = this.GridView1.DataKeys[row.DataItemIndex].Value[0];
            Response.Write(a + b);  
        }
    }
}