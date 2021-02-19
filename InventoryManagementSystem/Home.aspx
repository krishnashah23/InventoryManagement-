<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="InventoryManagementSystem.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            text-align: center;
        }
        .auto-style1 {
            font-size: large;
            text-decoration: underline;
        }
        .auto-style2 {
            font-size: large;
            color: #FF0066;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">  

         <strong><span class="auto-style1"><em style="color: #CC0066; font-size: xx-large">SuperMarket Inventory</em></span></strong><br />
         <br />
         <h3>
         <a href="Add.aspx" ><span class="auto-style2"><em>Add New Product</em></span></a><em><br class="auto-style2" />
         <br class="auto-style2" />
             </em>&nbsp;<a href="Update.aspx"><span class="auto-style2"><em>Update Products</em></span></a><em><br class="auto-style2" />
             </em>&nbsp;<em><br class="auto-style2" />
             </em>
         <a href ="Delete.aspx"><span class="auto-style2"><em>Delete Products</em></span></a>
         <em>
         <br class="auto-style2" />
         <br class="auto-style2" />
             </em>
         <a href="ViewAll.aspx"><span class="auto-style2"><em>View All Products</em></span></a>
         <em>
         <br class="auto-style2" />

             </em></h3>

     </form>
</body>
</html>
