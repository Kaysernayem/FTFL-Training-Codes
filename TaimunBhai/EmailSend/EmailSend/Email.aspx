<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Email.aspx.cs" Inherits="EmailSend.Email" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function msg()
        {
            alert("Sure?");
            document.getElementById("Label1").innerHTML="Wait for a moment";
            return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" OnClientClick="return msg();" Text="Button" />
&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
