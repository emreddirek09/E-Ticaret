using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class üyeler
    {
        public string isim { get; set; }
        public string Soyadı { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string telefon { get; set; }
        public string sifre { get; set; }
        public string sifreOnay { get; set; }
        public string date { get; set; }

        Proje.DataAccess.eTicaretEntities1 entities1 = new DataAccess.eTicaretEntities1();
        Proje.DataAccess.Uyeler uyelerNesne = new DataAccess.Uyeler();
        public string UyeEkle
            (
            string isimm
             , string Soyadıı
             , string Maill
             , string Adress
             , string ill
             , string ilcee
             , string telefonn
             , string sifree
             , string sifreOnayy
            )
        {
            uyelerNesne.isim = isimm;
            uyelerNesne.Soyadı = Soyadıı;
            uyelerNesne.Mail = Maill;
            uyelerNesne.Adres = Adress;
            uyelerNesne.il = ill;
            uyelerNesne.ilce = ilcee;
            uyelerNesne.telefon = telefonn;
            uyelerNesne.sifre = sifree;
            uyelerNesne.sifreOnay = sifreOnayy;
            uyelerNesne.date = System.DateTime.Now;

            entities1.Uyeler.Add(uyelerNesne);
            entities1.SaveChanges();
            return "1";
        }
    }
}
