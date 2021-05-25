using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Slider
    {
        public string Resim1 { get; set; }
        public string Resim2 { get; set; }
        public string Resim3 { get; set; }
        public string Resim4 { get; set; }
        public string Resim5 { get; set; }

        Proje.DataAccess.Slider sliderNesne = new DataAccess.Slider();
        Proje.DataAccess.eTicaretEntities1 entities1 = new DataAccess.eTicaretEntities1();

        public string SliderEkle(string resim1, string resim2, string resim3, string resim4, string resim5)
        {
            sliderNesne.Resim1 = resim1;
            sliderNesne.Resim2 = resim2;
            sliderNesne.Resim3 = resim3;
            sliderNesne.Resim4 = resim4;
            sliderNesne.Resim5 = resim5;
            entities1.Slider.Add(sliderNesne);
            entities1.SaveChanges();
            return "Başarılı";
        }
        public int Count()
        {
            int count = entities1.Slider.Count();
            return count;
        }
    }
}
