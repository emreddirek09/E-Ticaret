using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Banner
    {
        public string banner { get; set; }

        Proje.DataAccess.Banner bannerNesne = new DataAccess.Banner();
        Proje.DataAccess.eTicaretEntities1 entities1 = new DataAccess.eTicaretEntities1();

        public string BannerEkle(string Resim)
        {
            bannerNesne.banner1 = Resim;
            entities1.Banner.Add(bannerNesne);
            entities1.SaveChanges();
            return "Başarılı";
        }
        public int VeriSil(int i)
        {
            var stud = (from s1 in entities1.Banner
                        where s1.id == i
                        select s1).SingleOrDefault();

            //Delete it from memory
            entities1.Banner.Remove(stud);
            //Save to database
            entities1.SaveChanges();

            return 1;
        }
        public List<Proje.DataAccess.Banner> Listele()

        {
            Proje.DataAccess.eTicaretEntities1 ent = new DataAccess.eTicaretEntities1();
            var sonuc = ent.Banner.ToList();
            return sonuc;
        }

    }
}
