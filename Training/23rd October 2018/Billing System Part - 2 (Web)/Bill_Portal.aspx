<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bill_Portal.aspx.cs" Inherits="BillingSystem.Bill_Portal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <form id="form1" runat="server">
<asp:Panel id="pnlContents" runat = "server">
<head>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 340px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 852px;
        }
        .auto-style4 {
            width: 126px;
        }
        .auto-style6 {
            width: 643px;
            height: 23px;
        }
        .auto-style7 {
            width: 340px;
        }
        .auto-style8 {
            width: 852px;
        }
        .auto-style9 {
            width: 300px;
        }
        .auto-style10 {
            width: 419px;
            height: 23px;
        }
        .auto-style12 {
            width: 565px;
            height: 23px;
        }
        .auto-style13 {
            width: 300px;
            height: 23px;
        }
        .auto-style14 {
            width: 100%;
        }
        .auto-style15 {
            margin-left: 880px;
        }

        h1 { font: bold 100% sans-serif; letter-spacing: 0.5em; text-align: center; text-transform: uppercase; background: #000; border-radius: 0.25em; color: #FFF; margin: 0 0 1em; padding: 0.5em 0; }

        .auto-style16 {
            width: 1045px;
            height: 23px;
        }
        .auto-style17 {
            width: 430px;
            height: 23px;
        }
        .auto-style18 {
            width: 126px;
            height: 23px;
        }
        table tr td {
            text-align: center;
        }

    </style>

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
