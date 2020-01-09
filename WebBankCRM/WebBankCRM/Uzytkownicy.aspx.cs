using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBankCRM
{
    public partial class Uzytkownicy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
                    uzytkownicy newUser = new uzytkownicy();
                    newUser.login = (GridView1.FooterRow.FindControl("txtLoginFooter") as TextBox).Text.Trim();
                    newUser.haslo = (GridView1.FooterRow.FindControl("txtHasloFooter") as TextBox).Text.Trim();
                    newUser.imie = (GridView1.FooterRow.FindControl("txtImieFooter") as TextBox).Text.Trim();
                    newUser.nazwisko = (GridView1.FooterRow.FindControl("txtNazwiskoFooter") as TextBox).Text.Trim();
                    newUser.administrator = (GridView1.FooterRow.FindControl("txtAdministratorFooter") as CheckBox).Checked;
                    newUser.kierownik = (GridView1.FooterRow.FindControl("txtKierownikFooter") as CheckBox).Checked;
                    newUser.pracownik = (GridView1.FooterRow.FindControl("txtPracownikFooter") as CheckBox).Checked;

                    dc.uzytkownicy.InsertOnSubmit(newUser);
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
            uzytkownicy updUser = dc.uzytkownicy.FirstOrDefault(user => user.id_uzytkownicy.Equals(id));
            updUser.login = (GridView1.Rows[e.RowIndex].FindControl("txtLogin") as TextBox).Text.Trim();
            updUser.haslo = (GridView1.Rows[e.RowIndex].FindControl("txtHaslo") as TextBox).Text.Trim();
            updUser.imie = (GridView1.Rows[e.RowIndex].FindControl("txtImie") as TextBox).Text.Trim();
            updUser.nazwisko = (GridView1.Rows[e.RowIndex].FindControl("txtNazwisko") as TextBox).Text.Trim();
            updUser.administrator = (GridView1.Rows[e.RowIndex].FindControl("checkAdministrator") as CheckBox).Checked;
            updUser.kierownik = (GridView1.Rows[e.RowIndex].FindControl("checkKierownik") as CheckBox).Checked;
            updUser.pracownik = (GridView1.Rows[e.RowIndex].FindControl("checkPracownik") as CheckBox).Checked;
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
            uzytkownicy delUser = dc.uzytkownicy.FirstOrDefault(user => user.id_uzytkownicy.Equals(id));
            dc.uzytkownicy.DeleteOnSubmit(delUser);
            dc.SubmitChanges();
            GetData();
            lblSuccessMessage.Text = "Usunięto";
            lblErrorMessage.Text = "";
        }
        private void GetData()
        {
            var dc = new DataClasses1DataContext();
            var selectQuery =
               from a in dc.GetTable<uzytkownicy>()
               select a;

            GridView1.DataSource = selectQuery;
            GridView1.DataBind();
        }
    }
}