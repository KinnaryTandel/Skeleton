<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirlineList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Airline List Management</title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
     <h1>Airline List Management</h1>
     <div>
                <asp:Label ID="Label1" runat="server" Text="Enter an Airline Name:"></asp:Label>
                <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:ListBox ID="lstAirlineList" runat="server" Height="386px" Width="600px"></asp:ListBox>
            </div>
            <div>
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
                <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" style="margin-left: 2px" Width="51px" />
                <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" Text="Apply Filter" style="margin-left: 197px" />
                <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" Text="Clear Filter" style="margin-left: 12px" />
            </div>
            <div>
            </div>
        </div>
        <p>
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </p>
        <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" style="z-index: 1; top: 514px; position: absolute; height: 22px; width: 139px; left: 166px; right: 1246px" Text="Return To Main Menu" />
    </form>
</body>
</html>
