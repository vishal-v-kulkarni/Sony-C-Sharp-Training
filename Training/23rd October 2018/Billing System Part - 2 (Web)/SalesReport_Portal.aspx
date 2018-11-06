<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesReport_Portal.aspx.cs" Inherits="BillingSystem.SalesReport_Portal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
        <form id="form1" runat="server">
<asp:Panel id="pnlContents" runat = "server">
<head>
    <title></title>
    <style type="text/css">
        .auto-style14 {
            width: 100%;
        }
        .auto-style15 {
            margin-left: 880px;
        }

        h1 { font: bold 100% sans-serif; letter-spacing: 0.5em; text-align: center; text-transform: uppercase; background: #000; border-radius: 0.25em; color: #FFF; margin: 0 0 1em; padding: 0.5em 0; }

        table tr td {
            text-align: center;
        }

        .auto-style17 {
            width: 966px;
            height: 58px;
        }
        .auto-style20 {
            width: 310px;
        }
        .auto-style21 {
            width: 372px;
        }

        .auto-style22 {
            height: 20px;
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



    <table style="float: left;"  class="auto-style17">
         <tr>
            <td class="auto-style20">From Date : <asp:TextBox ID="fromdate" runat="server" TextMode="Date"></asp:TextBox></td>
            <td class="auto-style21">To Date :  <asp:TextBox ID="todate" runat="server" TextMode="Date"></asp:TextBox></td>
            
             <td class="auto-style12">
                 
                 <asp:Button ID="searchdate" runat="server" Text="Search" OnClick="searchdate_Click"/>
                 
             </td>
        </tr>
    </table>
    
        <br/><br/><br/><br/>
    <asp:Table id="salestable" runat="server" class="auto-style14">
         <asp:TableRow>
            <asp:TableHeaderCell>SL.No</asp:TableHeaderCell>
            <asp:TableHeaderCell>Customer Name</asp:TableHeaderCell>
             <asp:TableHeaderCell>Product Name</asp:TableHeaderCell>
             <asp:TableHeaderCell>Quantity</asp:TableHeaderCell>
             <asp:TableHeaderCell>Price per Unit</asp:TableHeaderCell>           
             <asp:TableHeaderCell>Sold Date</asp:TableHeaderCell>
        </asp:TableRow>
       
    </asp:Table>
      </asp:Panel>
        <p class="auto-style15">
            <asp:Button ID="print" style="float: right; " runat="server" OnClientClick = "return PrintPanel();" Text="Print" Width="86px" BackColor="Black" ForeColor="White" />
        </p>
    </form>
</body>

</html>
