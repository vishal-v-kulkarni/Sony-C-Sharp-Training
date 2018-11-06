<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DBConnection.aspx.cs" Inherits="DBConnection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Billing_DBConnectionString2 %>" SelectCommand="SELECT * FROM [User_Table]"></asp:SqlDataSource>
    </form>
</body>
</html>
