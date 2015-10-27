<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyFirstPage.aspx.cs" Inherits="PrjWebApplication1.MyFirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnClick" runat="server" Text="Click" OnClick="btnClick_Click" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
