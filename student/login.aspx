<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="student.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="style/css/login.css" />
</head>
<body>
    <form id="form1" runat="server">
         <div id="wrong_message" class="login-msg error" runat="server" visible="false">            
            <asp:Label runat="server" ID="errmsg"  Text="ddd"></asp:Label>
         </div>
        <asp:Label ID="Login_id_edit" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="Login_id" runat="server"></asp:TextBox>
         <asp:Label ID="Login_pwd_edit" runat="server" Text="密码"></asp:Label>
        <asp:TextBox ID="Login_pwd" runat="server"  TextMode="Password"></asp:TextBox>
        <asp:Button ID="Login_login" runat="server" Text="学生登录" OnClick="Login_login_Click" />
        <asp:Button ID="Login_login_admin" runat="server" Text="管理员（教师）登录" OnClick="Login_login_admin_Click"  />
    </form>
</body>
</html>
