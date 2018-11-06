<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FirstWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>WELCOME</h1>
        </div>
        <p>
            <asp:TextBox ID="num1" runat="server" onkeydown="return (!(event.keyCode>=65) && (event.keyCode!=32))"></asp:TextBox>
            <asp:TextBox ID="num2" runat="server" Height="16px" OnKeyDown="return (!(event.keyCode>=65) && (event.keyCode!=32))"></asp:TextBox>
            <br/><br/>
            <asp:Table ID="Table1" runat="server" Width="254px" GridLines="Both" Height="46px">
                <asp:TableRow>
                    <asp:TableCell> <asp:Button ID="Add" runat="server" Text="Add"  OnClick="Add_Click" > </asp:Button > </asp:TableCell>
                    <asp:TableCell><asp:Button ID="Sub" runat="server" Text="Subtract" OnClick="Sub_Click" ></asp:Button ></asp:TableCell>
                    <asp:TableCell><asp:Button ID="Mul" runat="server" Text="Multiply" OnClick="Mul_Click"></asp:Button ></asp:TableCell>
                    <asp:TableCell><asp:Button ID="Div" runat="server" Text="Divide" OnClick="Div_Click"></asp:Button ></asp:TableCell>
                </asp:TableRow>
            </asp:Table>

        </p>
    
        <p>
            <asp:TextBox ID="Result" runat="server"></asp:TextBox>
        </p>
       
    </form>
</body>
</html>
