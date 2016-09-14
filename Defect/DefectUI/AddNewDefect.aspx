<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewDefect.aspx.cs" Inherits="DefectUI.AddNewDefect" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Add New Defect</title>
    <link rel="Stylesheet" href="style.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <table class="newDefect">
            <thead>
                <tr><th colspan="2"><h3>Add new defect</h3></th></tr>
            </thead>
            <tbody>
                <tr>
                    <td style="width: 100px;">Title:</td>  
                    <td style="width: 400px;"><asp:TextBox ID="DefectTitle" runat="server" 
                            Width="400px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Description:</td>
                    <td><asp:TextBox ID="DefectDescription" runat="server" Rows="4" 
                            TextMode="MultiLine" Width="400px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Attachment:</td>
                    <td><asp:FileUpload ID="DefectFile" runat="server" Width="218px" /></td>
                </tr>
           </tbody>
           <tfoot>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="DefectButtonAdd" runat="server" Text="Add" 
                            CssClass="defaultButton" onclick="DefectButtonAdd_Click" />&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="DefectButtonCancel" runat="server" Text="Cancel" 
                            CssClass="defaultButton" onclick="DefectButtonCancel_Click" />&nbsp;                                               
                    </td>
                </tr>
           </tfoot>
        </table>
    </div>
    </form>
</body>
</html>
