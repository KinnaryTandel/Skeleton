<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlightLogin.aspx.cs" Inherits="FlightLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 417px; top: 209px; position: absolute" Text="UserName"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 419px; top: 246px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 539px; top: 209px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 536px; top: 252px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 765px; top: 228px; position: absolute"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 494px; top: 323px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 622px; top: 326px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
