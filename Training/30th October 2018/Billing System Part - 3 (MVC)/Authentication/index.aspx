<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="BillingSystem.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
            <h1>LOGIN!!!</h1>
            UserId:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="userid" runat="server" OnTextChanged="userId_TextChanged"></asp:TextBox>
            <br />
            <br />
            Password: <input id="password" type="password" runat="server" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="UserLogin" />
            </div>
           
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
           
    </form>
</body>
</html>
