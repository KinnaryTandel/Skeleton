

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
                <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 21px; top: 340px; position: absolute" Text="Add" />
                <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 156px; top: 341px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
            </p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 80px; top: 341px; position: absolute; width: 49px;" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 37px; top: 409px; position: absolute" Text="lblError"></asp:Label>
        </form>

</body>
    </html>

