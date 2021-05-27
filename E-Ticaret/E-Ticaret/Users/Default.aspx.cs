using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proje.DataAccess;

namespace E_Ticaret.Users
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BannerGetir();
            SliderGetir();
        }
        protected void SliderGetir()
        {
            //DbConnection connection = new DbConnection();
            //SqlConnection baglanti = connection.Baglan();
            //try
            //{

            //    SqlCommand com = new SqlCommand("SELECT * from Slider ", baglanti);
            //    SqlDataReader reader;
            //    reader = com.ExecuteReader();
            //    Repeater2.DataSource = reader;
            //    Repeater2.DataBind();
            //    reader.Close();

            //}
            //catch (Exception ex)
            //{
            //    Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert(" + ex.Message + ");</script>");
            //}
            //baglanti.Close();

            Proje.Business.Slider slider = new Proje.Business.Slider();
            var liste = slider.Listele();
            Repeater2.DataSource = liste;
            Repeater2.DataBind();
        }

        protected void BannerGetir()
        {
            DbConnection connection = new DbConnection();
            SqlConnection baglanti = connection.Baglan();
            try
            {

                SqlCommand com = new SqlCommand("SELECT TOP(1) * from banner ", baglanti);
                SqlDataReader reader;
                reader = com.ExecuteReader();
                Repeater1.DataSource = reader;
                Repeater1.DataBind();
                reader.Close();

            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BİLGİLENDİRME ", "<script>alert(" + ex.Message + ");</script>");
            }
            baglanti.Close();
        }
    }
}