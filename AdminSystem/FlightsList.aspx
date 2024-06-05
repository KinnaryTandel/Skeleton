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
    </form>
</body>
</html>
