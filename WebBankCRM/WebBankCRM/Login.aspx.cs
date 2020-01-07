using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace WebBankCRM
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidUser())
            {
                LblMessage.Text = "Zalogowano poprawnie";
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                LblMessage.Text = "Nieprawidłowy login lub hasło";
            }

        }
        private Boolean IsValidUser()
        {
            var dc = new DataClasses1DataContext();
            var selectQuery =
               from a in dc.GetTable<uzytkownicy>() where a.login == TxtBoxLogin.Text && a.haslo == TxtBoxPassword.Text
               select a;
            if (selectQuery.Any())
            {
                uzytkownicy user = selectQuery.First();
                Session["user"] = user;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}