<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        a:
        <asp:TextBox ID="TextBox1" runat="server">0</asp:TextBox>
        <br />
        b:
        <asp:TextBox ID="TextBox2" runat="server">0</asp:TextBox>
        <br />
        <br />
        eredmeny:         <asp:Label ID="lblResult" runat="server"></asp:Label>
        <br />
        <br />
        Invoice no:
        <asp:Label ID="lblInvoiceNo" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
