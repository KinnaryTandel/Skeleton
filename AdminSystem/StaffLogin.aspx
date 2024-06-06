<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Staff Login</title>
    <style>
    body{
        font-family: Arial;
        background-color: #9dc183;
    }

    h1{
        background-color: #819171;
        margin: 0;
        width: 100%;
        height: 60px;
        text-align: center;
        font-size: 50px;
        color: beige;
    }

    form{
       display: flex;
       align-items: center;
       margin: 71px;
       flex-direction: column;
    }

   .buttons {
        height: 35px;
        width: 75px;
        font-family: Arial;
        font-size: 19px;
        margin: 10px;
   }

   .labels{
        font-family: Arial;
        font-size: 25px;
        display: flex;
        padding: 3px;
   }
</style>
</head>
<body>
    <h1>
        <asp:Label ID="lbTitle" runat="server" Text="Staff Login Page"></asp:Label>
    </h1>
    <form id="form1" runat="server" class="form">
        <div>
            <asp:Label ID="lblUserName" runat="server" class="labels" Text="UserName: "></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

            <asp:Label ID="lblPassword" runat="server" class="labels" Text="Password: "></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="btnLogin" runat="server" class="buttons" Text="Login" OnClick="btnLogin_Click" />
            <asp:Button ID="btnCancel" runat="server" class="buttons" Text="Cancel" OnClick="btnCancel_Click" />
        </div>

        <div> 
            <asp:Label ID="lblError" runat="server" class="labels" ForeColor= "#ffd966"></asp:Label>
        </div>
    </form>
</body>
</html>
