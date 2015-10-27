<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1SimpleDB.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Welcome to FTFL</h2>


        <br />
        <asp:LinkButton ID="noOfTrainLinkButton" runat="server" OnClick="noOfTrainLinkButton_Click">Total no of Trainees</asp:LinkButton>


        <br />
        <br />
        <asp:LinkButton ID="addTrainmeeLinkButton" runat="server" OnClick="addTraineeLinkButton_Click">Add new Trainee</asp:LinkButton>


    </div>
    </form>
</body>
</html>
