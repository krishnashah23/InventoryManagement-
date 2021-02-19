<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="InventoryManagementSystem.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 300px;
        }
        .auto-style2 {
            width: 300px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            Add New Product<br />
            <br />
        </div>
        <table align="center">
            <tr>
                <td class="auto-style1">Product Id</td>
                <td><asp:TextBox ID="id" runat="server" Width="346px" Height="23px"></asp:TextBox></td>

                <td>
                    <br />
                </td>

            </tr>
            <tr>
                <td class="auto-style1">Name</td>
                <td><asp:TextBox ID="name" runat="server" Width="346px" ></asp:TextBox>
                    <br />
                </td>
            </tr>
             <tr>
                <td class="auto-style1">Category</td>
                <td><asp:TextBox ID="category" runat="server" Width="346px"></asp:TextBox>
                    <br />
                 </td>
            </tr>
             <tr>
                <td class="auto-style1">Quantity</td>
                <td><asp:TextBox ID="quantity" runat="server" Width="346px"></asp:TextBox>
                    <br />
                 </td>
            </tr>
             <tr>
                <td class="auto-style1">Price</td>
                <td><asp:TextBox ID="price" runat="server" Width="346px"></asp:TextBox>
                    <br />
                 </td>
            </tr>
             <tr>
                <td class="auto-style1">Supplier</td>
                <td><asp:TextBox ID="supplier" runat="server" Width="346px"></asp:TextBox>
                    <br />
                 </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnSave" runat="server"  Text="Save" OnClick="btnSave_Click"/>  
                </td>
                <td class="auto-style2">
                    <asp:Button ID="bntReset" runat="server" Text="Reset" />  
                </td>
            </tr>
        </table>
        <div style="margin-left: 600px">
            <asp:Label ID="Label1" runat="server" style="text-align: center" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
