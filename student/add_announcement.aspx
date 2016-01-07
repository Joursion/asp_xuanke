<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="add_announcement.aspx.cs" Inherits="student.add_announcement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="gg_show_title" runat="server" Text="公告标题"></asp:Label>
    <asp:TextBox ID="gg_title" runat="server"></asp:TextBox>
    <asp:Label ID="gg_show_content" runat="server" Text="公告内容"></asp:Label>
    <asp:TextBox ID="gg_content" runat="server"></asp:TextBox>
    <asp:Button ID="gg_submit" runat="server" Text="发布" OnClick="gg_submit_Click" />
</asp:Content>
