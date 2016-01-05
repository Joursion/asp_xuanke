<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="query_grade.aspx.cs" Inherits="student.query_grade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="width: 691px; margin-left: 176px">
    <form id="form1" runat="server">
    <div>
    <asp:table  ID="Show_query_grade" runat="server" 
                 Height="200px" Width="452px">
               <asp:TableRow ID="query_grade_name" runat="server"  Width="100px">
                  </asp:TableRow>

               <asp:TableRow ID="query_grade_grade" runat="server" Width="100px">
                 </asp:TableRow>
            </asp:table>
    </div>
    </form>
</body>
</html>
