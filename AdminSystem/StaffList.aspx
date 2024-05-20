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
        </div>
    </form>
</body>
</html>
