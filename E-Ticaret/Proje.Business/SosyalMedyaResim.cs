using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class SosyalMedyaResim
    {
        public string Resim1 { get; set; }
        public string Resim2 { get; set; }
        public string Resim3 { get; set; }
        public string Resim4 { get; set; }
        public string Resim5 { get; set; }

        public string Resim6 { get; set; }

        Proje.DataAccess.SosyalMedyaResim SosyalMedyaResimNesne = new DataAccess.SosyalMedyaResim();
        Proje.DataAccess.eTicaretEntities1 entities1 = new DataAccess.eTicaretEntities1();

        public string ResimEkle(string resim1, string resim2, string resim3, string resim4, string resim5, string resim6)
        {
            SosyalMedyaResimNesne.Resim1 = resim1;
            SosyalMedyaResimNesne.Resim2 = resim2;
            SosyalMedyaResimNesne.Resim3 = resim3;
            SosyalMedyaResimNesne.Resim4 = resim4;
            SosyalMedyaResimNesne.Resim5 = resim5;
            SosyalMedyaResimNesne.Resim6 = resim6;
            entities1.SosyalMedyaResim.Add(SosyalMedyaResimNesne);
            entities1.SaveChanges();
            return "Başarılı";
        }
        public int Count()
        {
            int count = entities1.SosyalMedyaResim.Count();
            return count;
        }
    }
}
