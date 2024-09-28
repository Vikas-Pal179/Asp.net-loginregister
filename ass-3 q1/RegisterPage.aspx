<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ass_3_q1.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Register Page"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="User Name"></asp:Label>
&nbsp;
            <asp:TextBox ID="userName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Email"></asp:Label>
&nbsp;
            <asp:TextBox ID="email" runat="server" Width="187px"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
&nbsp;
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Confirm Password"></asp:Label>
&nbsp;
            <asp:TextBox ID="confirmPassword" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;<asp:Button ID="register" runat="server" OnClick="register_Click" Text="Register" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Go to login page"></asp:Label>
&nbsp;<asp:Button ID="LoginPage" runat="server" OnClick="LoginPage_Click" Text="Login page" />
        </div>
    </form>


</body>
</html>
