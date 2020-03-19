<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" 
    CodeBehind="deletefromcart.aspx.cs" Inherits="course.user.deletefromcart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">


        <asp:Repeater ID="d1" runat="server"> 
        <ItemTemplate>
    <div style="height:302px; width:690px; border-style:solid; border-width:1px;">

        <div style="height:300px; width:200px; float:left; border-style:solid; border-width:1px;">
        <img src='../<%# Eval("product_image") %>' height="300" width="200" alt=""/>
            </div>
        <div style="height:300px; width:486px; float:left; border-style:solid; border-width:1px;">
            <textarea rows="22" cols ="73"><%# Eval("product_Text") %></textarea>
      </div>
          </div>   
        </ItemTemplate>
    </asp:Repeater>
    
    <br />
    <asp:Button ID="b1" runat="server" Text="Delete from cart" Width="205px" OnClick="b1_Click" />
   <asp:Repeater ID="d2" runat="server"> 
       <ItemTemplate>
     
    <asp:Label ID="label1" runat="server" Text="Your rate:"><%# Eval("c_Rate") %></asp:Label>
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a  href="Reviews.aspx?id=<%# Eval("Id") %>" style="font-family: Arial; font-size: 16px; text-decoration: underline">Reviews</a>

           </ItemTemplate>
       </asp:Repeater>
    </asp:Content>