<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="InventoryManagementSystem.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="panSearch" runat="server" style="width:auto; color:Black; font-family:Segoe UI; font-size:14px; float:left; text-align:left; padding:10px; padding-bottom:20px;" >  
            <tr>  
            <td>Employee ID</td>  
            <td><asp:TextBox ID="txtSearch" runat="server"  ></asp:TextBox></td>  
            <td><asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" ></asp:Button></td>  
            </tr>  
            <tr>  
            <td colspan="3" ><asp:Label ID="lblSearchResult" runat="server" Font-Size="Medium" ></asp:Label></td></tr>  
            </table>  
             <hr />  
             <div style="float:left" >  
                 <asp:GridView ID="grdEmployees" runat="server">  
                        <AlternatingRowStyle BackColor="White" />  
                        <HeaderStyle BackColor="#003300" Font-Bold="True" ForeColor="White" />  
                </asp:GridView>  
             </div>  
        </div>
    </form>
</body>
</html>
