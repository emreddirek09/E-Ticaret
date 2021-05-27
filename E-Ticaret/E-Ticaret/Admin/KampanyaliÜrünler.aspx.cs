using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace E_Ticaret.Admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Proje.Business.KampanyaKategori KampanyaKategoriNesne = new Proje.Business.KampanyaKategori();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                VeriÇek();
            }
        }
        public void VeriÇek()
        {
            foreach (var item in KampanyaKategoriNesne.Listele())
            {
                var id = item.id;

                string KatAdi = KampanyaKategoriNesne.KategoriCek(id).KampanyaAdi.ToString();
                int Katid = KampanyaKategoriNesne.KategoriCek(id).id;
                DropDownList1.Items.Add(new ListItem(KatAdi, Katid.ToString()));
            }
        }

        protected void ekle_Click(object sender, EventArgs e)
        {
            string KampAdi = txt_KampanyaAdi.Value;
            string filename1;
            if (FileUploadBanner.HasFile)
            {
                try
                {

                    filename1 = Path.GetFileName(FileUploadBanner.FileName);
                    if (filename1 != "")
                    {
                        FileUploadBanner.SaveAs(Server.MapPath("image/KampanyaBanner/") + filename1);
                        HiddenField1.Value = filename1;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
            string Banner = "../Admin/image/KampanyaBanner/"+HiddenField1.Value;

            if (txt_KampanyaAdi.Value == "" && FileUploadBanner.HasFile != true)
            {
                Label1.Text = "Boş Geçemezsiniz.";
            }
            else
            {
                KampanyaKategoriNesne.KategoriEkle(KampAdi, Banner);
                Label1.Text = "Ekleme Başarılı";

            }
            txt_KampanyaAdi.Value = "";
            if (!IsPostBack == true)
            {
                VeriÇek();
            }
        }

        protected void UrunKaydet_Click(object sender, EventArgs e)
        {
            Proje.Business.Kampanya kampanyaNesne = new Proje.Business.Kampanya();

            string filename2;
            if (FileUpload1.HasFile)
            {
                try
                {
                    filename2 = Path.GetFileName(FileUpload1.FileName);
                    if (filename2 != "")
                    {
                        FileUpload1.SaveAs(Server.MapPath("image/KampanyaliÜrünler/") + filename2);
                        HiddenField2.Value = filename2;
                    }
                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");
                }
            }
            string ürün = "../Admin/image/KampanyaliÜrünler /"+HiddenField2.Value;


            if (DropDownList1.SelectedValue == "-1")
            {
                Label2.Text = "Lütfen Kategori Seçimi Yapınız.";
            }
            else if (txt_ürün_adi.Value == "" && txt_fiyat.Value == "" && txt_beden.Value == ""
                     && txt_adet.Value == "" && txt_aciklama.Value == "" && HiddenField2.Value == "")
            {
                Label2.Text = "Lütfen Ürün İçeriklerini Boş Geçmeyiniz.";
            }
            else
            {
                int FK = Convert.ToInt32(DropDownList1.SelectedValue);
                string UrünAdi = txt_ürün_adi.Value;
                int Fiyat = Convert.ToInt32(txt_fiyat.Value);
                string Beden = txt_beden.Value;
                int Adet = Convert.ToInt32(txt_adet.Value);
                string Aciklama = txt_aciklama.Value;

                kampanyaNesne.KampUrunEkle(FK, UrünAdi, Fiyat, Beden, Adet, Aciklama,ürün);
                Label2.Text = "Ekleme Başarılı";
            }

            DropDownList1.SelectedValue = null;
            txt_ürün_adi.Value = "";
            txt_fiyat.Value = "";
            txt_beden.Value = "";
            txt_adet.Value = "";
            txt_aciklama.Value = "";

        }
    }
}