using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Ticaret.Admin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Proje.Business.AnaKategori anaKategoriNesne = new Proje.Business.AnaKategori();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                VeriÇek();
            }
            
        }
        public void VeriÇek()
        {
            for (int i = 1; i <= anaKategoriNesne.KategoriCount(); i++)
            {
                string KatAdi = anaKategoriNesne.KategoriCek(i).ÜrünKategoriAdi.ToString();
                int Katid = anaKategoriNesne.KategoriCek(i).id;
                DropDownList1.Items.Add(new ListItem(KatAdi, Katid.ToString()));

            }
        }

        protected void ekle_Click(object sender, EventArgs e)
        {
            
            string ad = txt_AnaKategori.Value;
            Label1.Text="";
            if (txt_AnaKategori.Value == "")
            {
                Label1.Text = "Boş Geçemezsiniz.";
            }
            else
            {
                anaKategoriNesne.KategoriEkle(ad);
                Label1.Text = "Ekleme Başarılı";

            }
            txt_AnaKategori.Value = "";
            if (!IsPostBack==true)
            {
                VeriÇek();
            }
           

        }

        protected void save_Click(object sender, EventArgs e)
        {
            Proje.Business.AltKategori altKategoriNesne = new Proje.Business.AltKategori();

            if (txt_AltKategori.Value == "" && DropDownList1.SelectedValue == "-1")
            {
                Label2.Text = "Boş Geçemezsiniz.";
            }
            else
            {
                altKategoriNesne.AltKategoriEkle(DropDownList1.SelectedIndex, txt_AltKategori.Value);
                Label2.Text = "Ekleme Başarılı";
            }

            
        }
    }
}