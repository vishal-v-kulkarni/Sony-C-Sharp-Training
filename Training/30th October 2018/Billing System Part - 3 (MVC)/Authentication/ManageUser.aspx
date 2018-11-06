<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="BillingSystem.ManageUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            MANAGE YOUR EMPLOYEE DETAILS!!!
        </h1>
        <div>
            UserId:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="userid" runat="server" Width="200px"></asp:TextBox>
            <br />
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="username" runat="server" Width="200px"></asp:TextBox>
            <br />
            Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="email" runat="server" Width="196px"></asp:TextBox>
            <br />
            Mobile No:&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="mobile" runat="server" Width="200px"></asp:TextBox>

            <br />
            <br />
            Password :&nbsp;&nbsp;
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            User Type :
            <asp:TextBox ID="utype" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="adduserbtn" runat="server" Text="Add" OnClick="adduserbtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="updateuserbtn" runat="server" Text="Update" OnClick="updateuserbtn_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="deleteuserbtn" runat="server" Text="Delete" OnClick="deleteuserbtn_Click" />
        </div>
    </form>
</body>
</html>
