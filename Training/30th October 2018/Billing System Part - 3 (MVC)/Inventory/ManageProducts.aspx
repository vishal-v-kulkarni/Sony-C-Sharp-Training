<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="BillingSystem.ManageProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MANAGE PRODUCTS</h1>
        </div>
        <p>
            PID :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="pid" runat="server" Height="16px" style="margin-left: 15px; margin-top: 1px" Width="188px" OnTextChanged="pid_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; GST:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="gst" runat="server" Height="16px" Width="180px"></asp:TextBox>
        </p>
        <p>
            PNAME:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="pname" runat="server" Height="16px" Width="186px"></asp:TextBox>
        </p>
        <p>
            PRICE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="price" runat="server" Height="16px" Width="180px"></asp:TextBox>
        </p>
        <p>
            QUANTITY:&nbsp;&nbsp;
            <asp:TextBox ID="quantity" runat="server" Height="16px" Width="180px"></asp:TextBox>
        </p>
        <p>
            EXPIRY:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="expiry" runat="server" Height="16px" Width="180px"></asp:TextBox>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Add_Btn" runat="server" Height="28px" Text="ADD" Width="173px" OnClick="Add_Btn_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Del_Btn" runat="server" Height="28px" Text="DELETE" Width="173px" OnClick="Del_Btn_Click" />
        </p>
        <p style="margin-left: 200px">
            <asp:Button ID="Mod_Btn" runat="server" Height="28px" style="margin-left: 11px" Text="MODIFY" Width="172px" OnClick="Mod_Btn_Click" />
        </p>
        <p style="margin-left: 200px">
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
