<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 411px">
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 19px;" Text="Staff ID" width="71px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 89px; top: 14px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblFullname" runat="server" style="z-index: 1; left: 11px; top: 47px; position: absolute; width: 71px" Text="Full Name"></asp:Label>
        <asp:TextBox ID="txtFullname" runat="server" style="z-index: 1; left: 89px; top: 46px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 89px; top: 82px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 12px; top: 122px; position: absolute" Text="Password" width="71px"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 89px; top: 122px; position: absolute" width="128"></asp:TextBox>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 9px; top: 84px; position: absolute" Text="Email" width="71px"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 12px; top: 164px; position: absolute; height: 19px" Text="Phone No." width="71px"></asp:Label>
        <asp:Label ID="lblStartDate" runat="server" style="z-index: 1; left: 11px; top: 202px; position: absolute; width: 71px" Text="Start Date"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server" style="z-index: 1; left: 89px; top: 201px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkIsAdmin" runat="server" style="z-index: 1; left: 89px; top: 232px; position: absolute" Text="Is Admin" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 267px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; top: 312px; position: absolute" Text="OK" width="60px" />
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 89px; top: 164px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 312px; position: absolute; left: 89px" Text="Cancel" width="60px" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; top: 15px; position: absolute; left: 300px;" OnClick="btnFind_Click" Text="Find" Width="60px" />
    </form>
</body>
</html>
