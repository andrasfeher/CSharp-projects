<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmDefectState.aspx.cs" Inherits="DefectUI.ConfirmDefectState" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Confirm Defect State</title>
    <link rel="Stylesheet" href="style.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        Select the right option!
        <br />
    </div>
    <div id="Div1">
        <asp:Button ID="btResolved" runat="server" Text="Resolve" Width="70" 
            onclick="btResolved_Click" />
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btRejected" runat="server" Text="Reject"  Width="70" 
            onclick="btRejected_Click" /></div>
    </form>
</body>
</html>
