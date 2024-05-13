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
        <asp:TextBox ID="AirlineID" runat="server" style="z-index: 1; left: 194px; top: 19px; position: absolute; bottom: 607px; height: 18px;" width="175px" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
        <asp:Label ID="lblAirlineID" runat="server" style="z-index: 1; left: 18px; top: 20px; position: absolute" Text="Airline ID" width="152px"></asp:Label>
        </div>
        <div>
        <asp:TextBox ID="AirlinePhoneNumber" runat="server" style="z-index: 1; left: 194px; top: 163px; position: absolute" width="175px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 17px; top: 70px; position: absolute" Text="Name" width="152px"></asp:Label>
        </div>
        <asp:TextBox ID="AirlineName" runat="server" style="z-index: 1; left: 194px; top: 70px; position: absolute; height: 17px; bottom: 583px;" width="175px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 20px; top: 117px; position: absolute" Text="Email" width="152px"></asp:Label>
        <asp:TextBox ID="AirlineEmail" runat="server" style="z-index: 1; left: 194px; top: 119px; position: absolute" width="175px" OnTextChanged="AirlineEmail_TextChanged"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 19px; top: 163px; position: absolute" Text="Phone Number" width="152px"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 17px; top: 208px; position: absolute" Text="Resigistration Date"></asp:Label>
        <asp:TextBox ID="AirlineResigistrationDate" runat="server" style="z-index: 1; left: 194px; top: 207px; position: absolute; width: 178px;"></asp:TextBox>
        
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 281px; position: absolute; height: 22px;"></asp:Label>
       
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 39px; top: 336px; position: absolute; height: 25px;" Text="OK" Width="75px" />
        
        <asp:CheckBox ID="chkWiFi" runat="server" style="z-index: 1; left: 121px; top: 256px; position: absolute" Text="WiFi" Checked="True" />
        
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 146px; top: 336px; position: absolute" Text="Cancel" Height="25px" Width="75px" />
    </form>
</body>
</html>
