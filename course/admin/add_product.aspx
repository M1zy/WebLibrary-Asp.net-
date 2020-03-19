<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="add_product.aspx.cs" Inherits="course.admin.add_product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <table>
        <tr>
            <td>
                product name
            </td>
            <td style="width: 220px"><asp:TextBox ID="t1" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>
                product brand
            </td>
            <td style="width: 220px"><asp:TextBox ID="t2" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>
                product pages
            </td>
            <td style="width: 220px"><asp:TextBox ID="t3" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>
                product description
            </td>
            <td style="width: 220px"><asp:TextBox ID="t4" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            <td>
                product Text
            </td>
            <td style="width: 220px"><asp:TextBox ID="t5" runat="server" Height="116px" TextMode="MultiLine" Width="765px"></asp:TextBox></td>
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
