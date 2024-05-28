<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlightsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body style="height: 980px">
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="lblFlightID" runat="server" EnableTheming="False" style="z-index: 1; left: 347px; top: 90px; position: absolute" Text="Flight ID"></asp:Label>
            
        </div>
       
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="txtFlightID" runat="server" style="z-index: 1; left: 458px; top: 90px; position: absolute"></asp:TextBox>
       
            &nbsp;</p>
        <asp:Label ID="lblDeparture" runat="server" style="z-index: 1; left: 347px; top: 173px; position: absolute; bottom: 484px" Text="Departure"></asp:Label>
        <asp:TextBox ID="txtDeparture" runat="server" style="z-index: 1; left: 458px; top: 175px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtArrival" runat="server" style="z-index: 1; left: 458px; top: 216px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblArrival" runat="server" style="z-index: 1; left: 347px; top: 213px; position: absolute; bottom: 444px" Text="Arrival"></asp:Label>
        <asp:Label ID="lblDateandTime" runat="server" style="z-index: 1; left: 347px; top: 261px; position: absolute" Text="Dateandtime"></asp:Label>
        <asp:TextBox ID="txtDateandTime" runat="server" style="z-index: 1; left: 458px; top: 259px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTicketPrice" runat="server" style="z-index: 1; left: 458px; top: 302px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblTicketPrice" runat="server" style="z-index: 1; left: 347px; top: 305px; position: absolute" Text="Ticket Price"></asp:Label>
        <asp:CheckBox ID="chkFlightStatus" runat="server" style="z-index: 1; left: 483px; top: 371px; position: absolute" Text="FlightStatus" />
        <asp:Label ID="lblSeatNo" runat="server" style="z-index: 1; left: 348px; top: 126px; position: absolute" Text="SeatNo"></asp:Label>
        <asp:TextBox ID="txtSeatNo" runat="server" style="z-index: 1; left: 458px; top: 127px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 376px; top: 376px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 373px; top: 436px; position: absolute" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 508px; top: 437px; position: absolute" Text="Cancel" />
       
        <p>
            &nbsp;</p>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 661px; top: 310px; position: absolute" Text="Find" />
       
    </form>
</body>
</html>
