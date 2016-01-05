<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indext.aspx.cs" Inherits="student.indext" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="当前选课情况" />
        <asp:Button ID="Button2" runat="server" Text="课程成绩录入" />
        <asp:Button ID="Button3" runat="server" Text="课程录入" />
    </div>
        <asp:DataPager ID="DataPager1" runat="server"></asp:DataPager>
    </form>
</body>
</html>
