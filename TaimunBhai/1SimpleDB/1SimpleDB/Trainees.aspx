<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trainees.aspx.cs" Inherits="_1SimpleDB.Trainees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">

    <h2>FTFL Trainees</h2>

    Total no of trainees: 

        <asp:Label ID="totalTraineeLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="SearchTextBox" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_Click" Text="Search" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
    </form>

    </body>
</html>
