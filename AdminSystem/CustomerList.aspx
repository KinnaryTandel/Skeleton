

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
                <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 15px; top: 329px; position: absolute" Text="Add" />
            </p>
        </form>

</body>
    </html>

