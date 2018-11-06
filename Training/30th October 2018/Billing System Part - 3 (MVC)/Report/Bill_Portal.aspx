<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bill_Portal.aspx.cs" Inherits="BillingSystem.Bill_Portal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <form id="form1" runat="server">
<asp:Panel id="pnlContents" runat = "server">
<head>
    <title></title>
    <link rel="stylesheet" type="text/css"href="billstyle.css">

</head>
     <script type = "text/javascript">
        function PrintPanel() {
            var panel = document.getElementById("<%=pnlContents.ClientID %>");
            var printWindow = window.open('', '', 'height=600,width=1000');
           
            printWindow.document.write(panel.innerHTML);
           
            printWindow.document.close();
            setTimeout(function () {
                printWindow.print();
            }, 500);
            return false;
        }
    </script>
</head>
<body>
    <h1> BILL</h1>
    

    <table>
         <tr>
            <td class="auto-style10">Customer Name :
                <asp:Label ID="custname" runat="server" Text="Label"></asp:Label>
             </td>
            <td class="auto-style16">Bill No :
                <asp:Label ID="billnum" runat="server" Text="Label"></asp:Label>
             </td>
             <td class="auto-style17">Date :
                 <asp:Label ID="date" runat="server" Text="Label"></asp:Label>
             </td>
             <td class="auto-style12">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Time :
                 <asp:Label ID="time" runat="server" Text="Label"></asp:Label>
             </td>
        </tr>
    </table>
        <br/><br/>
    <asp:Table id="billtable" runat="server" class="auto-style14">
         <asp:TableRow>
            <asp:TableHeaderCell>SL.No</asp:TableHeaderCell>
             <asp:TableHeaderCell>Product Name</asp:TableHeaderCell>
             <asp:TableHeaderCell>Quantity</asp:TableHeaderCell>
             <asp:TableHeaderCell>Price per Unit</asp:TableHeaderCell>
             <asp:TableHeaderCell>GST</asp:TableHeaderCell>
             <asp:TableHeaderCell>Sub Total</asp:TableHeaderCell>
        </asp:TableRow>
       
    </asp:Table>
        </asp:Panel>
        <div class="auto-style15">
        </div>
        <p class="auto-style15">
            <asp:Button ID="Button1" runat="server" OnClientClick = "return PrintPanel();" Text="Print" Width="86px" />
        </p>
    </form>
</body>
</html>
