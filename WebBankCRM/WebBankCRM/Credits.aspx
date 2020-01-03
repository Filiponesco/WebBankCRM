<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Credits.aspx.cs" Inherits="WebBankCRM.Credits" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblKwota" runat="server" Text="Kwota kredytu [zł]: "></asp:Label>
            <asp:TextBox ID="TxtBoxKwota" runat="server"></asp:TextBox>
            <asp:Label ID="LblKlient" runat="server" Text="Wybierz klienta: "></asp:Label>
            <asp:DropDownList ID="DropDownListKlient" runat="server"></asp:DropDownList>
            <asp:Label ID="LblZgodaPracownika" runat="server" Text="Zgoda pracownika: "></asp:Label>
            <asp:CheckBox ID="CheckBoxZgodaPracownika" runat="server" />
            <asp:Label ID="LblZgodaKierownika" runat="server" Text="Zgoda kierownika: "></asp:Label>
            <asp:CheckBox ID="CheckBoxZgodaKierownika" runat="server" />
            <asp:Button ID="BtnZapisz" runat="server" Text="Zapisz" OnClick="BtnZapisz_Click" />
        </div>
    </form>
</body>
</html>
