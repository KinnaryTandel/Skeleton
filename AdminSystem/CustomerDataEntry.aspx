<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 11px; top: 21px; position: absolute; height: 15px" Text="Customer Id" width="128px"></asp:Label>
        <p>
            <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 163px; top: 110px; position: absolute" width="168px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; top: 22px; position: absolute; left: 163px; width: 168px;"></asp:TextBox>
        </p>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 10px; top: 60px; position: absolute; height: 22px; width: 128px; right: 1448px;" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 163px; top: 57px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 10px; top: 111px; position: absolute; height: 16px; width: 128px; right: 616px" Text="Email"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblPaymentDetails" runat="server" style="z-index: 1; left: 12px; top: 156px; position: absolute; bottom: 388px" Text="Payment Details" width="128px"></asp:Label>
        <asp:TextBox ID="txtPaymentDetails" runat="server" style="z-index: 1; left: 163px; top: 156px; position: absolute" width="168px"></asp:TextBox>
        <asp:Label ID="lblBookingId" runat="server" style="z-index: 1; left: 11px; top: 200px; position: absolute; height: 36px; width: 128px;" Text="Booking Id"></asp:Label>
        <asp:TextBox ID="txtBookingId" runat="server" style="z-index: 1; left: 163px; top: 198px; position: absolute" width="168px"></asp:TextBox>
        <p>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 452px; top: 22px; position: absolute" Text="Find" />
        </p>
        <p aria-autocomplete="none">
            &nbsp;</p>
        <asp:Label ID="lblBookingDate" runat="server" style="z-index: 1; left: 12px; top: 248px; position: absolute; height: 44px; width: 128px" Text="Date Added"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 163px; top: 244px; position: absolute" width="168px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 165px; top: 306px; position: absolute" Text="Active" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 338px; position: absolute" width="128px"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 119px; top: 397px; position: absolute" Text="Cancel" />
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 14px; top: 397px; position: absolute; right: 615px;" Text="OK" width="77px" />
        </p>
    </form>
</body>
</html>
