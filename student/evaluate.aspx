<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="evaluate.aspx.cs" Inherits="Student.evaluate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <link rel="stylesheet" href="style/css/evaluate.css" />
</head>
<body>
    <form id="form1" runat="server">
    <center><asp:DropDownList ID = "select_course" runat = "server"  AutoPostBack = "true" OnSelectedIndexChanged = "Page_Load">
    <asp:ListItem Value="10000">选择课程</asp:ListItem>
    <asp:ListItem Value="10001">10001--计算机网络</asp:ListItem>
    <asp:ListItem Value="10002">10002--专业英语</asp:ListItem>
    <asp:ListItem Value="10003">10003--大学物理</asp:ListItem>
    <asp:ListItem Value="10004">10004--线性代数</asp:ListItem>
    <asp:ListItem Value="10005">10005--软件工程</asp:ListItem>
    <asp:ListItem Value="10006">10006--高等代数</asp:ListItem>
    <asp:ListItem Value="10007">10007--毛概</asp:ListItem>
    <asp:ListItem Value="10008">10008--马克思思想</asp:ListItem></asp:DropDownList></center>
    <div id = "show_course_id">课程编号</div>
    <div id = "show_course_name">课程名称</div>
    <div id = "show_teacher_name">教师姓名</div>
    <div id = "beikeqingkuang">备课情况</div>
    <div id = "jiaoxuetaidu">教学态度</div>
    <div id = "jiangkeneirong">讲课内容</div>
    <div id = "zuoyepiyue">作业批阅</div>
    <div id = "form"><asp:table  ID="evaluate_level" runat="server" Height="100px" Width="300px">
        <asp:TableRow ID="course_id" runat="server"  Width="100px"></asp:TableRow>
        <asp:TableRow ID="course_name" runat="server" Width="100px"></asp:TableRow>
        <asp:TableRow ID="teacher_name" runat="server" Width="100px"  ></asp:TableRow></asp:table></div>
    <div id = "lv1"><asp:DropDownList ID = "level1" runat = "server" AutoPostBack = "true" OnSelectedIndexChanged = "Page_Load">
    <asp:ListItem Value="(NULL)">选择等级</asp:ListItem>
    <asp:ListItem>优秀</asp:ListItem>
    <asp:ListItem>良好</asp:ListItem>
    <asp:ListItem>中等</asp:ListItem>
    <asp:ListItem>差</asp:ListItem></asp:DropDownList></div>
    <div id = "lv2"><asp:DropDownList ID = "level2" runat = "server" AutoPostBack = "true" OnSelectedIndexChanged = "Page_Load">
    <asp:ListItem Value="(NULL)">选择等级</asp:ListItem>
    <asp:ListItem>优秀</asp:ListItem>
    <asp:ListItem>良好</asp:ListItem>
    <asp:ListItem>中等</asp:ListItem>
    <asp:ListItem>差</asp:ListItem></asp:DropDownList></div>
    <div id = "lv3"><asp:DropDownList ID = "level3" runat = "server" AutoPostBack = "true" OnSelectedIndexChanged = "Page_Load">
    <asp:ListItem Value="(NULL)">选择等级</asp:ListItem>
    <asp:ListItem>优秀</asp:ListItem>
    <asp:ListItem>良好</asp:ListItem>
    <asp:ListItem>中等</asp:ListItem>
    <asp:ListItem>差</asp:ListItem></asp:DropDownList></div>
    <div id = "lv4"><asp:DropDownList ID = "level4" runat = "server" AutoPostBack = "true" OnSelectedIndexChanged = "Page_Load">
    <asp:ListItem Value="(NULL)">选择等级</asp:ListItem>
    <asp:ListItem>优秀</asp:ListItem>
    <asp:ListItem>良好</asp:ListItem>
    <asp:ListItem>中等</asp:ListItem>
    <asp:ListItem>差</asp:ListItem></asp:DropDownList></div>
    </form>
</body>
</html>
