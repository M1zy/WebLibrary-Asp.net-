<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="course.user.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <p id="head">
    <b id="Itemshead">  Registration    
        </b>
       </p>
    <table style="width:400px; height:400px;">
        <tr>
            
            <td>First name</td>
            <td style="width: 363px">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
                <tr>
            
            <td>Last name</td>
            <td style="width: 363px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
                <tr>
            
            <td>email</td>
            <td style="width: 363px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
                <tr>
            
            <td>password</td>
            <td style="width: 363px">
                <asp:TextBox ID="TextBox5" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
                <tr>
            
            <td>address</td>
            <td style="width: 363px">
                <asp:TextBox ID="TextBox6" runat="server" Height="65px" TextMode="MultiLine" Width="123px"></asp:TextBox>
            </td>
        </tr>
                <tr>
            
            <td>mobile no.</td>
            <td style="width: 363px">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
                <tr>
            
          <td colspan="2" align="center"> 
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click"></asp:Button>
            </td>
        </tr>
                <tr>
            
            <td colspan="2" align="center" style="height: 18px">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
