<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ass_3_q1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        const getItem = JSON.parse(localStorage.getItem("isLoggedIn"))
        if (getItem) {
            window.location.href = "HomePage.aspx"
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Login Page"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="registerpage" runat="server" OnClick="registerpage_Click" Text="Go to register page" />
            <br />
        </div>
    </form>


</body>
</html>
