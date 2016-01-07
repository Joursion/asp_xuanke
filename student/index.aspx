<%@ Page Title="" Language="C#" MasterPageFile="~/Student_head.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="student.index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--显示公告--%>
    <asp:Label ID="student_gg_title" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="student_gg_content" runat="server" Text="Label"></asp:Label>
</asp:Content>
