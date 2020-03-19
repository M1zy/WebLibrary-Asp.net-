<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="course.user.delete" %>
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
    <div style="height:302px; width:602px; border-style:solid; border-width:1px;">

        <div style="height:300px; width:200px; float:left; border-style:solid; border-width:1px;">
        <img src='../<%# Eval("product_image") %>' height="300" width="200" alt=""/>
            </div>
        <div style="height:300px; width:396px; float:left; border-style:solid; border-width:1px;">
            <textarea rows="19" cols ="53"><%# Eval("product_Text") %></textarea>
      </div>
          </div>   
                       
        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>
    </asp:Repeater>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label> 
    <br />
    <asp:Button ID="b1" runat="server" Text="Delete from cart" Width="205px" OnClick="b1_Click" />
</asp:Content>
