<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirlineList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 562px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstAirlineList" runat="server" Height="465px" Width="600px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="margin-left: 24px" Text="Add" Width="60px" />
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 136px; top: 498px; position: absolute; width: 53px" Text="Edit" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 39px; top: 546px; position: absolute; width: 45px" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
