<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAll.aspx.cs" Inherits="InventoryManagementSystem.ViewAll" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            background-image: url('images/abbc.png');
            background-repeat: no-repeat;
            background-attachment: fixed; 
            background-size: 100% 100%;
        }

        .center{
             text-align: center;
        }

        .auto-style1 {
            color: #000066;
        }

        .auto-style2 {
            text-align: center;
            font-size: large;
        }
        .auto-style3 {
            color: #000099;
        }

        .auto-style4 {
            font-size: large;
        }

    </style>
</head>
<body>
     <div style="text-align: center">
           <em style="font-size: xx-large">
           <h1 style="font-size: xx-large"> <span class="auto-style1">All Product</span></em><em style="font-size: xx-large" class="auto-style6"><span class="auto-style1">s</span><br /></h1>
           </em>
        </div>
     <form id="form1" runat="server" class="center">
       
        
     <p class="center">
         <asp:GridView ID="grdEmployees" runat="server">  
           <AlternatingRowStyle BackColor="White" />  
           <HeaderStyle BackColor="#003300" Font-Bold="True" ForeColor="White" />  
       </asp:GridView>
         </p>
         <p class="center">
             &nbsp;</p>
         <p class="auto-style2">
             <a href="Home.aspx"><span class="auto-style3">Home&nbsp;</span></a></p>
      </form>
</body>
</html>
