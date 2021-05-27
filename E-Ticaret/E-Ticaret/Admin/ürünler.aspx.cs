using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BD_Elektrik.Admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                KategoriEkle();
            }
        }
        Proje.Business.Urünler urünlerNesne = new Proje.Business.Urünler();
        private void KategoriEkle()
        {
            for (int i = 1; i <= urünlerNesne.KategoriCount(); i++)
            {
                string KatAdi = urünlerNesne.KategoriCek(i).AltKategoriAdi.ToString();
                int Katid = urünlerNesne.KategoriCek(i).id;
                DropDownList1.Items.Add(new ListItem(KatAdi, Katid.ToString()));

            }
        }
        protected void Save_Click(object sender, EventArgs e)
        {           
            string filename1;
            if (FileUpload1.HasFile)
            {
                try
                {

                    filename1 = Path.GetFileName(FileUpload1.FileName);
                    if (filename1 != "")
                    {
                        FileUpload1.SaveAs(Server.MapPath("image/ürünler/") + filename1);
                        HiddenField1.Value = filename1;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
            string filename2;
            if (FileUpload2.HasFile)
            {
                try
                {

                    filename2 = Path.GetFileName(FileUpload2.FileName);
                    if (filename2 != "")
                    {
                        FileUpload2.SaveAs(Server.MapPath("image/ürünler/") + filename2);
                        HiddenField2.Value = filename2;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
            string filename3;
            if (FileUpload3.HasFile)
            {
                try
                {

                    filename3 = Path.GetFileName(FileUpload3.FileName);
                    if (filename3 != "")
                    {
                        FileUpload3.SaveAs(Server.MapPath("image/ürünler/") + filename3);
                        HiddenField3.Value = filename3;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
            string filename4;
            if (FileUpload4.HasFile)
            {
                try
                {

                    filename4 = Path.GetFileName(FileUpload4.FileName);
                    if (filename4 != "")
                    {
                        FileUpload4.SaveAs(Server.MapPath("image/ürünler/") + filename4);
                        HiddenField4.Value = filename4;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }
            string filename5;
            if (FileUpload5.HasFile)
            {
                try
                {

                    filename5 = Path.GetFileName(FileUpload5.FileName);
                    if (filename5 != "")
                    {
                        FileUpload5.SaveAs(Server.MapPath("image/ürünler/") + filename5);
                        HiddenField5.Value = filename5;
                    }

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                }
            }

            string Resim1 = "../Admin/image/ürünler/"+HiddenField1.Value;
            string Resim2 = "../Admin/image/ürünler/"+HiddenField2.Value;
            string Resim3 = "../Admin/image/ürünler/"+HiddenField3.Value;
            string Resim4 = "../Admin/image/ürünler/"+HiddenField4.Value;
            string Resim5 = "../Admin/image/ürünler/"+HiddenField5.Value;


            if (DropDownList1.SelectedValue == "-1")
            {
                Label1.Text = "Lütfen Kategori Seçimi Yapınız.";
            }
            else if (txt_ürün_adi.Value == "" && txt_fiyat.Value == "" && txt_beden.Value == ""
                     && txt_adet.Value == "" && txt_aciklama.Value == "" && HiddenField1.Value == ""
                     && HiddenField2.Value == "" && HiddenField3.Value == "" && HiddenField4.Value == "" && HiddenField5.Value == "" )
            {
                Label1.Text = "Lütfen Ürün İçeriklerini Boş Geçmeyiniz.";
            }
            else
            {
                int FK = DropDownList1.SelectedIndex;
                string UrünAdi = txt_ürün_adi.Value;
                int Fiyat = Convert.ToInt32(txt_fiyat.Value);
                string Beden = txt_beden.Value;
                int Adet = Convert.ToInt32(txt_adet.Value);
                string Aciklama = txt_aciklama.Value;

                urünlerNesne.UrunEkle(FK, UrünAdi, Fiyat, Beden, Adet, Aciklama,
                                 Resim1, Resim2, Resim3, Resim4, Resim5);
                Label1.Text = "Ekleme Başarılı";
            }
           
            DropDownList1.SelectedValue = null;
            txt_ürün_adi.Value = "";
            txt_fiyat.Value = "";
            txt_beden.Value = "";
            txt_adet.Value = "";
            txt_aciklama.Value="";


        }
    }
}