<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="285px" Width="320px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" Style="z-index: 1; top: 312px; position: absolute; left: 10px" Text="Add" Width="60px" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Style="z-index: 1; top: 312px; position: absolute; left: 100px" Text="Edit" Width="60px" OnClick="btnEdit_Click"/>
            <asp:Button ID="btnDelete" runat="server" Style="z-index: 1; top: 312px; position: absolute; left: 195px" Text="Delete" Width="60px" OnClick="btnDelete_Click" />
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top:375px; position: absolute"></asp:Label>
    </form>
</body>
</html>
