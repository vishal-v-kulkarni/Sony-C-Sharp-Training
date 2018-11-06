<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeReport.aspx.cs" Inherits="BillingSystem_Web.EmployeeReport" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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

        .auto-style18 {
            width: 126px;
            height: 23px;
        }
        table tr td {
            text-align: center;
        }

    </style>
</head>
<body style="width: 970px; height: 45px;">
    <h1> Employee Report</h1>
    

        <br/><br/>
    <table id="billtable" class="auto-style14">
         <tr>
            <th class="auto-style2">SL.No</th>
            <th class="auto-style3">Employee Name</th>
             <th class="auto-style13">No. of Sales</th>
             <th class="auto-style6">Total Cost</th>
        </tr>
        <tr>
            <td class="auto-style2" colspan="1">&nbsp;1</td>
            <td class="auto-style3">Ramesh</td>
            <td class="auto-style13">200</td>
            <td class="auto-style18">25100</td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;2</td>
            <td class="auto-style8">Suresh&nbsp;</td>
            <td class="auto-style9">100</td>
            <td class="auto-style4">10650</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;3</td>
            <td class="auto-style3">Rajesh&nbsp;</td>
            <td class="auto-style9">300</td>
            <td class="auto-style4">28720</td>
        </tr>
    </table>
    <form id="form1" runat="server">
        <div class="auto-style15">
        </div>
        <p class="auto-style15">
            <asp:Button ID="Button1" runat="server" Text="Print" Width="86px" />
        </p>
    </form>
</body>
</html>
