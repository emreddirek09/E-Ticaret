using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class KampanyaKategori
    {
        public string id { get; set; }
        public string KampanyaAdi { get; set; }
        public string KampanyaBanner { get; set; }
        public string date { get; set; }

        public string KategoriEkle(string a, string b)
        {
            Proje.DataAccess.eTicaretEntities1 entities1 = new DataAccess.eTicaretEntities1();
            Proje.DataAccess.KampanyaKategori kampanyaKategoriNesne = new DataAccess.KampanyaKategori();

            kampanyaKategoriNesne.KampanyaAdi = a;
            kampanyaKategoriNesne.KampanyaBanner = b;
            kampanyaKategoriNesne.date = System.DateTime.Now;
            entities1.KampanyaKategori.Add(kampanyaKategoriNesne);
            entities1.SaveChanges();

            return "Başarılı";
        }
        public int KategoriCount()       {
            
            Proje.DataAccess.eTicaretEntities1 ent = new DataAccess.eTicaretEntities1();            
            int count = ent.KampanyaKategori.Count();
            return count;
        }
        public Proje.DataAccess.KampanyaKategori KategoriCek(int idd)
        {
            Proje.DataAccess.eTicaretEntities1 ent = new DataAccess.eTicaretEntities1();
            var sonuc = ent.KampanyaKategori.Where(p => p.id == idd);
            return sonuc.FirstOrDefault();
        }
        public List<Proje.DataAccess.KampanyaKategori> Listele()

        {
            Proje.DataAccess.eTicaretEntities1 ent = new DataAccess.eTicaretEntities1();
            ent.Database.Connection.Open();
            var sonuc = ent.KampanyaKategori.ToList();
            return sonuc;
        }

    }
}
