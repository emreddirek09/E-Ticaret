using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class AnaKategori
    {
        public string ÜrünKategoriAdi {get; set;}

        public string KategoriEkle(string a)
        {
            Proje.DataAccess.eTicaretEntities1 entities1 = new DataAccess.eTicaretEntities1();
            Proje.DataAccess.AnaKategori anaKategoriNesne = new DataAccess.AnaKategori();

            anaKategoriNesne.ÜrünKategoriAdi = a;
            entities1.AnaKategori.Add(anaKategoriNesne);
            entities1.SaveChanges();

            return "Başarılı";
        }
        public int KategoriCount()
        {
            Proje.DataAccess.eTicaretEntities1 ent = new DataAccess.eTicaretEntities1();
            int count = ent.AnaKategori.Count();
            return count;
        }
        public Proje.DataAccess.AnaKategori KategoriCek(int idd)
        {
            Proje.DataAccess.eTicaretEntities1 ent = new DataAccess.eTicaretEntities1();
            var sonuc = ent.AnaKategori.Where(p => p.id == idd);
            return sonuc.FirstOrDefault();
        }
    }
}
