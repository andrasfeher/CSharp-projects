<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DefectUI._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Defect Manager</title>
    <link rel="Stylesheet" href="style.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="container"> 
    <div id="main">
        <asp:GridView ID="DeftectsGridView" runat="server" 
            DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" 
            CellPadding="4" DataKeyNames="Id" ForeColor="#333333" GridLines="None" 
            AllowPaging="True" AllowSorting="True" 
            >
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="CreatedBy" HeaderText="CreatedBy" 
                    SortExpression="CreatedBy" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#999999" />
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
          SelectMethod="ListDefects" TypeName="DefectUI.ListClass, DefectUI" SortParameterName="Column"
        >
            <SelectParameters>
                <asp:ControlParameter ControlID="DeftectsGridView" Name="Column" 
                    PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        <br />
        <asp:DetailsView ID="DefectsDetailsView" runat="server" Height="50px" 
            Width="713px" CellPadding="4" ForeColor="#333333" GridLines="None" 
            AutoGenerateRows="False" DataSourceID="ObjectDataSource2">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
            <RowStyle BackColor="#EFF3FB" />
            <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <Fields>
                <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" 
                    SortExpression="Id" />
                <asp:BoundField DataField="Title" HeaderText="Title" ReadOnly="True" 
                    SortExpression="Title" />
                <asp:TemplateField HeaderText="Description" SortExpression="Description">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Height="70px" ReadOnly="True" 
                            Text='<%# Eval("Description") %>' TextMode="MultiLine" Width="690px"></asp:TextBox>
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Height="70px" 
                            Text='<%# Bind("Description") %>' TextMode="MultiLine" Width="690px"></asp:TextBox>
                    </InsertItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Height="70px" ReadOnly="True" 
                            Text='<%# Eval("Description") %>' TextMode="MultiLine" Width="690px"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CreatedBy" HeaderText="CreatedBy" ReadOnly="True" 
                    SortExpression="CreatedBy" />
                <asp:BoundField DataField="CreatedDate" HeaderText="CreatedDate" 
                    ReadOnly="True" SortExpression="CreatedDate" />
                <asp:BoundField DataField="AssignedTo" HeaderText="AssignedTo" ReadOnly="True" 
                    SortExpression="AssignedTo" />
                <asp:BoundField DataField="AssignedDate" HeaderText="AssignedDate" 
                    ReadOnly="True" SortExpression="AssignedDate" />
                <asp:BoundField DataField="ClosedDate" HeaderText="ClosedDate" ReadOnly="True" 
                    SortExpression="ClosedDate" />
            </Fields>
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:DetailsView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
            SelectMethod="GetDefect" TypeName="DefectUI.ListClass, DefectUI">
            <SelectParameters>
                <asp:ControlParameter ControlID="DeftectsGridView" Name="id" 
                    PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
        
        
        
        
        <asp:Table ID="Table1" runat="server" Width="413px" CellSpacing="10">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server"><asp:Button ID="btAddNewDefect" runat="server" onclick="btAddNewDefect_Click" 
            Text="Új felvétel" Width="100px" /></asp:TableCell>
                <asp:TableCell runat="server"><asp:Button ID="btKivetel" runat="server" onclick="btKivetel_Click" 
            Text="Kivétel" Width="100px" /></asp:TableCell>
                <asp:TableCell runat="server"><asp:Button ID="btMegoldas" runat="server" Text="Megoldás" 
            onclick="btMegoldas_Click" Width="100px" /></asp:TableCell>
                <asp:TableCell runat="server"><asp:Button ID="btLezaras" runat="server" Text="Lezárás" 
            onclick="btLezaras_Click" Width="100px" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
    </div>
    </div>
    </form>
</body>
</html>
