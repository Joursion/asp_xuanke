<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher.Master" AutoEventWireup="true" CodeBehind="add_course.aspx.cs" Inherits="student.add_course" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <asp:Label ID="Show_course_id" runat="server" Text="课程编号"></asp:Label>
        <asp:TextBox ID="Add_course_id" runat="server"></asp:TextBox>
        <asp:Label ID="Show_course_name" runat="server" Text="课程名称"></asp:Label>
        <asp:TextBox ID="Add_course_name" runat="server"></asp:TextBox>
        <asp:Label ID="Show_course_teacher" runat="server" Text="任教教师"></asp:Label>
        <asp:TextBox ID="Add_course_teacher" runat="server"></asp:TextBox>
        <asp:Label ID="Show_course_grade" runat="server" Text="课程学分"></asp:Label>
        <asp:TextBox ID="Add_course_grade" runat="server"></asp:TextBox>
        <asp:Label ID="Show_course_rest" runat="server" Text="课程总量"></asp:Label>
        <asp:TextBox ID="Add_course_rest" runat="server"></asp:TextBox>
        <asp:Button ID="Add_confirm" runat="server" Text="确认" OnClick="Add_confirm_Click" />
        <asp:Label ID="Add_success" runat="server" Text=""></asp:Label>
</asp:Content>
