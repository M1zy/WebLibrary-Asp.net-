<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="course.user.Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
       <p id="head">
    <b id="Itemshead">  Account menu    
        </b>
       </p>

<div class="account-menu">
                    <p class="box">
                        <a href="cart.aspx" >Your archive of books </a>
                    </p>

                                       
                    <p class="box">
                        <a href="YourBooks.aspx" >Your books </a>
                    </p>

                       <p class="box">
                        <a href="Add_book.aspx" >Add book </a>
                    </p>
    </div> 

</asp:Content>
