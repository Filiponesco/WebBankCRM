using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebBankCRM
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //DataClasses1DataContext dc;
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
                    klienci newKlient = new klienci();
                    newKlient.imie = (GridView1.FooterRow.FindControl("txtImieFooter") as TextBox).Text.Trim();
                    newKlient.nazwisko = (GridView1.FooterRow.FindControl("txtNazwiskoFooter") as TextBox).Text.Trim();
                    newKlient.e_mail = (GridView1.FooterRow.FindControl("txtEmailFooter") as TextBox).Text.Trim();
                    newKlient.telefon = (GridView1.FooterRow.FindControl("txtTelefonFooter") as TextBox).Text.Trim();
                    newKlient.pesel = (GridView1.FooterRow.FindControl("txtPeselFooter") as TextBox).Text.Trim();

                    dc.klienci.InsertOnSubmit(newKlient);
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
            klienci updKlient = dc.klienci.FirstOrDefault(klient => klient.id_klienci.Equals(id));
            updKlient.imie = (GridView1.Rows[e.RowIndex].FindControl("txtImie") as TextBox).Text.Trim();
            updKlient.nazwisko = (GridView1.Rows[e.RowIndex].FindControl("txtNazwisko") as TextBox).Text.Trim();
            updKlient.e_mail = (GridView1.Rows[e.RowIndex].FindControl("txtEmail") as TextBox).Text.Trim();
            updKlient.telefon = (GridView1.Rows[e.RowIndex].FindControl("txtTelefon") as TextBox).Text.Trim();
            updKlient.pesel = (GridView1.Rows[e.RowIndex].FindControl("txtPesel") as TextBox).Text.Trim();
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
            int id= Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            klienci delKlient = dc.klienci.FirstOrDefault(klient => klient.id_klienci.Equals(id));
            dc.klienci.DeleteOnSubmit(delKlient);
            dc.SubmitChanges();
            GetData();
            lblSuccessMessage.Text = "Usunięto";
            lblErrorMessage.Text = "";
        }
        private void GetData()
        {
            var dc = new DataClasses1DataContext();
            var selectQuery =
               from a in dc.GetTable<klienci>()
               select a;

            GridView1.DataSource = selectQuery;
            GridView1.DataBind();
        }
    }
}