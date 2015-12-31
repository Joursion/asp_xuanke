<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="student.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="style/css/index.css" />
</head>
<body>
    <form id="form1" runat="server">

        <div id="show_name"> 课程名称</div>
         <div id="show_grade">课程学分</div>
         <div id="show_rest">课程剩余数</div>

          <asp:table  ID="Course_List" runat="server" 
                 Height="200px" Width="794px">
        
                <asp:TableRow ID="Good" runat="server"  >
                 
                </asp:TableRow>
         <asp:TableRow ID="TableRow1" runat="server"  >
            <%-- <asp:Image ID="View_img" runat="server"></asp:Image>--%>
                </asp:TableRow>
               <asp:TableRow ID="Select_course_name" runat="server" >
                 
                </asp:TableRow>
         <asp:TableRow ID="Select_course_grade" runat="server"  >
                
                </asp:TableRow>
         <asp:TableRow ID="Select_course_rest" runat="server"  >
                 
                </asp:TableRow>
              <asp:TableRow ID="Select_select" runat="server" >
                 
                </asp:TableRow>
            </asp:table>
    </form>
</body>
</html>
