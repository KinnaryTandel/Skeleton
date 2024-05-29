<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirlineLogin.aspx.cs" Inherits="AirlineLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Airline Login Page</div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 154px; top: 191px; position: absolute" Text="UserName:"></asp:Label>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 153px; top: 234px; position: absolute; width: 34px" Text="Password:"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 234px; top: 191px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 234px; top: 235px; position: absolute" TextMode="Password"></asp:TextBox>
        </p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 163px; top: 283px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 248px; top: 282px; position: absolute; height: 26px; bottom: 368px" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 426px; top: 243px; position: absolute"></asp:Label>
    </form>
</body>
</html>
