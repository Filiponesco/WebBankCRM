<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebBankCRM.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Bank CRM</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
                <ul id="lista" runat="server">
                    <li><a class="active" runat="server" href="~/Index.aspx">Strona główna</a></li>
                    <li><a runat="server" href="~/Zadania">Zadania</a></li>
                    <li><a runat="server" href="~/WebForm1.aspx">Klienci</a></li>
                    <li><a runat="server" href="~/Credits.aspx">Kredyty</a></li>
                    <li style="float:right" ><a runat="server" href="~/Login.aspx">Wyloguj</a></li>
                </ul>
            </nav>
        </div>
    </form>
</body>
</html>
