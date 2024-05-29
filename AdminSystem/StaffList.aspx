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
            <asp:Button ID="btnAdd" runat="server" Style="z-index: 1; top: 313px; position: absolute; left: 44px; right: 1735px;" Text="Add" Width="60px" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Style="z-index: 1; top: 313px; position: absolute; left: 136px" Text="Edit" Width="60px" OnClick="btnEdit_Click"/>
            <asp:Button ID="btnDelete" runat="server" Style="z-index: 1; top: 312px; position: absolute; left: 226px" Text="Delete" Width="60px" OnClick="btnDelete_Click" />
        </div>
        <div>
            <asp:Label ID="lblSearch" runat="server" style="z-index: 1; left: 36px; top: 376px; position: absolute; height: 19px" Text="Enter a Full name"></asp:Label>
            <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 174px; top: 376px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" Style="z-index: 1; top: 423px; position: absolute; left: 50px" Text="Apply Filter" OnClick="btnApply_Click"/>
            <asp:Button ID="btnClear" runat="server" Style="z-index: 1; top: 423px; position: absolute; left: 174px" Text="Clear Filter" OnClick="btnClear_Click"/>
            <asp:Button ID="btnReturnMM" runat="server" Style="z-index: 1; top: 423px; position: absolute; left: 355px;" Text="Return to Main Menu" OnClick="btnReturnMM_Click" />
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top:475px; position: absolute"></asp:Label>
    </form>
</body>
</html>
