﻿<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Comments.aspx.cs" Inherits="course.admin.Comments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">



    <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" BackColor="#999999" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowPaging="True" AutoGenerateEditButton="True" AutoGenerateSelectButton="True" Height="341px" Width="572px">
    <Columns>
        <asp:BoundField DataField="book" HeaderText="book_id" SortExpression="book" />
        <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
        <asp:BoundField DataField="comment_text" HeaderText="comment_text" SortExpression="comment_text" />
        <asp:BoundField DataField="time" HeaderText="time" SortExpression="time" />
    </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <RowStyle BackColor="#999999" ForeColor="#330099" />
    <SelectedRowStyle BackColor="#FF9933" Font-Bold="True" ForeColor="#663399" />
    <SortedAscendingCellStyle BackColor="#FEFCEB" />
    <SortedAscendingHeaderStyle BackColor="#AF0101" />
    <SortedDescendingCellStyle BackColor="#F6F0C0" />
    <SortedDescendingHeaderStyle BackColor="#7E0000" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"  DeleteCommand="DELETE FROM [comment] WHERE [Id] = @Id"  SelectCommand="SELECT * FROM [comment]" UpdateCommand="UPDATE [comment] SET [book] = @book, [username] = @username, [comment_text] = @comment_text, [time] = @time  WHERE [Id] = @Id"></asp:SqlDataSource>
    



</asp:Content>