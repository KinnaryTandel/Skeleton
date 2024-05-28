<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AirlineList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 680px;
        }
    </style>
</head>
<body style="height: 660px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstAirlineList" runat="server" Height="438px" Width="600px"></asp:ListBox>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 212px; top: 472px; position: absolute; height: 28px; width: 58px" Text="Delete" />
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 198px; top: 519px; position: absolute; right: 1114px"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="margin-left: 24px" Text="Add" Width="60px" />
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 128px; top: 473px; position: absolute; width: 53px; height: 27px;" Text="Edit" />
        <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 20px; top: 582px; position: absolute" Text="Apply Filter" />
        <asp:Label ID="Label1" runat="server" Text="Enter a Airline Name:"></asp:Label>
        <p>
            <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 185px; top: 580px; position: absolute" Text="Clear Filter" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 33px; top: 640px; position: absolute; width: 64px" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
