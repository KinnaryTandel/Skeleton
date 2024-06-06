

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <form id="form1" runat="server">
 
            <div>
                <asp:ListBox ID="lstCustomerList" runat="server" Height="285px" Width="320px"></asp:ListBox>
            </div>
            <p>
                <asp:Button ID="btnAdd" runat="server" Style="z-index: 1; left: 21px; top: 340px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
                <asp:Button ID="btnDelete" runat="server" Style="z-index: 1; top: 312px; position: absolute; left: 226px" Text="Delete" Width="60px" OnClick="btnDelete_Click" />
            </p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 80px; top: 341px; position: absolute; width: 49px;" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Label ID="lblSearch" runat="server" style="z-index: 1; left: 36px; top: 376px; position: absolute; height: 19px" Text="Enter a name"></asp:Label>
            <asp:TextBox ID="txtSearch" runat="server" style="z-index: 1; left: 174px; top: 376px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnApplyFilter" runat="server" Style="z-index: 1; top: 423px; position: absolute; left: 50px" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
            <asp:Button ID="btnClearFilter" runat="server" Style="z-index: 1; top: 423px; position: absolute; left: 174px" Text="Clear Filter" OnClick="btnClearFilter_Click" />
           <asp:Button ID="btnReturnToMainMenu" runat="server" Style="z-index: 1; top: 423px; position: absolute; left: 355px;" Text="Return to Main Menu" OnClick="btnReturnToMainMenu_Click" />
             <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 37px; top: 409px; position: absolute" Text="lblError"></asp:Label>
             </p>
        </form>

</body>
    </html>

