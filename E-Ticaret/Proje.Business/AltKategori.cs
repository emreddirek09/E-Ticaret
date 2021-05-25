using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class AltKategori
    {
        public int AnaKatFK { get; set; }
        public string AltKategoriAdi { get; set; }

        public string AltKategoriEkle(int id, string a)
        {
            Proje.DataAccess.eTicaretEntities1 entities1 = new DataAccess.eTicaretEntities1();
            Proje.DataAccess.AltKategori AltKategoriNesne = new DataAccess.AltKategori();

            try
            {
                AltKategoriNesne.AnaKatFK = id;
                AltKategoriNesne.AltKategoriAdi = a;
                entities1.AltKategori.Add(AltKategoriNesne);
                entities1.SaveChanges();
            }
            catch (Exception ex)
            {
                string q = ex.Message;
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
