<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebBankCRM.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Logowanie</title>
    <link href="https://fonts.googleapis.com/css?family=Baloo+Bhai&display=swap" rel="stylesheet"/>
    <link href="login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="Login">

            <asp:Label ID="LblLogin" runat="server" Text="Login"></asp:Label>

            <asp:TextBox ID="TxtBoxLogin" runat="server"></asp:TextBox>

            <asp:Label ID="LblPassword" runat="server" Text="Hasło"></asp:Label>

            <asp:TextBox ID="TxtBoxPassword" runat="server"></asp:TextBox>

            <asp:Button class="button" ID="BtnLogin" runat="server" Text="Zaloguj" OnClick="BtnLogin_Click" />

            <asp:Label ID="LblMessage" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
