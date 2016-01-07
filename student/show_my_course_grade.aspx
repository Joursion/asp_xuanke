<%@ Page Title="" Language="C#" MasterPageFile="~/Student_head.Master" AutoEventWireup="true" CodeBehind="show_my_course_grade.aspx.cs" Inherits="student.show_my_course_grade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     
        <div id="show_course_name"> 课程名称</div>
         <div id="show_course_grade">课程分数</div>
    <asp:table  ID="Show_query_grade" runat="server" 
                 Height="200px" Width="452px">
               <asp:TableRow ID="query_grade_name" runat="server"  Width="100px">
                  </asp:TableRow>

               <asp:TableRow ID="query_grade_grade" runat="server" Width="100px">
                 </asp:TableRow>
    </asp:table>
    <asp:Label ID="show_tips" runat="server" Text="课程分数为0，可能是当前成绩还未录入，请后续继续关注"></asp:Label>
</asp:Content>
