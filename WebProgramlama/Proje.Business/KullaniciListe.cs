using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Business
{
    public class KullaniciListe
    {
        public List<Proje.DataAccess.MUSTERI> Listele()
        {
            Proje.DataAccess.Diyetisyen_UygulamasıEntities du = new Proje.DataAccess.Diyetisyen_UygulamasıEntities();
            var KullaniciListe = du.MUSTERI.ToList();
            return KullaniciListe;

        }
    }
}
