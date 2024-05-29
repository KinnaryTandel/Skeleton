<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMainTitle" runat="server" style="z-index: 1; left: 480px; top: 15px; position: absolute; height: 19px; font-size: xx-large;" Text="Adventures"></asp:Label>
            <asp:Button ID="btnStaff" runat="server" Style="z-index: 1; top: 75px; left: 335px; position: absolute" Text="Staffs" Width="100px" OnClick="btnStaff_Click" />
            <asp:Button ID="btnCustomer" runat="server" Style="z-index: 1; top: 75px; left: 449px; position: absolute" Text="Customers" Width="100px" OnClick="btnFlight_Click" />
            <asp:Button ID="btnFlight" runat="server" Style="z-index: 1; top: 75px; left: 572px; position: absolute" Text="Flights" Width="100px" />
            <asp:Button ID="btnAirline" runat="server" Style="z-index: 1; top: 75px; left: 695px; position: absolute" Text="Airlines" Width="100px" OnClick="btnAirline_Click" />
        </div>
    </form>
</body>
</html>
