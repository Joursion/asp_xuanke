<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="teacher_info.aspx.cs" Inherits="student.teacher_info" %>

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
        <div class="img">
            <asp:Image ID="Image1" runat="server" Height="152px" Width="130px" />
        </div>
        <div class="box2">
            <asp:Label ID="Label1" runat="server" Text="工号"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="Label2" runat="server" Text="姓名"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Width="91px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="学院"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="职称"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Width="91px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="联系方式"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="身份证号"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" Width="350px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="家庭地址"></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" Width="350px"></asp:TextBox>
            <br />
            <!--TextBox 1:工号 2:姓名 3:学院 4:专业 5:入职时间 6:联系方式 7:身份证号 8:家庭地址-->
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
                        学分</asp:TableCell>
                </asp:TableRow>
               
               <asp:TableRow ID="_course_name" runat="server"  Width="200px" BorderColor="Gray">
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
            <asp:TextBox ID="TextBox9" runat="server" Height="103px" Width="320px" Text="..." style="margin-top: 0px; margin-left: 25px;"></asp:TextBox>
        </div>
    </form>
</body>
</html>
