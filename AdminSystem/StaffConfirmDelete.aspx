<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirm Delete </title>
    <style>
    body{
        font-family: Arial;
        background-color: #9dc183;
    }

    h1{
        background-color: #819171;
        margin: 0;
        width: 100%;
        height: 60px;
        text-align: center;
        font-size: 50px;
        color: beige;
    }

    div{
       display: flex;
       flex-direction: column;
       align-items: center;
       padding-bottom: 10px;
    }

   .buttons {
        height: 35px;
        width: 150px;
        font-family: Arial;
        font-size: 25px;
        margin: 10px;
   }

   .labels{
     font-family: Arial;
     font-size: 25px;
     display: flex;
     padding: 3px;
   }
</style>
</head>
<body>
    <h1>Confirm Delete</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblText" runat="server" class="labels" Text="Are you sure you want to Delete this record?"></asp:Label>
            <asp:Button ID="btnYes" runat="server" class="buttons" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" class="buttons" Text="No" OnClick="btnNo_Click" />
        </div>
    </form>
</body>
</html>
