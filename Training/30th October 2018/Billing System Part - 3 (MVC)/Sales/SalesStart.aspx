<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesStart.aspx.cs" Inherits="BillingSystem.SalesStart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="SearchLabel" runat="server" Text="Product Name: "></asp:Label>
            <asp:TextBox ID="SearchTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="SearchButton" runat="server" Text="Search" OnClick="SearchButton_Click" />
        </div>

        <div>
            <asp:Button ID="LogoutButton" runat="server" Text="Logout" OnClick="LogoutButton_Click" />
        </div>

        <div>
            <asp:Table ID="SalesTable" runat="server" Height="250px" GridLines="Both">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Sl.No.</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Product Id.</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Product Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Quantity</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Price per Unit</asp:TableHeaderCell>
                    <asp:TableHeaderCell>GST</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Subtotal</asp:TableHeaderCell>
                </asp:TableHeaderRow>
                              
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox011" runat="server" Text="1" Enabled="false"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox012" runat="server" Text="123" OnTextChanged="ProductId_TextChange" AutoPostBack="true"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox013" runat="server" Text="Rice" Enabled="false"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox014" runat="server" Text="2" OnTextChanged="Quantity_TextChange" AutoPostBack="true"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox015" runat="server" Text="114" Enabled="false"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox016" runat="server" Text="14" Enabled="false"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox017" runat="server" Text="1000" Enabled="false"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>

        <div>
            <asp:Button ID="CheckOutButton" runat="server" Text="Checkout" OnClick="CheckOutButton_Click" />
        </div>
    </form>
</body>
</html>
