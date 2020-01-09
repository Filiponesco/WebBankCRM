<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uzytkownicy.aspx.cs" Inherits="WebBankCRM.Uzytkownicy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Bank CRM - Użytkownicy</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
            <nav>
                <ul>
                    <li><a class="active" runat="server" href="~/Index.aspx">Strona główna</a></li>
                    <li><a runat="server" href="~/Zadania">Zadania</a></li>
                    <li><a runat="server" href="~/WebForm1.aspx">Klienci</a></li>
                    <li><a runat="server" href="~/Credits.aspx">Kredyty</a></li>
                    <li><a runat='server' href='~/Użytkownicy.aspx'>Uzytkownicy</a></li>
                    <li style="float:right" ><a runat="server" href="~/Login.aspx">Wyloguj</a></li>
                </ul>
            </nav>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowFooter="true" DataKeyNames="id_uzytkownicy"
                ShowHeaderWhenEmpty="true"
                OnRowCommand="GridView1_RowCommand" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" 
                OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting"

                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AllowSorting="True">
                <%--Theme Properties --%>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
                
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("id_uzytkownicy") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtID" Text='<%# Eval("id_uzytkownicy") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtIDFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Login">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("login") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtLogin" Text='<%# Eval("login") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtLoginFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Haslo">
                        <ItemTemplate>
                            <asp:Label Text='*******' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtHaslo" Text='<%# Eval("haslo") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtHasloFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Imie">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("imie") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtImie" Text='<%# Eval("imie") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtImieFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nazwisko">
                        <ItemTemplate>
                            <asp:Label Text='<%# Eval("nazwisko") %>' runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtNazwisko" Text='<%# Eval("nazwisko") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:TextBox ID="txtNazwiskoFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Administator">
                        <ItemTemplate>
                            <asp:CheckBox Checked='<%# Eval("administrator") %>' onclick="return false;" runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="checkAdministrator" Checked='<%# Eval("administrator") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:CheckBox ID="txtAdministratorFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Kierownik">
                        <ItemTemplate>
                            <asp:CheckBox Checked='<%# Eval("kierownik") %>' onclick="return false;" runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="checkKierownik" Checked='<%# Eval("kierownik") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:CheckBox ID="txtKierownikFooter" runat="server" />
                        </FooterTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Pracownik">
                        <ItemTemplate>
                            <asp:CheckBox Checked='<%# Eval("pracownik") %>' onclick="return false;" runat="server" />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:CheckBox ID="checkPracownik" Checked='<%# Eval("pracownik") %>' runat="server" />
                        </EditItemTemplate>
                        <FooterTemplate>
                            <asp:CheckBox ID="txtPracownikFooter" runat="server" />
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
            <asp:Label ID="lblSuccessMessage" Text="" runat="server" ForeColor="Green" />
            <br />
            <asp:Label ID="lblErrorMessage" Text="" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
