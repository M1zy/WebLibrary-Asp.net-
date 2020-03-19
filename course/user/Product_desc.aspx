<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="Product_desc.aspx.cs" Inherits="course.user.Product_desc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">

    
        <asp:Repeater ID="d1" runat="server"> 
            
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
    <div style="height:302px; width:690px; border-style:solid; border-width:1px;">

        <div style="height:300px; width:200px; float:left; border-style:solid; border-width:1px;">
        <img src='../<%# Eval("product_image") %>' height="300" width="200" alt=""/>
            </div>
        <div style="height:300px; width:485px; float:left; border-style:solid; border-width:1px;">
            <textarea  rows="22" cols ="73"><%# Eval("product_Text") %></textarea>
      </div>
          </div>   
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a  href="Reviews.aspx?id=<%# Eval("Id") %>" style="font-family: Arial; font-size: 16px; text-decoration: underline">Reviews</a>
        </ItemTemplate>

    </asp:Repeater>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label> 
    <br />
    <asp:Button ID="b1" runat="server" Text="Add to account" Width="205px" OnClick="b1_Click" />  

    
    <div style="margin-left:250px; margin-top:-30px;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label runat="server" Text="Rating:" Font-Size="Large" ></asp:Label>
    <asp:Label runat="server" Text="sadasfafa" ID="Rating" Font-Size="Large" ></asp:Label>
    <br />
<div id="reviewStars-input" >
        <asp:RadioButton  runat="server"    ID="stars5" GroupName="reviewStars" />
	<label title="Best" for="stars5">-5</label>

	<asp:RadioButton  runat="server"    ID="stars4" GroupName="reviewStars" />
	<label title="gorgeous" for="stars4">-4</label>

	<asp:RadioButton  runat="server"   ID="stars3"   GroupName="reviewStars" />
	<label title="good" for="stars3">-3</label>

	<asp:RadioButton  runat="server"   ID="stars2"   GroupName="reviewStars" />
	<label title="regular" for="stars2">-2</label>

	<asp:RadioButton  runat="server"  ID="stars1"   GroupName="reviewStars" />
	<label title="poor" for="stars1">-1</label>

	<asp:RadioButton  runat="server"    ID="stars0"    GroupName="reviewStars" />
	<label title="bad" for="stars0">-0</label>
</div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="b2" runat="server" Text="Rate" Width="105px" OnClick="b2_Click"  />  
    </div>
</asp:Content>

