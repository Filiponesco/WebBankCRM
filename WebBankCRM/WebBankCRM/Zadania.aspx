<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Zadania.aspx.cs" Inherits="WebBankCRM.Zadania" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Bank CRM - Zadania</title>
    <link href="https://fonts.googleapis.com/css?family=Baloo+Bhai&display=swap" rel="stylesheet"/>
    <link href="https://fonts.googleapis.com/css?family=Alata&display=swap" rel="stylesheet">
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
            <nav>
                <ul>
                    <li><a runat="server" href="~/Index.aspx">Strona główna</a></li>
                    <li><a class="active" runat="server" href="~/Zadania">Zadania</a></li>
                    <li><a runat="server" href="~/WebForm1.aspx">Klienci</a></li>
                    <li><a runat="server" href="~/Credits.aspx">Kredyty</a></li>
                    <li><a runat='server' href='~/Uzytkownicy.aspx'>Użytkownicy</a></li>
                    <li style="float:right" ><a runat="server" href="~/Login.aspx">Wyloguj</a></li>
                </ul>
            </nav>
        <div id="tabela">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="id_zadania"
                ShowHeaderWhenEmpty="true"
                OnRowCommand="GridView1_RowCommand" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" 
                OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting"

                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AllowSorting="True">
                <%--Theme Properties --%>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="False" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
                
                <Columns>
                    <asp:TemplateField HeaderText="Tytuł">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("tytul") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTytul" Text='<%# Eval("tytul") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtTytulFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Treść">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("tresc") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTresc" Text='<%# Eval("tresc") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtTrescFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Stworzył">
                        <ItemTemplate>
                            <asp:Label Text='<%# String.Format("{0} {1}", Eval("uzytkownicy.imie"), Eval("uzytkownicy.nazwisko")) %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="DDLAutor" runat="server"></asp:DropDownList>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:DropDownList ID="DDLAutorFooter" runat="server"></asp:DropDownList>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("status") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="DDLStatus" runat="server">
                                <asp:ListItem Text="Nowe" Value="0" />
                                <asp:ListItem Text="Zaakceptowane" Value="1" />
                                <asp:ListItem Text="W trakcie" Value="2" />
                                <asp:ListItem Text="Rozwiązane" Value="3" />
                            </asp:DropDownList>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:DropDownList ID="DDLStatusFooter" runat="server">
                                <asp:ListItem Text="Nowe" Value="0" />
                                <asp:ListItem Text="Zaakceptowane" Value="1" />
                                <asp:ListItem Text="W trakcie" Value="2" />
                                <asp:ListItem Text="Rozwiązane" Value="3" />
                            </asp:DropDownList>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Dotyczy">
                        <ItemTemplate>
                            <asp:Label Text='<%# String.Format("{0} {1}, {2}, {3}", Eval("klienci.imie"), Eval("klienci.nazwisko"), Eval("klienci.e_mail"), Eval("klienci.pesel")) %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:DropDownList ID="DDLDotyczy" runat="server"></asp:DropDownList>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:DropDownList ID="DDLDotyczyFooter" runat="server"></asp:DropDownList>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Termin">
                        <ItemTemplate>
                            <asp:Label Text='<%# String.Format("{0:d/M/yyyy}", Eval("termin")) %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtTermin" Text='<%# String.Format("{0:d/M/yyyy}", Eval("termin")) %>' runat="server" TextMode="Date" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtTerminFooter" runat="server" TextMode="Date"/>
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:ImageButton ImageUrl="~/Images/edit.png" runat="server" CommandName="Edit" ToolTip="Edit" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="~/Images/delete.png" runat="server" CommandName="Delete" ToolTip="Delete" Width="20px" Height="20px"/>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:ImageButton ImageUrl="~/Images/save.png" runat="server" CommandName="Update" ToolTip="Update" Width="20px" Height="20px"/>
                            <asp:ImageButton ImageUrl="~/Images/cancel.png" runat="server" CommandName="Cancel" ToolTip="Cancel" Width="20px" Height="20px"/>
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:ImageButton ImageUrl="~/Images/addnew.png" runat="server" CommandName="AddNew" ToolTip="Add New" Width="20px" Height="20px"/>
                        </FooterTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <div id="messages">
                <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
                <br />
                <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />
            </div>
        </div>
    </form>
</body>
</html>
