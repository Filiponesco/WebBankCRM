<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebBankCRM.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Bank CRM</title>
    <link href="Style.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Baloo+Bhai&display=swap" rel="stylesheet"/>
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
                    <li><a runat='server' href='~/Uzytkownicy.aspx'>Użytkownicy</a></li>
                    <li style="float:right" ><a runat="server" href="~/Login.aspx">Wyloguj</a></li>
                </ul>
            </nav>
        </div>
        <div id="content">
            <h1>CRM dla Banku</h1>
            <h2>Prosta aplikacja webowa do zarządzania klientami</h2>
            <p>Zarządzanie wszystkimi zadaniami: kliknij w menu ZADANIA</p>
            <p>Zarządzanie klientami: kliknij w menu KLIENCI</p>
            <p>Zarządzanie kredytami: kliknij KREDYTY</p>
            <p>Zarządzanie pracownikami: kliknij UŻYTKOWNICY - dostępne tylko dla administratora</p>
            <p>Aby się wylogować kliknij wyloguj</p>
        </div>
    </form>
</body>
</html>
