<%@ Page Language="VB" AutoEventWireup="false" CodeFile="default.aspx.vb" Inherits="_default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />

    <title>Calculator</title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="btnSubmit">
    <div>
    
        <h1>Salary Calculator</h1>

        <h2>Hourly Wage :</h2>
        <h3><asp:TextBox ID="tbHoursWage" runat="server"></asp:TextBox></h3>
        <h2>Number of hours worked this week:</h2>
        <h3><asp:TextBox ID="tbHoursWorked" runat="server"></asp:TextBox></h3>
        <h2>Pre-tax Deductions :</h2>
        <h3 ><asp:TextBox ID="tbPreTax" runat="server" Width="128px"></asp:TextBox></h3>
        <h2>After Tax Deductions :</h2>
        <h3><asp:TextBox ID="tbAfterTax" runat="server"></asp:TextBox></h3>
        <h3><asp:Button ID="Button1" runat="server" Text="Clear" Width="62px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" /></h3>
        <h2>Your Net Wage is:
        <asp:Label ID="lbNetResult" runat="server"></asp:Label></h2>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

