<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="ass_3_q1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            change Password Screen<br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="User Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="userName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Old Password"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="oldPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="newPassword1" runat="server" Text="New Password"></asp:Label>
&nbsp;<asp:TextBox ID="newPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="changePassword" runat="server" OnClick="changePassword_Click" Text="Change Password" />
            <br />
        </div>
    </form>
</body>
</html>
