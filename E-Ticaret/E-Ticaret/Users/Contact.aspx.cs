using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Ticaret.Users
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Proje.Business.Iletisim IletisimNesne = new Proje.Business.Iletisim();
        protected void Gönder_Click(object sender, EventArgs e)
        {
            string isim = txt_isim.Value;
            string mail = txt_mail.Value;
            string mesaj = txt_mesaj.Value;
            if (isim != "" && mail != "" && mesaj != "")
            {
                IletisimNesne.BizeUlas(isim, mail, mesaj);
                Label1.Text = "Mesajınız İletilmiştir. En kısa sürede dönüş yapılacaktır.";
            }
            else
            {
                Label1.Text = "Lütfen Boş Alanları Doldurunuz.";
            }
           

        }
    }
}