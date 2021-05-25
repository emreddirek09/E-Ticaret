using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class Iletisim
    {
        public string isim { get; set; }
        public string mail { get; set; }
        public string mesaj { get; set; }
        public DateTime date { get; set; }

        public string BizeUlas(string Isim, string Mail, string Mesaj)
        {
            Proje.DataAccess.eTicaretEntities1 entities1 = new DataAccess.eTicaretEntities1();
            Proje.DataAccess.iletisim iletisimNesne = new DataAccess.iletisim();

            iletisimNesne.isim = Isim;
            iletisimNesne.mail = Mail;
            iletisimNesne.mesaj = Mesaj;
            entities1.iletisim.Add(iletisimNesne);
            entities1.SaveChanges();
            return "Başarılı";
        }
    }
}
