<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EntryTrainee.aspx.cs" Inherits="_1SimpleDB.EntryTrainee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Add New Trainee</h2>

        Reg ID:<input type="text" name="Id" id="Id" /> <br />
        Name:<input type="text" name="Name" id="Name" /> <br />
        Email:<input type="text" name="Email" id="Email" /> <br />
        Contact:<input type="text" name="Contact" id="Contact" /> <br />
        Address:<input type="text" name="Address" id="Address" /> <br />
        <input type="submit" value="Save" />
    </div>
    </form>
</body>
</html>
