<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="InventoryManagementSystem.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
                
        body {
            background-image: url('images/abbbc.png');
            background-repeat: no-repeat;
            background-attachment: fixed; 
            background-size: 100% 100%;
        }

        .center{
             text-align: center;
        }
        .auto-style3 {
            width: 300px;
            font-size: large;
            color: #000099;
            font-weight: bold;
            text-align: center;
        }
        .auto-style4 {
            color: #000099;
        }
        .auto-style5 {
            color: #000066;
        }
        .auto-style6 {
            color: #000099;
            font-size: large;
        }
        .auto-style7 {
            width: 354px;
            text-align: center;
        }
        .auto-style8 {
            font-weight: normal;
            font-size: small;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
           <em style="font-size: xx-large"><h1 style="font-size: xx-large" class="center"> &nbsp;</h1>
            <h1 style="font-size: xx-large" class="center"> &nbsp;</h1>
            <h1 style="font-size: xx-large" class="center"> &nbsp;</h1>
            <h1 style="font-size: xx-large" class="center"> <span class="auto-style5">Add New Product</span></em><em style="color: #CC0066; font-size: xx-large"><br /></h1>
            </em>
        </div>
        <table align="center" >
            <tr>
                <td class="auto-style3"><em class="auto-style6">Product Id              <td class="auto-style7"><asp:TextBox ID="id" runat="server" Width="346px" Height="23px"></asp:TextBox>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><em class="auto-style4">Name</em></td>
                <td class="auto-style7"><asp:TextBox ID="name" runat="server" Width="346px" Height="23px"></asp:TextBox>
                    <br />
                    <br />
                </td>
            </tr>
             <tr>
                <td class="auto-style3"><em class="auto-style4">Category</em></td>
                <td class="auto-style7"><asp:TextBox ID="category" runat="server" Width="346px" Height="23px"></asp:TextBox>
                    <br />
                    <br />
                 </td>
            </tr>
             <tr>
                <td class="auto-style3"><em class="auto-style4">Quantity
                    <br />
                    </em><span class="auto-style8">(Number of packets)</span></td>
                <td class="auto-style7"><asp:TextBox ID="quantity" runat="server" Width="346px" Height="23px"></asp:TextBox>
                    <br />
                    <br />
                 </td>
            </tr>
             <tr>
                <td class="auto-style3"><em class="auto-style4">Price<br />
                    </em><span class="auto-style8">(Price per packet)</span></td>
                <td class="auto-style7"><asp:TextBox ID="price" runat="server" Width="346px" Height="23px"></asp:TextBox>
                    <br />
                    <br />
                 </td>
            </tr>
             <tr>
                <td class="auto-style3"><em class="auto-style4">Supplier</em></td>
                <td class="auto-style7"><asp:TextBox ID="supplier" runat="server" Width="346px" Height="23px"></asp:TextBox><br />
                 </td>
            </tr>
            </table>
            <div class="center">
            <br />
            </div>
        <div class="center">
                <asp:Button ID="btnSave" runat="server"  Text="Save" OnClick="btnSave_Click" style="color: #000066; background-color: #A2D5FC; text-align: center; border-radius: 10px" Width="206px" Height="30px"/>  
                <br/><br />
                <asp:Button ID="bntReset" runat="server" Text="Reset" style="color: #000066; background-color: #A2D5FC; border-radius: 10px" Width="206px" Height="30px" OnClick="bntReset_Click" />  
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="" style="color: #000066; font-size: medium"></asp:Label>
            <br />
            <br />
            <a href="Add.aspx"><span class="auto-style6">Add Another Product</span></a><br class="auto-style6" />
            <br class="auto-style6" />
            <a href="Home.aspx"><span class="auto-style6">Home</span></a></div>
    </form>
</body>
</html>
