<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Main Menu</title>
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

        div{
           display: flex;
           flex-direction: row;
           justify-content: space-evenly;
           align-items: center;
           padding-bottom: 10px;
        }

       .buttons {
            height: 35px;
            width: 150px;
            font-family: Arial;
            font-size: 25px;
       }
    </style>

</head>
<body>
    <h1>
        <asp:Label ID="lblMainTitle" runat="server" Text="Adventures"></asp:Label>
    </h1>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnStaff" runat="server" class="buttons" Text="Staffs" OnClick="btnStaff_Click" />
            <asp:Button ID="btnCustomer" runat="server" class="buttons" Text="Customers" OnClick="btnCustomer_Click" />
            <asp:Button ID="btnFlight" runat="server" class="buttons" Text="Flights" OnClick="btnFlight_Click" />
            <asp:Button ID="btnAirline" runat="server" class="buttons" Text="Airlines" OnClick="btnAirline_Click" />
        </div>
    </form>
</body>
</html>
