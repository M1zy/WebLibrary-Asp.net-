<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="YourBooks.aspx.cs" Inherits="course.user.YourBooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
           <p id="head">
    <b id="Itemshead">  Your Books 
        </b>
       </p>
    <asp:Repeater ID="d1" runat="server"> 
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>

                <li class="last" style="margin:3px;">
                    <a ><img src="../<%# Eval("product_image") %>" width="252"; height="300"; alt="" /></a>
                    <div  class="product-info">
                        <h3 ><%# Eval("product_name") %></h3>
                        <div  class="product-desc">
                            <p ><%# Eval("product_author") %></p>
                            <strong class="price"><%# Eval("product_pages") %></strong>
                        </div>
                    </div>
                </li>

        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
