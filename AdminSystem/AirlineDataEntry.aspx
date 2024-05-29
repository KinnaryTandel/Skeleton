<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirlineDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 11px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        <div> 
        <asp:TextBox ID="txtAirlineID" runat="server" style="z-index: 1; left: 194px; top: 22px; position: absolute; bottom: 420px; height: 18px;" width="175px" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
        <asp:Label ID="lblAirlineID" runat="server" style="z-index: 1; left: 18px; top: 24px; position: absolute" Text="Airline ID" width="152px"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="txtAirlinePhoneNumber" runat="server" style="z-index: 1; left: 194px; top: 163px; position: absolute; bottom: 533px; width: 172px; height: 18px;"></asp:TextBox>
        <asp:Label ID="lblAirlineName" runat="server" style="z-index: 1; left: 17px; top: 72px; position: absolute; bottom: 372px;" Text="Name" width="152px"></asp:Label>
            <asp:Button ID="btnFind" runat="server" Height="27px" OnClick="btnFind_Click" style="margin-left: 424px; margin-top: 0px" Text="Find" Width="67px" />
        </div>
        <asp:TextBox ID="txtAirlineName" runat="server" style="z-index: 1; left: 194px; top: 72px; position: absolute; height: 17px; bottom: 371px;" width="175px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <asp:Label ID="lblAirlineEmail" runat="server" style="z-index: 1; left: 20px; top: 120px; position: absolute" Text="Email" width="152px"></asp:Label>
        <asp:TextBox ID="txtAirlineEmail" runat="server" style="z-index: 1; left: 194px; top: 119px; position: absolute" width="175px" OnTextChanged="AirlineEmail_TextChanged"></asp:TextBox>
        <asp:Label ID="lblAirlinePhoneNumber" runat="server" style="z-index: 1; left: 19px; top: 164px; position: absolute; right: 1203px;" Text="Phone Number" width="152px"></asp:Label>
        <asp:Label ID="lblAirlineResigistrationDate" runat="server" style="z-index: 1; left: 17px; top: 214px; position: absolute; right: 1237px;" Text="Resigistration Date"></asp:Label>
        <asp:TextBox ID="txtAirlineResigistrationDate" runat="server" style="z-index: 1; left: 194px; top: 212px; position: absolute; width: 178px;"></asp:TextBox>
        
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 289px; position: absolute; height: 22px;"></asp:Label>
       
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 39px; top: 347px; position: absolute; height: 25px;" Text="OK" Width="75px" />
        
        <asp:CheckBox ID="chkWiFi" runat="server" style="z-index: 1; left: 127px; top: 262px; position: absolute" Text="WiFi" Checked="True" />
        
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 147px; top: 347px; position: absolute; right: 915px;" Text="Cancel" Height="25px" Width="75px" OnClick="btnCancel_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnMainMenu" runat="server" style="z-index: 1; left: 300px; top: 347px; position: absolute" Text="Return To Main Menu" Width="224px" OnClick="btnMainMenu_Click"/>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
