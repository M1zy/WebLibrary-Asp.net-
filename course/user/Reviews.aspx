<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="Reviews.aspx.cs" Inherits="course.user.Reviews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
               <p id="head">
    <b id="Itemshead">  Reviews  
        </b>
       </p>

    <table>

                <tr>
            <td>
                Comment
            </td>
            <td style="width: 220px"><asp:TextBox ID="Comm" runat="server" Height="89px" TextMode="MultiLine" Width="255px"></asp:TextBox></td>
        </tr>
                <tr>
            <td colspan="2" style="text-align:center; height: 36px;" >
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="b1" runat="server" Text="Upload" OnClick="b1_Click" />
            </td>

        </tr>
        
        <asp:Repeater ID="r1" runat="server" >
            <HeaderTemplate>
                <ul class="Reviews">
            </HeaderTemplate>
            
            <ItemTemplate>
                
                                <div style="margin:10px;">
                                    
                <asp:Label ID="l1" runat="server" Text='<%# Eval("username") %>'></asp:Label>
                                    &nbsp;&nbsp;
                <asp:Label ID="l3" runat="server" Text='<%# Eval("time") %>'></asp:Label>
                                     &nbsp;&nbsp;
                <asp:Label ID="l2" runat="server" Text='<%# Eval("comment_text") %>'></asp:Label>
                    </div>
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
            
    </table>
    <asp:Label ID="Error" runat="server" Text=""></asp:Label>
    <asp:Label ID="finder" runat="server" Text=""></asp:Label>
</asp:Content>
