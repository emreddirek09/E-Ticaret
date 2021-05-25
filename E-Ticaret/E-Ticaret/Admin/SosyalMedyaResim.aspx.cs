using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Ticaret.Admin
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ekle_Click(object sender, EventArgs e)
        {
            Proje.Business.SosyalMedyaResim sosyalMedyaResimNesne = new Proje.Business.SosyalMedyaResim();
            int count = sosyalMedyaResimNesne.Count();

            if (count != 1)
            {
                if (FileUpload1.HasFile != false && FileUpload2.HasFile != false && FileUpload3.HasFile != false
                    && FileUpload4.HasFile != false && FileUpload5.HasFile != false)
                {
                    string filename1;
                    if (FileUpload1.HasFile)
                    {
                        try
                        {

                            filename1 = Path.GetFileName(FileUpload1.FileName);
                            if (filename1 != "")
                            {
                                FileUpload1.SaveAs(Server.MapPath("image/SosyalMedya/") + filename1);
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
                                FileUpload2.SaveAs(Server.MapPath("image/SosyalMedya/") + filename2);
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
                                FileUpload3.SaveAs(Server.MapPath("image/SosyalMedya/") + filename3);
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
                                FileUpload4.SaveAs(Server.MapPath("image/SosyalMedya/") + filename4);
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
                                FileUpload5.SaveAs(Server.MapPath("image/SosyalMedya/") + filename5);
                                HiddenField5.Value = filename5;
                            }

                        }
                        catch (Exception ex)
                        {
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                        }
                    }
                    string filename6;
                    if (FileUpload6.HasFile)
                    {
                        try
                        {

                            filename6 = Path.GetFileName(FileUpload6.FileName);
                            if (filename6 != "")
                            {
                                FileUpload6.SaveAs(Server.MapPath("image/SosyalMedya/") + filename6);
                                HiddenField6.Value = filename6;
                            }

                        }
                        catch (Exception ex)
                        {
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                        }
                    }

                    string Resim1 = "image/SosyalMedya/" + HiddenField1.Value;
                    string Resim2 = "image/SosyalMedya/" + HiddenField2.Value;
                    string Resim3 = "image/SosyalMedya/" + HiddenField3.Value;
                    string Resim4 = "image/SosyalMedya/" + HiddenField4.Value;
                    string Resim5 = "image/SosyalMedya/" + HiddenField5.Value;
                    string Resim6 = "image/SosyalMedya/" + HiddenField6.Value;

                    sosyalMedyaResimNesne.ResimEkle(Resim1, Resim2, Resim3, Resim4, Resim5, Resim6);
                    Label1.Text = "Ekleme Başarılı";
                }
                else
                {
                    Label1.Text = "Boş Ekleme Yapamazsınız.";
                }

            }
            else
            {
                Label1.Text = "Mevcut Resim Vardır. Kayıt İşlemi Başarısız.";
            }
        }
    }
}