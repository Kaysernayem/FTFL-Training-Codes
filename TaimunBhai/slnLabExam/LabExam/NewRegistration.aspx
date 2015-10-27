<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewRegistration.aspx.cs" Inherits="LabExam.NewRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
    <script type="text/javascript">
        function Validation() {
            var uid = document.getElementById('<%=txtUserID.ClientID %>').value;
            var name = document.getElementById('<%=txtName.ClientID %>').value;
            var pass = document.getElementById('<%=TxtPassword.ClientID %>').value;
            var cpass = document.getElementById('<%=TxtConfirmPassword.ClientID %>').value;
            var track = document.getElementById('<%=DDTrack.ClientID %>').value;
            var gender = document.getElementById('<%=RadioButtonList1.ClientID %>').value;

            if (uid = "") {
                alert("Please provide User ID");
                return false;
            }
            if (name = "") {
                alert("Please provide your name");
                return false;
            }
            if (pass = "") {
                alert("please provide your password");
                return false;
            }
            if (pass != cpass) {
                alert("password dont match");
                return false;
            }
            if (track = "") {
                alert("please select your track");
                return false;
            }
            if (gender = "") {
                alert("Please select gender");
                return false;
            }
        }
    </script>
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="1">
        <tr>
            <td>User ID: </td>
            <td>
                <asp:TextBox ID="txtUserID" Name="uid" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Name: </td>
            <td>
                <asp:TextBox ID="txtName" Name="name" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password: </td>
            <td><asp:TextBox ID="TxtPassword" Name="pw" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Confirm Password: </td>
            <td><asp:TextBox ID="TxtConfirmPassword" Name="cpw" runat="server"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TxtConfirmPassword" ControlToValidate="TxtPassword" ErrorMessage="Both password dont match" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>Track: </td>
            <td>
                <asp:DropDownList ID="DDTrack" Name="track" runat="server">
                    <asp:ListItem>Dotnet</asp:ListItem>
                    <asp:ListItem>PHP</asp:ListItem>
                    <asp:ListItem>Android</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td>Gender: </td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" Name="gender" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="return validate();" Text="Submit"/>
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reset" />
            </td>
        </tr>
        <tr>
            <td>

                <asp:Label ID="Label1" runat="server"></asp:Label>

            </td>
        </tr>

    </table>
    </div>
    </form>
</body>
</html>
