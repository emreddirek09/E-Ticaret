using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Ticaret.Admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Proje.Business.Banner bannerNesne = new Proje.Business.Banner();
        protected void Save_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile != false)
            {
                string filename1;
                if (FileUpload1.HasFile)
                {
                    try
                    {

                        filename1 = Path.GetFileName(FileUpload1.FileName);
                        if (filename1 != "")
                        {
                            FileUpload1.SaveAs(Server.MapPath("image/Banner/") + filename1);
                            HiddenField1.Value = filename1;
                        }

                    }
                    catch (Exception ex)
                    {
                        Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                    }
                }
                string Resim1 = "image/Banner/" + HiddenField1.Value;
                bannerNesne.BannerEkle(Resim1);
                Label1.Text = "Ekleme Başarılı";

            }
            else
            {
                Label1.Text = "Boş Ekleme Yapamazsınız.";
            }

        }
    }
}