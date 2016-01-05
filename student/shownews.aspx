<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shownews.aspx.cs" Inherits="student.shownews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" GridLineS="None" Height="121px" PageSize="6" ShowHeader="false" Width="452px"> 
            <Columns>
                
                <asp:BoundField DataField="course_id" HeaderText="课程ID" />
                <asp:BoundField DataField="course_name" HeaderText="课程名称" />
                <asp:BoundField DataField="course_grade" HeaderText="课程学分" />
                <asp:BoundField DataField="course_rest" HeaderText="课程余量" />
                <asp:BoundField DataField="course_teacher" HeaderText="认可教师" />
                <asp:TemplateField>   
                   <ItemTemplate>   
                           <asp:Button    ID="Button_select"    runat="server"    OnClick="Button_select_Click"   Text="Button"    />   
                   </ItemTemplate>   
                </asp:TemplateField>   
                <%-- <ItemTemplate>
                <asp:Button  ID="course_select" runat="server" Text='选课' />
                </ItemTemplate>--%>
               <%-- <asp:HyperLinkField DataNavigateUrlFields="'Request.QueryString["stu"]' ,course_id" DataNavigateUrlFormatString="shownew.aspx?id={0}&ds={1}" DataTextField="course_id" DataTextFormatString="&#183;{0}" HeaderText="新闻标题" >
                  
                </asp:HyperLinkField>--%>
            </Columns>
        </asp:GridView><br />
        当前页码为:[<asp:Label ID="LabelPage" runat="server" Text="1"></asp:Label>]&nbsp;总页码为:[<asp:Label ID="LableTotalPage" runat="server" Text=""></asp:Label>]
        <asp:LinkButton ID ="LinkButtonFirst" runat="server" OnClick="LinkButtonFirst_Click">首页</asp:LinkButton>&nbsp;&nbsp;
        <asp:LinkButton ID ="LinkButtonPrev" runat="server" OnClick="LinkButtonPrev_Click">上一页</asp:LinkButton>&nbsp;&nbsp;
        <asp:LinkButton ID ="LinkButtonNext" runat="server" OnClick="LinkButtonNext_Click">下一页</asp:LinkButton>&nbsp;&nbsp;
          <asp:LinkButton ID ="LinkButtonLast" runat="server" OnClick="LinkButtonLast_Click">末页</asp:LinkButton>&nbsp;&nbsp;
    </div>
    </form>
</body>
</html>
