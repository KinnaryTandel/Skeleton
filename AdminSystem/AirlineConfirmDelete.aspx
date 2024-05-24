<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirlineConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 105px; top: 283px; position: absolute" Text="Are you sure you want to delete this record "></asp:Label>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 130px; top: 323px; position: absolute; width: 49px" Text="Yes" />
        </p>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 246px; top: 322px; position: absolute; width: 49px" Text="No" />
    </form>
</body>
</html>
