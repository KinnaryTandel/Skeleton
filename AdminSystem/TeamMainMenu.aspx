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
            <asp:Label ID="lblMainTitle" runat="server" style="z-index: 1; left: 480px; top: 15px; position: absolute; height: 19px; font-size: xx-large;" Text="Adventures"></asp:Label>
            <asp:Button ID="btnStaff" runat="server" Style="z-index: 1; top: 75px; left: 335px; position: absolute" Text="Staffs" Width="100px" OnClick="btnStaff_Click" />
            <asp:Button ID="btnCustomer" runat="server" Style="z-index: 1; top: 75px; left: 449px; position: absolute" Text="Customers" Width="100px" OnClick="btnFlight_Click" />
            <asp:Button ID="btnCustomer" runat="server" Style="z-index: 1; top: 75px; left: 449px; position: absolute" Text="Customers" Width="100px" OnClick="btnCustomer_Click" />
            <asp:Button ID="btnFlight" runat="server" Style="z-index: 1; top: 75px; left: 572px; position: absolute" Text="Flights" Width="100px" />
            <asp:Button ID="btnAirline" runat="server" Style="z-index: 1; top: 75px; left: 695px; position: absolute" Text="Airlines" Width="100px" OnClick="btnAirline_Click" />
        </div>
        <asp:Button ID="btnFlight" runat="server" OnClick="btnFlight_Click" style="z-index: 1; left: 577px; top: 74px; position: absolute" Text="Flight" />
    </form>
</body>
</html>
