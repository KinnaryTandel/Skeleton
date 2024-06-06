<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff List Page</title>
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

    form{
       display: flex;
       align-items: center;
       margin: 92px;
       flex-direction: column;
    }

   .buttons {
        height: 35px;
        width: 75px;
        font-family: Arial;
        font-size: 19px;
        margin: 10px;
   }

   .labels{
        font-family: Arial;
        font-size: 25px;
        display: flex;
        padding: 3px;
   }

   .filter{
        height: 26px;
        width: 465px;
        font-family: Arial;
        margin: 10px;
        display: flex;
        justify-content: space-around;
   }
</style>
</head>
<body>
    <h1>
        Staff List Page
    </h1>
    <form id="form1" runat="server" class="form">
        <div>
            <asp:ListBox ID="lstStaffList" runat="server" Height="285px" Width="320px"></asp:ListBox>
        </div>
            
        <div>
            <asp:Button ID="btnAdd" runat="server" class="buttons" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" class="buttons" Text="Edit" OnClick="btnEdit_Click"/>
            <asp:Button ID="btnDelete" runat="server" class="buttons" Text="Delete" OnClick="btnDelete_Click" />
        </div>

        <div>
            <asp:Label ID="lblSearch" runat="server" class="buttons" Text="Enter a Full name"></asp:Label>
            <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        </div>

        <div class="filter">
            <asp:Button ID="btnApply" runat="server" Text="Apply Filter" OnClick="btnApply_Click"/>
            <asp:Button ID="btnClear" runat="server" Text="Clear Filter" OnClick="btnClear_Click"/>
            <asp:Button ID="btnReturnMM" runat="server" Text="Return to Main Menu" OnClick="btnReturnMM_Click" />
        </div>

        <div>
            <asp:Label ID="lblError" runat="server" class="labels" ForeColor= "beige"></asp:Label>
        </div>
    </form>
</body>
</html>
