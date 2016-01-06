<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="select_course.aspx.cs" Inherits="student.select_course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link rel="stylesheet" href="style/css/index.css" />
    <link rel="stylesheet" href="style/css/select_.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="show_course_id"> 课程名称</div>
        <div id="show_name"> 课程名称</div>
         <div id="show_grade">课程学分</div>
         <div id="show_rest">课程余量</div>
        <div id="show_course_teacher_name"> 任课教师</div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" GridLineS="None" Height="121px" PageSize="6" ShowHeader="false" Width="80%"> 
            <Columns>
                
                <asp:BoundField DataField="course_id" HeaderText="课程ID" ItemStyle-Width="100px"  />
                <asp:BoundField DataField="course_name" HeaderText="课程名称" ItemStyle-Width="30%"  />
                <asp:BoundField DataField="course_grade" HeaderText="课程学分" ItemStyle-Width="100px" />
                <asp:BoundField DataField="course_rest" HeaderText="课程余量" ItemStyle-Width="100px"  />
                <asp:BoundField DataField="course_teacher" HeaderText="任课教师"  ItemStyle-Width="100px" />
                <asp:TemplateField>   
                   <ItemTemplate>   
                           <asp:Button  ID="Button_select"  runat="server"  OnClick="Button_select_Click"   Text="选课"    />   
                   </ItemTemplate>   
                </asp:TemplateField>   
               
               <%-- <asp:HyperLinkField DataNavigateUrlFields="'Request.QueryString["stu"]' ,course_id" DataNavigateUrlFormatString="shownew.aspx?id={0}&ds={1}" DataTextField="course_id" DataTextFormatString="&#183;{0}" HeaderText="新闻标题" >
                  
                </asp:HyperLinkField>--%>
            </Columns>
        </asp:GridView><br />
        <div id="show_page">
        当前页码为:[<asp:Label ID="LabelPage" runat="server" Text="1"></asp:Label>]&nbsp;总页码为:[<asp:Label ID="LableTotalPage" runat="server" Text=""></asp:Label>]
        <asp:LinkButton ID ="LinkButtonFirst" runat="server" OnClick="LinkButtonFirst_Click">首页</asp:LinkButton>&nbsp;
        <asp:LinkButton ID ="LinkButtonPrev" runat="server" OnClick="LinkButtonPrev_Click">上一页</asp:LinkButton>&nbsp;
        <asp:LinkButton ID ="LinkButtonNext" runat="server" OnClick="LinkButtonNext_Click">下一页</asp:LinkButton>&nbsp;
          <asp:LinkButton ID ="LinkButtonLast" runat="server" OnClick="LinkButtonLast_Click">末页</asp:LinkButton>&nbsp;
        </div>
     </div>
    </form>
</body>
</html>
