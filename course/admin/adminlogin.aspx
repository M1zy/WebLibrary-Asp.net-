<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="course.admin.adminlogin" %>

<!DOCTYPE html>
<html >
  <head>
    <meta charset="UTF-8">
    <title>Admin Login</title>
        <link rel="stylesheet" href="logincss/style1.css" >
      
<style>body
{
    background: #c7b39b url(logincss/prism.png);
}
</style>
  </head>
    <body>
<form id="f1" runat="server" class="form-2">
  
    <h1><span class="log-in">Войти</span> или <span class="sign-up">зарегистрироваться</span></h1>
       <p class="float">
            <label for="login"><i class="icon-user"></i>Логин</label>
  <asp:TextBox ID="t1" runat="server" type="text" name="login" placeholder="Логин или email"></asp:TextBox>
      </p>

       <p class="float">
        <label for="password"><i class="icon-lock"></i>Пароль</label>
   <asp:TextBox ID="t2" runat="server" TextMode="Password"  placeholder="Пароль" class="showpassword" ></asp:TextBox>        
        </p>
    <p class="clearfix">
         <a href="../user/items.aspx" class="log-twitter">Back to the main menu</a>  
 <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" name="submit" />
      </p>    
    <a>
    <asp:Label ID="l1" runat="server" Text=""></asp:Label>
    </a>
      
</form>       
    
    
    
    
  </body>
</html>
