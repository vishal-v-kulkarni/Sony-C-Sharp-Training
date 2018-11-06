<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeReport_Portal.aspx.cs" Inherits="BillingSystem.EmployeeReport_Portal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <asp:Panel id="pnlContents" runat = "server">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css"href="billstyle.css">

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
    <h1> Employee Report</h1>
    

        <br/><br/>


    <asp:Table id="employeetable" runat="server" class="auto-style14">
         <asp:TableRow>
            <asp:TableHeaderCell>SL.No</asp:TableHeaderCell>
            <asp:TableHeaderCell>Employee Name</asp:TableHeaderCell>
             <asp:TableHeaderCell>No. of Sales</asp:TableHeaderCell>
             <asp:TableHeaderCell>Total Cost</asp:TableHeaderCell>
        </asp:TableRow>
    </asp:Table>

    </asp:Panel>
    <form id="form1" runat="server">
        <div class="auto-style15">
        </div>
        <p class="auto-style15">
            <asp:Button ID="Button1" style="float: right;"  runat="server"  OnClientClick = "return PrintPanel();" Text="Print" Width="86px" BackColor="Black" ForeColor="White" />
        </p>
    </form>
</body>
</html>
