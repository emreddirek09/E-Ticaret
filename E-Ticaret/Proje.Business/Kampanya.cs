using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Kampanya
    {
        public string ürünAdi { get; set; }
        public int fiyat { get; set; }
        public string beden { get; set; }
        public int adet { get; set; }
        public string ürünaciklama { get; set; }
        public DateTime date { get; set; }
        public string Resim1 { get; set; }

        Proje.DataAccess.eTicaretEntities1 entities1 = new DataAccess.eTicaretEntities1();
        Proje.DataAccess.Kampanya KampanyaNesne = new DataAccess.Kampanya();
        public string KampUrunEkle(
                              int FK,
                              string UrünAdi,
                              int Fiyat,
                              string Beden,
                              int Adet,
                              string Aciklama,
                              string Resim1)
        {
            try
            {
                KampanyaNesne.KampanyaKatFK = FK;
                KampanyaNesne.ürünAdi = UrünAdi;
                KampanyaNesne.fiyat = Fiyat;
                KampanyaNesne.beden = Beden;
                KampanyaNesne.adet = Adet;
                KampanyaNesne.ürünaciklama = Aciklama;
                KampanyaNesne.date = System.DateTime.Now;
                KampanyaNesne.Resim1 = Resim1;               
                entities1.Kampanya.Add(KampanyaNesne);
                entities1.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return "Başarılı";
        }
    }
}
