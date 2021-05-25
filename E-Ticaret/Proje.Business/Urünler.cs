using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Urünler
    {
        public int AltKatFK { get; set; }
        public string ürünAdi { get; set; }
        public int fiyat { get; set; }
        public string beden { get; set; }
        public string adet { get; set; }
        public string ürünaciklama { get; set; }
        public string date { get; set; }
        public string Resim1 { get; set; }
        public string Resim2 { get; set; }
        public string Resim3 { get; set; }
        public string Resim4 { get; set; }

        Proje.DataAccess.eTicaretEntities1 entities1 = new DataAccess.eTicaretEntities1();
        Proje.DataAccess.Urunler urunlerNesne = new DataAccess.Urunler();

        public string UrunEkle(int FK,
                               string UrünAdi,
                               int Fiyat,
                               string Beden,
                               int Adet,
                               string Aciklama,
                               string Resim1,
                               string Resim2,
                               string Resim3,
                               string Resim4,
                               string Resim5)
        {
            try
            {
                urunlerNesne.AltKatFK = FK;
                urunlerNesne.ürünAdi = UrünAdi;
                urunlerNesne.fiyat = Fiyat;
                urunlerNesne.beden = Beden;
                urunlerNesne.adet = Adet.ToString();
                urunlerNesne.ürünaciklama = Aciklama;
                urunlerNesne.date = System.DateTime.Now;
                urunlerNesne.Resim1 = Resim1;
                urunlerNesne.Resim2 = Resim2;
                urunlerNesne.Resim3 = Resim3;
                urunlerNesne.Resim4 = Resim4;
                urunlerNesne.Resim5 = Resim5;
                entities1.Urunler.Add(urunlerNesne);
                entities1.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return "Başarılı";
        }
        public int KategoriCount()
        {
            Proje.DataAccess.eTicaretEntities1 ent = new DataAccess.eTicaretEntities1();
            int count = ent.AltKategori.Count();
            return count;
        }
        public Proje.DataAccess.AltKategori KategoriCek(int idd)
        {
            Proje.DataAccess.eTicaretEntities1 ent = new DataAccess.eTicaretEntities1();
            var sonuc = ent.AltKategori.Where(p => p.id == idd);
            return sonuc.FirstOrDefault();
        }
    }
}
