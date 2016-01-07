<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_info.aspx.cs" Inherits="student.student_info" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="style/css/info.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <div>
        <div class="img">
            <asp:Image ID="Image1" runat="server" Height="152px" Width="130px" />
        </div>
        <div class="box2">
            <asp:Label ID="Label1" runat="server" Text="学号"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="Label2" runat="server" Text="姓名"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="91px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="学院"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="专业"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Width="91px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="年级"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Width="140px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label8" runat="server" Text="联系方式"></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server" Width="135px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="身份证号"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" Width="350px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="家庭地址"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" Width="350px"></asp:TextBox>
            <br />
            <!--TextBox 1:学号 2:姓名 3:学院 4:专业 5:入学时间 6:联系方式 7:身份证号 8:家庭地址-->
        </div>
        <div class="box1">
            <asp:Button ID="Button2" runat="server" Text="上传" OnClick="img_commit_Click" />
        </div>
        
        <div class="btn"> 
            <asp:Button ID="Button1" runat="server" Text="保存" OnClick="save_Click" />
        </div>
    </div>
        <div class="box3">
           <asp:table  ID="list" runat="server" 
                 Height="23px" Width="210px" style="margin-left: 0px" BorderColor="Gray">
                <asp:TableRow ID="TableRow1" runat="server" BorderStyle="Solid" BorderWidth="1" BorderColor="Gray">
                    <asp:TableCell ID="TableCell1" runat="server">
                        课号</asp:TableCell>
                    <asp:TableCell ID="TableCell2" runat="server" BorderColor="Gray">
                        课名</asp:TableCell>
                    <asp:TableCell ID="TableCell3" runat="server" BorderColor="Gray">
                        已获学分</asp:TableCell>
                </asp:TableRow>
               
               <asp:TableRow ID="course_name" runat="server"  Width="200px" BorderColor="Gray">
                  </asp:TableRow>

               <asp:TableRow ID="course_student" runat="server" Width="100px" BorderColor="Gray">
                 </asp:TableRow>

              <asp:TableRow ID="course_grade" runat="server" Width="100px" BorderColor="Gray" >
                 </asp:TableRow>

              <asp:TableRow ID="course_btn" runat="server" BorderColor="Gray">
                </asp:TableRow>
            </asp:table>
        </div>
        <div class="box4">

            <asp:TextBox ID="TextBox9" runat="server" Height="98px" Width="354px" Text="个人简介" style="margin-top: 0px"></asp:TextBox>

        </div>
        
            </div>
        <asp:Button ID="Button3" runat="server" Text="修改密码"  OnClick="Button3_Click"/>
    </form>
</body>
</html>
