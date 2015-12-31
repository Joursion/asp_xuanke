<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stu_info.aspx.cs" Inherits="student.stu_info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
<style type="text/css">
        #bg
        {
            height: 458px;
        }
        #photo
        {
            height: 155px;
            width: 137px;
            vertical-align:top;
        }
         .box1
        {
           
            width:140px;
            height:160px;
            margin-left:7px;
            left:560px;
            top:20px;
            border: 1px solid #999999;   
      
        }
         .box2
        {
           
            width:642px;
            height:317px;
            margin-left:7px;
            left:560px;
            top:20px;
            border: 1px solid #999999;   
      
        }
        .info
        {
            width: 505px;
            height: 286px;
            margin-left: 134px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="bg" runat="server">
            <div class="login_windows" style="height:500px; top:30px;background:White;" runat="server">
                   <div class="box1" runat="server">
                        <asp:Image ID="Image9"  runat="server" Width="129px" Height="153px" ImageUrl="~/images/头像.jpg" ImageAlign="Left"/>
                          <div class="info" runat="server">
                             <br />&nbsp;&nbsp;
                             <asp:Label ID="Label1" runat="server" Text="姓名：" ></asp:Label>
                             <asp:TextBox ID="textBox1" runat="server" Height="25px" Width="124px" BorderWidth="0px"></asp:TextBox>&nbsp;&nbsp;
                             <asp:Label ID="Label2" runat="server" Text="性别：" ></asp:Label>
                             <asp:TextBox ID="textBox2" runat="server" Height="25px" Width="124px" BorderWidth="0px"></asp:TextBox>&nbsp;&nbsp;
                             <br /><br />&nbsp;&nbsp;
                             <asp:Label ID="Label3" runat="server" Text="学院："></asp:Label>
                             <asp:TextBox ID="textBox3" runat="server" Height="25px" Width="124px" BorderWidth="0px"></asp:TextBox>&nbsp;&nbsp;
                             <asp:Label ID="Label4" runat="server" Text="班级："></asp:Label>
                             <asp:TextBox ID="textBox4" runat="server" Height="25px" Width="189px" BorderWidth="0px"></asp:TextBox>
                             <br /><br />&nbsp;&nbsp;
                             <asp:Label ID="Label5" runat="server" Text="学号："></asp:Label>
                             <asp:TextBox ID="textBox5" runat="server" Height="25px" Width="355px" BorderWidth="0px"></asp:TextBox>
                             <br /><br />&nbsp;&nbsp;
                             <asp:Label ID="Label6" runat="server" Text="身份证号码："></asp:Label>
                             <asp:TextBox ID="textBox6" runat="server" Height="25px" Width="355px" BorderWidth="0px"></asp:TextBox>
                             <br /><br />&nbsp;&nbsp;
                             <asp:Label ID="Label7" runat="server" Text="家庭住址："></asp:Label>
                             <asp:TextBox ID="textBox7" runat="server" Height="25px" Width="355px" BorderWidth="0px"></asp:TextBox>&nbsp;&nbsp;
                             
                        </div>
                   </div>
              </div>
          </div>
    </form>
</body>
</html>
