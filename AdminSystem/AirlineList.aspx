<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirlineList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstAirlineList" runat="server" Height="465px" Width="600px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="margin-left: 24px" Text="Add" Width="60px" />
        </p>
    </form>
</body>
</html>
