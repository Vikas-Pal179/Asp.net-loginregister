<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="ass_3_q1.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        window.onload = function () {
        const lsGet = JSON.parse(localStorage.getItem("userObj")); 
         console.log(lsGet,"lsget")
            if (lsGet) {
                document.getElementById("Label1").innerHTML = "User Name is:" + lsGet.username;
                document.getElementById("Label2").innerHTML = "Password is:" + lsGet.password
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            this is a profile page
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="User Name is:"></asp:Label>
&nbsp;<br />
            <asp:Label ID="Label2" runat="server" Text="Password is:"></asp:Label>
&nbsp;</div>
    </form>
</body>
</html>
