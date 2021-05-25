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
    }
}
