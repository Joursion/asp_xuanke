﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Student_head.Master" AutoEventWireup="true" CodeBehind="show_my_course.aspx.cs" Inherits="student.show_my_course" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="show_my_course">
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false" GridLineS="None" Height="121px" PageSize="6" ShowHeader="false" Width="80%"> 
            <Columns>
                
               <asp:BoundField DataField="course_id" HeaderText="课程ID" ItemStyle-Width="30%"  />
                <asp:BoundField DataField="course_name" HeaderText="课程名称" ItemStyle-Width="30%"  />
                <asp:BoundField DataField="course_grade" HeaderText="课程学分" ItemStyle-Width="100px" />
             
                <asp:TemplateField>   
                   <ItemTemplate>   
                           <asp:Button  ID="Button_quit_select"  runat="server"  OnClick="Button_quit_select_Click"   Text="我要退选"    />   
                   </ItemTemplate>   
                </asp:TemplateField>   
               
               <%-- <asp:HyperLinkField DataNavigateUrlFields="'Request.QueryString["stu"]' ,course_id" DataNavigateUrlFormatString="shownew.aspx?id={0}&ds={1}" DataTextField="course_id" DataTextFormatString="&#183;{0}" HeaderText="新闻标题" >
                  
                </asp:HyperLinkField>--%>
            </Columns>
        </asp:GridView>
        <br />
        <div id="show_show_course_id"> 课程ID</div>
        <div id="show_show_course_name"> 课程名称</div>
         <div id="show_show_grade">课程学分</div>
        <div id="show_page">
        当前页码为:[<asp:Label ID="LabelPage" runat="server" Text="1"></asp:Label>]&nbsp;总页码为:[<asp:Label ID="LableTotalPage" runat="server" Text=""></asp:Label>]
        <asp:LinkButton ID ="LinkButtonFirst" runat="server" OnClick="LinkButtonFirst_Click">首页</asp:LinkButton>&nbsp;
        <asp:LinkButton ID ="LinkButtonPrev" runat="server" OnClick="LinkButtonPrev_Click">上一页</asp:LinkButton>&nbsp;
        <asp:LinkButton ID ="LinkButtonNext" runat="server" OnClick="LinkButtonNext_Click">下一页</asp:LinkButton>&nbsp;
          <asp:LinkButton ID ="LinkButtonLast" runat="server" OnClick="LinkButtonLast_Click">末页</asp:LinkButton>&nbsp;
        </div>
    </div>
</asp:Content>
