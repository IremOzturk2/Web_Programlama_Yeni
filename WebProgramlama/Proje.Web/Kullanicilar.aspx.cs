using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje.Web
{
    public partial class Kullanicilar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Proje.Business.KullaniciListe kl = new Business.KullaniciListe();
            
            var sonuc = kl.Listele();
            GridView1.DataSource = sonuc;
            GridView1.DataBind();
        }
    }
}