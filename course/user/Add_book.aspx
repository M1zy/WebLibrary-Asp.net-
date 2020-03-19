<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="Add_book.aspx.cs" Inherits="course.user.Add_book" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
           <p id="head">
    <b id="Itemshead">  Adding book  
        </b>
       </p>
    <table style="font-size:16px;">
        <tr>
            <td>
                Book name
            </td>
            <td style="width: 220px"><asp:TextBox ID="t1" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>
                Book brand
            </td>
            <td style="width: 220px"><asp:TextBox ID="t2" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>
                Book pages
            </td>
            <td style="width: 220px"><asp:TextBox ID="t3" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>
                Description in short
            </td>
            <td style="width: 220px"><asp:TextBox ID="t4" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>
                Book description
            </td>
            <td style="width: 220px"><asp:TextBox ID="t5" runat="server" Height="110px" TextMode="MultiLine" Width="639px"></asp:TextBox></td>
        </tr>
                                <tr>
            <td>
                product author
            </td>
            <td style="width: 220px"><asp:TextBox ID="t6" runat="server"/>

            </td>
        </tr>
                                <tr>
            <td>
                product category
            </td>
            <td style="width: 220px"><asp:RadioButton id="Radio1" Text="Foreign" Checked="True" GroupName="RadioGroup1" runat="server" />
                <asp:RadioButton id="Radio2" Text="Native"  GroupName="RadioGroup1" runat="server" /><br />
            </td>
        </tr>
                <tr>
            <td>
                product image
            </td>
            <td style="width: 220px"><asp:FileUpload ID="f1" runat="server"/>

            </td>
        </tr>

                        <tr>
            <td>
                Product pdf
            </td>
            <td style="width: 220px"><asp:FileUpload ID="f2" runat="server"/>

            </td>
        </tr>

        <tr>
            <td colspan="2" style="text-align:center;" >
                <asp:Button ID="b1" runat="server" Text="Upload" OnClick="b1_Click" />
            </td>

        </tr>
        
    </table>
    <asp:Label ID="Error" runat="server" Text=""></asp:Label>
</asp:Content>
