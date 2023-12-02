using _23112023_Session.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _23112023_Session
{
    public partial class Login : System.Web.UI.Page
    {
        /*
             * Session(Oturum)
             * --------------------------
             * Sessionlar yapı itibari ile sunucu tarafından çalışmaktadır.Bu yüzden dolayı sayfada almış oldukları verileri diğer bir sayfada kaybetmezler.O bilgiler oturum devam ettiği sürece hafızada kalır
             * Sunucularda çalışan Sessionların kendi içerisinde bir oturum sonlanma süreci bulunmuktadır.Bu süreç default olarak 20 dk dır.
             * Zaman aşımı süresi kapsamında web sayfası içerisinde herhangi bir işlem yapılmazsa oturum otomatik olarak sonlanmış ve veriler silinmiş olur
             * Projeleriniz içerisinde istediğiniz gibi session oluşturup bu sessionlara değer atayabilir , güncelleyebilir ve silebilirsiniz
             * 
             * Session Oluşturma
             * ----------------------------
             * 1-Session.Add("<sessionAdi>",<deger>);
             * 2-Session["<sessionAdi>"]=<deger>;
             * 
             * Session Silme
             * -----------------
             * Session.Remove("<sessionAdi>");
             * 
             * Session Süresi Tanımlama
             * -----------------------
             * Session.Timeout=<dk>;
             * 
             * Tüm Sessionları Silme
             * -------------
             * Session.RemoveAll();
             * 
             * Tüm Sessionları Sonlandır
             * --------------------
             * Session.Abandon();
             * 
             * Session oku
             * ------------
             * Session["<sessionAdi>"];
             
             */
        List<Kullanici> kullanicilar=new List<Kullanici>()
        {
            new Kullanici(){kullaniciAdi="ali",parola="12345"},
            new Kullanici(){kullaniciAdi="gülşen",parola="1111"}
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Kullanici"] != null)
            {
                Response.Redirect("Hesap.aspx");
            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var kullanici = kullanicilar.FirstOrDefault(x => x.kullaniciAdi==txtKullanici.Text && x.parola==txtParola.Text);
            if (kullanici==null) 
            {
                lblBilgi.Text = "Kullanıcı adı veya Parola Hatalı";
            }
            else
            {
                Session.Add("Kullanici",kullanici);
                Session.Timeout = 1;
                Response.Redirect("Hesap.aspx"); //Belirtilen sayfaya yönlendirme işlemi yapar

            }
        }
    }
}