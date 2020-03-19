<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="BooksRequests.aspx.cs" Inherits="course.admin.BooksRequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
       <asp:Repeater ID="d1" runat="server"> 
        <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate>


                        <div >
                    <div >
                        <div class="card-body">
                            <table class="table">
                              <thead>
                                <tr>
                                    <th scope="col">image</th>
                                    <th scope="col">Name</th>
                                  <th scope="col">Author</th>
                                  <th scope="col">Genre</th>
                                  <th scope="col">Description</th>
                                    <th scope="col">Pages</th>
                                    <th scope="col">Adder</th>
                                    <th scope="col">PDF</th>
                              </tr>
                          </thead>
                          <tbody>
                            <tr>
                                <td>
                                <a href="Userbook.aspx?id=<%# Eval("Id") %>"><img src="../<%# Eval("product_image") %>" width="90"; height="110"; alt="" /></a>
                              </td>
                                    <td><%# Eval("product_name") %></td>
                              <td><%# Eval("product_author") %></td>
                              <td><%# Eval("product_brand") %></td>
                                <td><%# Eval("product_Description") %></td>
                                <td><%# Eval("product_pages") %></td>
                                <td><%# Eval("product_developer") %></td>
                                <td><%#checkpdf(Eval("Product_pdf"),Eval("Id")) %></td>
                          </tr>
                      </tbody>
                  </table>
                        </div>
                    </div>
                </div>
        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
