<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher.Master" AutoEventWireup="true" CodeBehind="add_grade.aspx.cs" Inherits="student.add_grade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="false" GridLineS="None" Height="121px" PageSize="6" ShowHeader="false" Width="80%" > 
            <Columns>
                
                <asp:BoundField DataField="course_id" HeaderText="课程ID" ItemStyle-Width="100px"   />
                <asp:BoundField DataField="course_name" HeaderText="课程名称" ItemStyle-Width="30%"  />
                <asp:BoundField DataField="student_id" HeaderText="学生ID" ItemStyle-Width="100px" />
                <asp:BoundField DataField="student_name" HeaderText="学生名字" ItemStyle-Width="100px" />
                <asp:TemplateField>   
                   <ItemTemplate>  
                       
                         <asp:TextBox ID="Lable_grade_edit" runat="server" Enabled="false" > </asp:TextBox>
                        <asp:Button ID="Button_edit" runat="server" Text="修改"  OnClick="Button_edit_Click"/>
                           <asp:Button  ID="Button_save"  runat="server"  OnClick="Button_save_Click"  Text="保存"    />   
                      
                   </ItemTemplate>   
                </asp:TemplateField>   
               
               <%-- <asp:HyperLinkField DataNavigateUrlFields="'Request.QueryString["stu"]' ,course_id" DataNavigateUrlFormatString="shownew.aspx?id={0}&ds={1}" DataTextField="course_id" DataTextFormatString="&#183;{0}" HeaderText="新闻标题" >
                  
                </asp:HyperLinkField>--%>
            </Columns>
        </asp:GridView><br />
        <div id="show_page">
        当前页码为:[<asp:Label ID="LabelPage" runat="server" Text="1"></asp:Label>]&nbsp;总页码为:[<asp:Label ID="LableTotalPage" runat="server" Text=""></asp:Label>]
        <asp:LinkButton ID ="LinkButtonFirst" runat="server" OnClick="LinkButtonFirst_Click">首页</asp:LinkButton>&nbsp;
        <asp:LinkButton ID ="LinkButtonPrev" runat="server" OnClick="LinkButtonPrev_Click">上一页</asp:LinkButton>&nbsp;
        <asp:LinkButton ID ="LinkButtonNext" runat="server" OnClick="LinkButtonNext_Click">下一页</asp:LinkButton>&nbsp;
          <asp:LinkButton ID ="LinkButtonLast" runat="server" OnClick="LinkButtonLast_Click">末页</asp:LinkButton>&nbsp;
        </div>

</asp:Content>
