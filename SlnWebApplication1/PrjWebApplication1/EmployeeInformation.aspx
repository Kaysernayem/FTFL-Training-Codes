<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeInformation.aspx.cs" Inherits="PrjWebApplication1.EmployeeInformation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Information</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" Text="Enter Employee Information"></asp:Label>
                    </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>
                        <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox></td>
            </tr>
                        <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
            </tr>
                        <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Contact"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtContact" runat="server"></asp:TextBox></td>
            </tr>
                        <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Emp ID"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
            </tr>
                        <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Department"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" Width="202px" /></td>
            </tr>
        </table>
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="EmployeeId" DataSourceID="SqlDataSourceEmployeeDataShow">
            <Columns>
                <asp:BoundField DataField="EmployeeId" HeaderText="Employee Id" ReadOnly="True" SortExpression="EmployeeId" />
                <asp:BoundField DataField="EmployeeName" HeaderText="Employee Name" SortExpression="EmployeeName" />
                <asp:BoundField DataField="EmployeeAge" HeaderText="Employee Age" SortExpression="EmployeeAge" />
                <asp:BoundField DataField="EmployeeAddress" HeaderText="Employee Address" SortExpression="EmployeeAddress" />
                <asp:BoundField DataField="EmployeeContact" HeaderText="Employee Contact No" SortExpression="EmployeeContact" />
                <asp:BoundField DataField="EmployeeDepartment" HeaderText="Employee Department" SortExpression="EmployeeDepartment" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceEmployeeDataShow" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [tblEmployee] ORDER BY [EmployeeName]"></asp:SqlDataSource>
    </form>
</body>
</html>
