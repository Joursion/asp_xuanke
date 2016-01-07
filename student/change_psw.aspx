<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="change_psw.aspx.cs" Inherits="student.change_psw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="style/css/c_p.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 338px">
        <div class="box1">

            <asp:Label ID="Label1" runat="server" Text="原先密码"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="新设密码"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="确认密码"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>

            <br />

            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="修改" />

        </div>
    </div>
    </form>
</body>
</html>
