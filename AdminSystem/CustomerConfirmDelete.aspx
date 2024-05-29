<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    </form>
        <div>
            <asp:Label ID="lblText" runat="server" style="z-index: 1; top: 50px; left: 100px; position: absolute" Text="Are you sure you want to Delete this record?"></asp:Label>
            <asp:Button ID="btnYes" runat="server" Style="z-index: 1; top: 100px; position: absolute; left: 150px" Text="Yes" Width="60px" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" Style="z-index: 1; top: 100px; position: absolute; left: 250px" Text="No" Width="60px" OnClick="btnNo_Click" />
        </div>
    </body>
</html>
