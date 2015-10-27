<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentInformation.aspx.cs" Inherits="PrjWebApplication1.StudentInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Information</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Enter Student Information"></asp:Label>
                    </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtSName" runat="server"></asp:TextBox></td>
            </tr>
                        <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtSAge" runat="server"></asp:TextBox></td>
            </tr>
                        <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtSAddress" runat="server"></asp:TextBox></td>
            </tr>
                        <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Contact"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtSContact" runat="server"></asp:TextBox></td>
            </tr>
                        <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Roll No"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtSRollNo" runat="server"></asp:TextBox></td>
            </tr>
                        <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Marks"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtSMarks" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Width="202px" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
