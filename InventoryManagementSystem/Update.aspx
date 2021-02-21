<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="InventoryManagementSystem.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            background-image: url('images/abbbc.png');
            background-repeat: no-repeat;
            background-attachment: fixed; 
            background-size: 100% 100%;
        }

        .center{
            text-align: center;
        }
       
        .auto-style1 {
            width: 228px;
            color: #000099;
        }
        .auto-style2 {
            width: 356px;
        }
        .auto-style4 {
            width: 1170px;
        }
        .auto-style5 {
            width: 3058px;
            color: #000099;
            font-size: large;
            text-align: center;
        }
       
        .auto-style6 {
            color: #000099;
        }
        .auto-style7 {
            width: 1085px;
            color: #000066;
        }
        .auto-style8 {
            color: #000066;
        }
        .auto-style9 {
            color: #000099;
            font-size: large;
        }
       
        .auto-style10 {
            width: 290px;
        }
       
        .auto-style11 {
            width: 3058px;
            color: #000099;
            font-size: large;
            height: 36px;
            text-align: center;
        }
        .auto-style12 {
            width: 356px;
            height: 36px;
        }
        .auto-style13 {
            color: #000099;
            font-size: large;
            margin-left: 0px;
        }
       
    </style>
</head>
<body>
<div class="center">
    <center>
    <form id="form1" runat="server" class="center">
        <div style="text-align: center">
           <em style="font-size: xx-large"><h1 style="font-size: xx-large"> &nbsp;</h1>
            </em>
        </div>
        <div style="text-align: center">
            <em style="font-size: xx-large">
            <h1 style="font-size: xx-large"> &nbsp;</h1>
            </em>
        </div>
        <div style="text-align: center">
            <em style="font-size: xx-large">
            <h1 style="font-size: xx-large"> &nbsp;</h1>
            </em>
        </div>
        <div style="text-align: center">
            <em style="font-size: xx-large">
            <h1 style="font-size: xx-large"> <span class="auto-style8">Update </span><span class="auto-style7">Product</span></em><em style="font-size: xx-large" class="auto-style6"><br /></h1></em>
        </div>
        <div style="text-align:center">
            &nbsp;<table id="panSearch" runat="server">  
                <tr>  
               <td class="auto-style1">                     </td>
                <td><asp:TextBox ID="txtSearch" runat="server"  Placeholder="Enter Product Name e.g Pens" Width="515px" CssClass="auto-style9" ></asp:TextBox></td>  
                <td class="auto-style10"><asp:Button ID="btnSearch" runat="server" Text="Search"  Width="287px" CssClass="auto-style9" OnClick="btnSearch_Click" ></asp:Button></td>  
                </tr>  
                <tr>  
                <td colspan="3" ><asp:Label ID="lblSearchResult" runat="server" Font-Size="Medium" CssClass="auto-style6" ></asp:Label>
                    <br />
                    </td></tr>   
                 <tr>  
                <td colspan="3" ><asp:Label ID="id" runat="server" Font-Size="Medium" CssClass="auto-style6" ></asp:Label>
                    <br />
                    </td></tr>   
            </table>

            <table id="panUpdate" runat="server" class="auto-style4" width="100%">
                <tr>
                <td colspan="2"><asp:Label ID="lblMsg" runat="server" Font-Size="Medium" CssClass="auto-style6" ></asp:Label>
                    <br />
                    </td>  
                </tr>  
                <tr>  
                <td class="auto-style11">Product ID</td>  
                 <td class="auto-style12"><asp:TextBox ID="prodid" runat="server" CssClass="auto-style13" Width="411px"  ></asp:TextBox>
                     <br />
                    <br />
                    </td>  
                </tr>  
                <tr>  
                <td class="auto-style5">Quantity</td>  
                <td class="auto-style2"><asp:TextBox ID="quantity" runat="server" CssClass="auto-style9" Width="411px"  ></asp:TextBox>
                    <br />
                    <br />
                    </td>  
                </tr>  
                <tr>  
                <td class="auto-style5">Price</td>  
                <td class="auto-style2"><asp:TextBox ID="price" runat="server" CssClass="auto-style9" Width="411px" ></asp:TextBox>
                    <br />
                    <br />
                    </td>  
                </tr>  
                <tr>  
                <td colspan="2">  
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                <asp:Button ID="bntUpdated" runat="server" Text="Update"  style="color: #000066; background-color: #A2D5FC; text-align: center; border-radius: 10px" Width="279px" Height="30px" OnClick="bntUpdated_Click"   />  
                <br /><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnCancel" runat="server" Text="Cancel"  style="color: #000066; background-color: #A2D5FC; text-align: center; border-radius: 10px" Width="279px" Height="30px"   />  
                </td>  
                </tr>  
            </table>  
        </div>
    </form>
    </center>
    </div>
</body>
</html>

