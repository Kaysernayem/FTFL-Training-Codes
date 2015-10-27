<%@ Page Title="" Language="C#" MasterPageFile="~/Main1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PMS3LayerBARD.UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
    <table border="1">
            <tr>
                <td>User Name: </td>
                <td><asp:TextBox ID="UserNamTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password: </td>
                <td><asp:TextBox ID="PassTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="LoginButton" runat="server" OnClick="LoginButton_Click" Text="Submit" />
                </td>
                <td>
                    <asp:Label ID="errorLabel" runat="server"></asp:Label>
                </td>
            </tr>
    </table>
        
    </form>
</asp:Content>
