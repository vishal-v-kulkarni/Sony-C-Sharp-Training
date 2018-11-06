<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListWeb.aspx.cs" Inherits="Test1_DisplayDirectory.ListWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 276px;
            width: 801px;
        }
        #text {
            height: 146px;
            width: 875px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="listdrives" runat="server" AutoPostBack="True" OnSelectedIndexChanged="listdrives_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ListBox ID="listbox" runat="server" AutoPostBack="True" Height="216px" OnSelectedIndexChanged="listbox_SelectedIndexChanged" Width="607px"></asp:ListBox>
        <p>
            <textarea runat="server" id="TextArea1" name="S1"></textarea></p>
    </form>
</body>
</html>
