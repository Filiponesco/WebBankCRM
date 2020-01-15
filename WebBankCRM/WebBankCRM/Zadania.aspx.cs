using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBankCRM
{
    public partial class Zadania : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            if (!IsPostBack) //bardzo wazne inaczej eventy z gridView nie dzialaja
            {
                GetData();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                var dc = new DataClasses1DataContext();
                if (e.CommandName.Equals("AddNew"))
                {
                    zadania newTask = new zadania();
                    newTask.tytul = (GridView1.FooterRow.FindControl("txtTytulFooter") as TextBox).Text.Trim();
                    newTask.tresc = (GridView1.FooterRow.FindControl("txtTrescFooter") as TextBox).Text.Trim();
                    newTask.autor_id_uzytkownicy = Convert.ToInt32((GridView1.FooterRow.FindControl("DDLAutorFooter") as DropDownList).SelectedValue);
                    newTask.status = (GridView1.FooterRow.FindControl("txtStatusFooter") as TextBox).Text.Trim();
                    newTask.id_klienci = Convert.ToInt32((GridView1.FooterRow.FindControl("DDLDotyczyFooter") as DropDownList).SelectedValue);
                    newTask.termin = Convert.ToDateTime((GridView1.FooterRow.FindControl("txtTerminFooter") as TextBox).Text.Trim());

                    dc.zadania.InsertOnSubmit(newTask);
                    dc.SubmitChanges();
                    GetData();
                    GridView1.DataBind();
                    lblSuccessMessage.Text = "Dodano";
                    lblErrorMessage.Text = "";
                }
            }
            catch (Exception exc)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = exc.Message;
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GetData();
            BindEditRowDropDownList();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GetData();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var dc = new DataClasses1DataContext();
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            zadania updTask = dc.zadania.FirstOrDefault(task => task.id_zadania.Equals(id));
            updTask.tytul = (GridView1.Rows[e.RowIndex].FindControl("txtTytul") as TextBox).Text.Trim();
            updTask.tresc = (GridView1.Rows[e.RowIndex].FindControl("txtTresc") as TextBox).Text.Trim();
            updTask.autor_id_uzytkownicy = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("DDLAutor") as DropDownList).SelectedValue);
            updTask.status = (GridView1.Rows[e.RowIndex].FindControl("txtStatus") as TextBox).Text.Trim();
            updTask.id_klienci = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("DDLDotyczy") as DropDownList).SelectedValue);
            updTask.termin = Convert.ToDateTime((GridView1.Rows[e.RowIndex].FindControl("txtTermin") as TextBox).Text.Trim());
            dc.SubmitChanges();
            GridView1.EditIndex = -1;
            GetData();
            lblSuccessMessage.Text = "Zaktualizowano";
            lblErrorMessage.Text = "";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var dc = new DataClasses1DataContext();
            //int id = Int32.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text);
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            zadania delTask = dc.zadania.FirstOrDefault(task => task.id_zadania.Equals(id));
            dc.zadania.DeleteOnSubmit(delTask);
            dc.SubmitChanges();
            GetData();
            lblSuccessMessage.Text = "Usunięto";
            lblErrorMessage.Text = "";
        }
        private void GetData()
        {
            var dc = new DataClasses1DataContext();
            //var selectQuery =
            //   from a in dc.GetTable<zadania>()
            //   select new
            //   {
            //       a.id_zadania,
            //       a.tytul,
            //       a.tresc,
            //       a.autor_id_uzytkownicy,
            //       a.status,
            //       a.id_klienci,
            //       //a.uzytkownicy.id_uzytkownicy,
            //       //a.uzytkownicy.imie,
            //       //a.uzytkownicy.nazwisko,
            //       displayTermin = (a.termin.ToString()).Substring(0, 10)
            //   };
            //important change in termin ^^
            var selectQuery =
            from a in dc.GetTable<uzytkownicy>()
            select a;
            GridView1.DataSource = selectQuery;
            GridView1.DataBind();
            BindDropDownList();
        }
        private void BindDropDownList()
        {
            var dc = new DataClasses1DataContext();

            #region bindDDLDotyczy
            var selectQuery =
               from a in dc.GetTable<klienci>()
               select new
               {
                   a.id_klienci,
                   a.imie,
                   a.nazwisko,
                   a.e_mail,
                   a.pesel,
                   displayField = String.Format("{0} {1} {2} {3}", a.imie, a.nazwisko, a.e_mail, a.pesel)
               };
            DropDownList DDLDotyczyFooter = GridView1.FooterRow.FindControl("DDLDotyczyFooter") as DropDownList;
            DDLDotyczyFooter.DataSource = selectQuery;
            DDLDotyczyFooter.DataTextField = "displayField";
            DDLDotyczyFooter.DataValueField = "id_klienci";
            DDLDotyczyFooter.DataBind();
            #endregion
            #region bindDDLAutor
            var selectQueryUser =
               from a in dc.GetTable<uzytkownicy>()
               select new
               {
                   a.id_uzytkownicy,
                   a.imie,
                   a.nazwisko,
                   displayField = String.Format("{0} {1}", a.imie, a.nazwisko)
               };
            DropDownList DDLAutorFooter = GridView1.FooterRow.FindControl("DDLAutorFooter") as DropDownList;
            DDLAutorFooter.DataSource = selectQueryUser;
            DDLAutorFooter.DataTextField = "displayField";
            DDLAutorFooter.DataValueField = "id_uzytkownicy";
            DDLAutorFooter.DataBind();
            #endregion
        }
        //Bind dropDownList when row is editting
        private void BindEditRowDropDownList()
        {
            var dc = new DataClasses1DataContext();

            #region bindEditDDLDotyczy
            var selectQuery =
               from a in dc.GetTable<klienci>()
               select new
               {
                   a.id_klienci,
                   a.imie,
                   a.nazwisko,
                   a.e_mail,
                   a.pesel,
                   displayField = String.Format("{0} {1} {2} {3}", a.imie, a.nazwisko, a.e_mail, a.pesel)
               };
            DropDownList DDLDotyczy = GridView1.Rows[GridView1.EditIndex].FindControl("DDLDotyczy") as DropDownList;
            DDLDotyczy.DataSource = selectQuery;
            DDLDotyczy.DataTextField = "displayField";
            DDLDotyczy.DataValueField = "id_klienci";
            DDLDotyczy.DataBind();
            #endregion
            #region bindEditDDLDotyczy
            var selectQueryUser =
               from a in dc.GetTable<uzytkownicy>()
               select new
               {
                   a.id_uzytkownicy,
                   a.imie,
                   a.nazwisko,
                   displayField = String.Format("{0} {1}", a.imie, a.nazwisko)
               };
            DropDownList DDLAutor= GridView1.Rows[GridView1.EditIndex].FindControl("DDLAutor") as DropDownList;
            DDLAutor.DataSource = selectQueryUser;
            DDLAutor.DataTextField = "displayField";
            DDLAutor.DataValueField = "id_uzytkownicy";
            DDLAutor.DataBind();
            #endregion
        }
    }
}