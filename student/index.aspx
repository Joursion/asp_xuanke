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
         <div id="show_grade">学分</div>
         <div id="show_rest">余量</div>

          <asp:table  ID="Course_List" runat="server" 
                 Height="200px" Width="1000px">
               <asp:TableRow ID="Select_course_name" runat="server"  Width="200px">
                  </asp:TableRow>

               <asp:TableRow ID="Select_course_grade" runat="server" Width="100px">
                 </asp:TableRow>

              <asp:TableRow ID="Select_course_rest" runat="server" Width="100px"  >
                 </asp:TableRow>

              <asp:TableRow ID="Select_select" runat="server" >
                </asp:TableRow>

            </asp:table>
        <asp:Label ID="show_course_had_select" runat="server" Text="已经选修的课程"></asp:Label>
        <asp:table  ID="Course_had_select" runat="server" 
                 Height="200px" Width="1000px" >

               <asp:TableRow ID="Course_had_name" runat="server"  Width="200px">
                  </asp:TableRow>

              <asp:TableRow ID="Course_choose_to_quit" runat="server" >
                </asp:TableRow>

         </asp:table>
    </form>
</body>
</html>
