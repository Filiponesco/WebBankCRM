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
            //only bind on the first request
            if (!Page.IsPostBack)
            {
                BindData();
            }

        }
        private void BindData()
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
            DropDownListKlient.DataSource = selectQuery;
            DropDownListKlient.DataTextField = "displayField";
            DropDownListKlient.DataValueField = "id_klienci";
            DropDownListKlient.DataBind();
        }

        protected void BtnZapisz_Click(object sender, EventArgs e)
        {
            var dc = new DataClasses1DataContext();
            kredyty newKredyt = new kredyty();
            newKredyt.kwota = TxtBoxKwota.Text;
            newKredyt.id_klienci = Convert.ToInt32(DropDownListKlient.SelectedValue);
            newKredyt.zgoda_pracownika = CheckBoxZgodaPracownika.Checked;
            newKredyt.zgoda_kierownika = CheckBoxZgodaKierownika.Checked;

            dc.kredyty.InsertOnSubmit(newKredyt);
            dc.SubmitChanges();

            Response.Write("<script>alert('Zapisano');</script>");
            Clean();
        }
        private void Clean()
        {
            TxtBoxKwota.Text = "";
            CheckBoxZgodaPracownika.Checked = false;
            CheckBoxZgodaKierownika.Checked = false;
        }
    }
}