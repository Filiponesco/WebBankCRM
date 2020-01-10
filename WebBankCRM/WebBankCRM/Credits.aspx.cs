using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBankCRM
{
    public partial class Credits : System.Web.UI.Page
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
                    kredyty newKredyt = new kredyty();
                    //newKredyt.id_kredyty = 1;
                    newKredyt.id_klienci = Convert.ToInt32((GridView1.FooterRow.FindControl("DDLKlientFooter") as DropDownList).SelectedValue);
                    newKredyt.kwota = (GridView1.FooterRow.FindControl("txtKwotaFooter") as TextBox).Text.Trim();
                    newKredyt.zgoda_pracownika = (GridView1.FooterRow.FindControl("checkZgodaPracownikaFooter") as CheckBox).Checked;
                    newKredyt.zgoda_kierownika = (GridView1.FooterRow.FindControl("checkZgodaKierownikaFooter") as CheckBox).Checked;

                    dc.kredyty.InsertOnSubmit(newKredyt);
                    dc.SubmitChanges();
                    GetData();
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
            //Pomimo, że nie wyświetlam id_kredyty mogę je pobrać, ponieważ jest ustawione jako DataKeyNames w GridView
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            kredyty updKredyt = dc.kredyty.FirstOrDefault(kredyt => kredyt.id_kredyty.Equals(id));
            updKredyt.id_klienci = Convert.ToInt32((GridView1.Rows[e.RowIndex].FindControl("DDLKlient") as DropDownList).SelectedValue);
            updKredyt.kwota = (GridView1.Rows[e.RowIndex].FindControl("txtkwota") as TextBox).Text.Trim();
            updKredyt.zgoda_pracownika = (GridView1.Rows[e.RowIndex].FindControl("checkZgodaPracownika") as CheckBox).Checked;
            updKredyt.zgoda_kierownika = (GridView1.Rows[e.RowIndex].FindControl("checkZgodaKierownika") as CheckBox).Checked;

            dc.SubmitChanges();
            GridView1.EditIndex = -1;
            GetData();
            lblSuccessMessage.Text = "Zaktualizowano";
            lblErrorMessage.Text = "";
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var dc = new DataClasses1DataContext();
            //Pomimo, że nie wyświetlam id_kredyty mogę je pobrać, ponieważ jest ustawione jako DataKeyNames w GridView
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            kredyty delKredyt = dc.kredyty.FirstOrDefault(kredyt => kredyt.id_kredyty.Equals(id));
            dc.kredyty.DeleteOnSubmit(delKredyt);
            dc.SubmitChanges();
            GetData();
            lblSuccessMessage.Text = "Usunięto";
            lblErrorMessage.Text = "";
        }
        private void GetData()
        {
            var dc = new DataClasses1DataContext();
            var selectQuery =
               from a in dc.GetTable<kredyty>()
               select a;

            GridView1.DataSource = selectQuery;
            GridView1.DataBind();
            BindDropDownList();
        }
        private void BindDropDownList()
        {
            var dc = new DataClasses1DataContext();
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
            DropDownList DDLKlientFooter = GridView1.FooterRow.FindControl("DDLKlientFooter") as DropDownList;
            DDLKlientFooter.DataSource = selectQuery;
            DDLKlientFooter.DataTextField = "displayField";
            DDLKlientFooter.DataValueField = "id_klienci";
            DDLKlientFooter.DataBind();
        }
        private void BindEditRowDropDownList()
        {
            var dc = new DataClasses1DataContext();
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
            DropDownList DDLKlient = GridView1.Rows[GridView1.EditIndex].FindControl("DDLKlient") as DropDownList;
            DDLKlient.DataSource = selectQuery;
            DDLKlient.DataTextField = "displayField";
            DDLKlient.DataValueField = "id_klienci";
            DDLKlient.DataBind();
        }
    }
}