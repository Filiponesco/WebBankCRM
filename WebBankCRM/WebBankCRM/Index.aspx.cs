using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebBankCRM
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                uzytkownicy actualUser = (uzytkownicy) Session["User"];
                if (actualUser.administrator)
                {
                    //STH doing when administator is login
                    //HtmlGenericControl ul = new HtmlGenericControl("ul");
                    //ul.InnerHtml += @"<li><a runat='server' href='~/Uzytkownicy.aspx'>Uzytkownicy</a></li>";
                }
            }
        }
    }
}