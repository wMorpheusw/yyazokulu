﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> DersListeleBLL()
        {
            return DALDers.DersListesi();
        }
        public static int TalepEkleBLL(EntityBasvuruForm p)
        {
            if(p.BASDERSID!=null && p.BASOGRID!=null)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
