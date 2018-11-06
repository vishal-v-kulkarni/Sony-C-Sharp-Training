<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesReport.aspx.cs" Inherits="BillingSystem_Web.SalesReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
    
    <h1> Sales Report</h1>
        <br/><br/>
    <table id="billtable" class="auto-style14">
         <tr>
            <th class="auto-style2">SL.No</th>
            <th class="auto-style3">Product Name</th>
             <th class="auto-style13">Quantity</th>
             <th class="auto-style6">Sub Total</th>
        </tr>
        <tr>
            <td class="auto-style2" colspan="1">&nbsp;1</td>
            <td class="auto-style3">Books&nbsp;</td>
            <td class="auto-style13">2</td>
            <td class="auto-style18">30</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;2</td>
            <td class="auto-style8">Pen&nbsp;</td>
            <td class="auto-style9">1</td>
            <td class="auto-style4">5</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;3</td>
            <td class="auto-style3">Soap&nbsp;</td>
            <td class="auto-style9">3</td>
            <td class="auto-style4">60</td>
        </tr>
    </table>
      </asp:Panel>
    <form id="form1" runat="server">
        <div class="auto-style15">
        </div>
        <p class="auto-style15">
            <asp:Button ID="Button1" runat="server" OnClientClick = "return PrintPanel();" Text="Print" Width="86px" />
        </p>
    </form>
</body>

</html>

