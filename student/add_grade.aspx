<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_grade.aspx.cs" Inherits="student.add_grade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
          <asp:table  ID="Add_grade_list" runat="server" 
                 Height="200px" Width="1000px">
               <asp:TableRow ID="add_grade_course_name" runat="server"  Width="200px">
                  </asp:TableRow>

               <asp:TableRow ID="add_grade_course_student" runat="server" Width="100px">
                 </asp:TableRow>

              <asp:TableRow ID="add_grade_course_grade" runat="server" Width="100px"  >
                 </asp:TableRow>

              <asp:TableRow ID="add_grade_course_btn" runat="server" >
                </asp:TableRow>

            </asp:table>
    </form>
</body>
</html>
