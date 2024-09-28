<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ass_3_q1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <script>
     const isUserLogggedIn= JSON.parse(localStorage.getItem("isLoggedIn"))
         if (!isUserLogggedIn) {
         window.location.href = "LoginPage.aspx"
     }
     </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="welcome to the home page"></asp:Label>
        <div>
            <asp:Button ID="changePassword" runat="server" OnClick="changePassword_Click" Text="Chnage Password" />
            <br />
            <asp:Button ID="logout" runat="server" OnClick="logout_Click" Text="Logout" />
            <br />
            <br />
            <asp:Button ID="viewProfile" runat="server" OnClick="viewProfile_Click" Text="View Profile" />
        </div>
        <p>
            <br />
            <asp:Button ID="uploadProfilePhoto" runat="server" OnClick="uploadProfilePhoto_Click" Text="Upload Profile Photo" />
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
