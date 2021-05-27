using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Ticaret.Admin
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void ekle_Click(object sender, EventArgs e)
        {
            Proje.Business.Slider sliderNesne = new Proje.Business.Slider();
            int count = sliderNesne.Count();

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
                                FileUpload1.SaveAs(Server.MapPath("image/Slider/") + filename1);
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
                                FileUpload2.SaveAs(Server.MapPath("image/Slider/") + filename2);
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
                                FileUpload3.SaveAs(Server.MapPath("image/Slider/") + filename3);
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
                                FileUpload4.SaveAs(Server.MapPath("image/Slider/") + filename4);
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
                                FileUpload5.SaveAs(Server.MapPath("image/Slider/") + filename5);
                                HiddenField5.Value = filename5;
                            }

                        }
                        catch (Exception ex)
                        {
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert('Dosya yüklenemedi:'" + ex.Message + ");</script>");

                        }
                    }

                    string Resim1 = "../Admin/image/ Slider/"+HiddenField1.Value;
                    string Resim2 = "../Admin/image/ Slider/"+HiddenField2.Value;
                    string Resim3 = "../Admin/image/ Slider/"+HiddenField3.Value;
                    string Resim4 = "../Admin/image/ Slider/"+HiddenField4.Value;
                    string Resim5 = "../Admin/image/ Slider/"+HiddenField5.Value;

                    sliderNesne.SliderEkle(Resim1,Resim2,Resim3,Resim4,Resim5);
                    Label1.Text = "Ekleme Başarılı";
                }
                else
                {
                    Label1.Text = "Boş Seçim Yapamazsınız.";
                }
                
            }
            else
            {
                Label1.Text = "Mevcut Resim Vardır. Kayıt İşlemi Başarısız.";
            }

        }
    }
}