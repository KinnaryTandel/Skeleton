<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlightsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstFlightList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 366px; width: 462px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 9px; top: 424px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 76px; top: 425px; position: absolute" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 580px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 157px; top: 428px; position: absolute" Text="Delete" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 19px; top: 475px; position: absolute" Text="Enter SeatNo"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 129px; top: 471px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" style="z-index: 1; left: 19px; top: 510px; position: absolute" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 177px; top: 512px; position: absolute" Text="Clear Filter" />
    </form>
</body>
</html>
