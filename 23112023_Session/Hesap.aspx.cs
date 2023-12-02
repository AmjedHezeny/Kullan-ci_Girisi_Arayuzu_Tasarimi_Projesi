using _23112023_Session.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _23112023_Session
{
    public partial class Hesap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            var kull = (Kullanici)Session["Kullanici"];
            if (kull!=null)
            {
                lblKullanici.Text = string.Format("<b> {0} <b> kullanıcısı, hoşgeldiniz",kull.kullaniciAdi);
            }
        }

        protected void btnOturumuKapat_Click(object sender, EventArgs e)
        {
            Session.Remove("Kullanici");
            Response.Redirect("Login.aspx");
        }
    }
}