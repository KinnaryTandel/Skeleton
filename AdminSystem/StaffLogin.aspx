<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbTitle" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 19px;" Text="Staff Login Page"></asp:Label>
        <div>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 146px; top: 106px; position: absolute; height: 19px;" Text="UserName: "></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 262px; top: 106px; position: absolute"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 146px; top: 163px; position: absolute; height: 19px;" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 262px; top: 163px; position: absolute" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" style="z-index: 1; top: 211px; position: absolute; left: 262px;" Text="Login" width="60px" OnClick="btnLogin_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 211px; position: absolute; left: 359px; margin-top: 0px;" Text="Cancel" width="60px" OnClick="btnCancel_Click" />
            <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; top: 211px; position: absolute; left: 359px; margin-top: 0px;" Text="Cancel" Width="60px" OnClick="btnCancel_Click" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 467px; top: 140px; position: absolute; height: 19px;" ForeColor="#FF3300"></asp:Label>
        </div>
    </form>
</body>
</html>
