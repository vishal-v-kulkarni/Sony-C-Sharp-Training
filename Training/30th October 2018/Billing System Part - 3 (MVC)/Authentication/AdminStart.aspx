<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStart.aspx.cs" Inherits="BillingSystem.AdminStart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Welcome Admin!!
        </h1>
        <div>
            <asp:Button ID="ManageUsers" runat="server" Text="Manage Users" OnClick="ManageUsers_Click" Width="200px" />
            <br />
            <asp:Button ID="Inventory" runat="server" Text="Inventory" OnClick="Inventory_Click" Width="200px"/>
            <br />
            <asp:Button ID="SalesReort" runat="server" Text="Sales Report" OnClick="SalesReort_Click" Width="200px"/>
            <br />
            <asp:Button ID="EmployeeReport" runat="server" Text="Employee Report" OnClick="EmployeeReport_Click" Width="200px"/>
            <br />
            <asp:Button ID="DoSales" runat="server" Text="Do Sales" OnClick="DoSales_Click" Width="200px"/>
        </div>
    </form>
</body>
</html>
