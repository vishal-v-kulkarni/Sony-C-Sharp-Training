<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tables.aspx.cs" Inherits="DatabaseTablesView.Tables" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SalesConnectionString %>" SelectCommand="SELECT [Pid], [Price], [Pname] FROM [Product]"></asp:SqlDataSource>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lpid" runat="server" Text="Pid"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lpname" runat="server" Text="Pname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lprice" runat="server" Text="Price"></asp:Label>
            <br />
            <asp:Button ID="prev" runat="server" Text="Prev" OnClick="prev_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="pid" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="pname" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="price" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="next" runat="server" Text="Next" OnClick="next_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="edit" runat="server" OnClick="edit_Click" Text="Edit" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="add" runat="server" Text="Add" />
            <br />
            <br />
            <br />
        </div>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Pname" DataValueField="Price" Height="97px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="211px"></asp:ListBox>
        <p>
            <asp:Label ID="text1" runat="server" Text="Label"></asp:Label>
        </p>
        <div id="div1" runat="server">
        </div>
    </form>
</body>
</html>
