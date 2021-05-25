using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace E_Ticaret.Users
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        Proje.Business.üyeler UyelerNesne = new Proje.Business.üyeler();

        //protected void Ekle_Click1(object sender, EventArgs e)
        //{
        //    UyelerNesne.UyeEkle(
        //           Txt_İsim.Text,
        //           TxtSoyad.Text,
        //           Txt_mail.Text,
        //           Txt_Adres.Text,
        //           Txt_İl.Text,
        //           Txt_İlce.Text,
        //           Txt_Telefon.Text,
        //           Txt_sifre.Text,
        //           Txt_sifreOnay.Text
        //           );


        //    Txt_İsim.Text = "";
        //    TxtSoyad.Text = "";
        //    Txt_mail.Text = "";
        //    Txt_Adres.Text = "";
        //    Txt_İl.Text = "";
        //    Txt_İlce.Text = "";
        //    Txt_Telefon.Text = "";
        //    Txt_sifre.Text = "";
        //    Txt_sifreOnay.Text = "";

        //}
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Txt_İsim.Text == "" &&
                   TxtSoyad.Text == "" &&
                   Txt_mail.Text == "" &&
                   Txt_Adres.Text == "" &&
                   Txt_İl.Text == "" &&
                   Txt_İlce.Text == "" &&
                   Txt_Telefon.Text == "" &&
                   Txt_sifre.Text == "" &&
                   Txt_sifreOnay.Text == "")
            {        
                //uyari.Text = "Lütfen Boş alanları doldurunuz.";
            }
            else
            {
                UyelerNesne.UyeEkle(
                Txt_İsim.Text,
                TxtSoyad.Text,
                Txt_mail.Text,
                Txt_Adres.Text,
                Txt_İl.Text,
                Txt_İlce.Text,
                Txt_Telefon.Text,
                Txt_sifre.Text,
                Txt_sifreOnay.Text
                );
            }          

            Txt_İsim.Text = "";
            TxtSoyad.Text = "";
            Txt_mail.Text = "";
            Txt_Adres.Text = "";
            Txt_İl.Text = "";
            Txt_İlce.Text = "";
            Txt_Telefon.Text = "";
            Txt_sifre.Text = "";
            Txt_sifreOnay.Text = "";

        }
    }
}