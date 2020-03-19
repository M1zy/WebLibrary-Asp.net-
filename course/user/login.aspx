<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="course.user.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <table style="font-size:16px;">
        <tr>
            <td>Enter Email:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Text=""></asp:TextBox>
                </td>
        </tr>
                <tr>
            <td style="height: 44px">Enter password:</td>
            <td style="height: 44px">
                <asp:TextBox ID="TextBox2" runat="server" Text="" Height="29px" TextMode="Password" Width="114px"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

            </td>
        </tr>
    </table>
</asp:Content>
