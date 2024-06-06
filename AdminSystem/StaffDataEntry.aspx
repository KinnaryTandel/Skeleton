<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Staff Data Entry </title>

<style>
    body{
        font-family: Arial;
        background-color: #9dc183
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
       display: grid;
       grid-template-rows: repeat(8, max-content);
       grid-template-columns: max-content min-content auto;
       margin: 10px;
    }

   .buttons {
        height: 35px;
        font-family: Arial;
        font-size: 19px;
        margin: 10px;
   }

   .btn{
       grid-column: span 3;
       margin: 10px;
   }

   .find {
       grid-row: span 8;
       height: 35px;
       width: 60px;
       margin-left: 10px;
   }

   .labels{
        font-family: Arial;
        font-size: 25px;
        padding: 3px;
   }

   .form .checkbox{
       grid-row: span 2;
       font-family: Arial;
       font-size: 25px;
       padding: 3px;
   }

   .center{
       display: flex;
       margin: 92px;
       align-items: center;
       flex-direction: column;
   }
</style>
</head>

<body>
    <h1> Staff Data Entry Page </h1>
    <section class="center">
         <form id="form1" runat="server" class="form">
     
            <asp:Button ID="btnFind" runat="server" class="find" OnClick="btnFind_Click" Text="Find" />
            <asp:Label ID="lblStaffId" runat="server" class="labels" Text="Staff ID" width="90px"></asp:Label>
            <asp:TextBox ID="txtStaffId" runat="server" ></asp:TextBox>
     
            <asp:Label ID="lblFullname" runat="server" class="labels" Text="Full Name"></asp:Label>
            <asp:TextBox ID="txtFullname" runat="server"></asp:TextBox>
     
            <asp:Label ID="lblEmail" runat="server" class="labels" Text="Email" width="75px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
     
            <asp:Label ID="lblPassword" runat="server" class="labels" Text="Password" width="75px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" ></asp:TextBox>
    
            <asp:Label ID="lblPhoneNumber" runat="server" class="labels" Text="Phone No." width="130px"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server" ></asp:TextBox>
     
            <asp:Label ID="lblStartDate" runat="server" class="labels" Text="Start Date"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
     
            <asp:CheckBox ID="chkIsAdmin" class="checkbox" runat="server" Text="Is Admin" />
             
            <div class="btn">
                <asp:Button ID="btnOK" runat="server" class="buttons" Text="OK" OnClick="btnOK_Click"/>
                <asp:Button ID="btnCancel" runat="server" class="buttons" Text="Cancel" OnClick="btnCancel_Click" />
                <asp:Button ID="btnReturnMM" runat="server" class="buttons" Text="Return to Main Menu" OnClick="btnReturnMM_Click" />
            </div>
        </form>

        <div>
            <asp:Label ID="lblError" runat="server" class="labels" ForeColor= "beige"></asp:Label>
        </div>
    </section>

</body>
</html>
