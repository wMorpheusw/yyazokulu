using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;
using System.Security.Cryptography.X509Certificates;

namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntityOgrenci p)
        {
            if (p.OGRAD != null && p.OGRSOYAD != null && p.OGRNUMARA != null && p.OGRFOTOGRAF != null && p.OGRSIFRE != null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> ListeleBLL()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool BLLOgrenciSil(int p)
        {
            if (p >= 0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }

        public static List<EntityOgrenci> detayBLL(int p)
        {

            return DALOgrenci.OgrenciDetay(p);

        }

        public static bool OgrenciGuncelleBLL(EntityOgrenci p)
        {
            if (p.OGRAD != null && p.OGRSOYAD != null && p.OGRNUMARA != null && p.OGRFOTOGRAF != null && p.OGRSIFRE != null && p.OGRID != 0)
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
