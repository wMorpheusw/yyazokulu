using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ograd;
        private string ogrsoyad;
        private int ogrid;
        private string ogrnumara;
        private string ogrfotograf;
        private double ogrbakiye;
        private string ogrsifre;

        public string OGRAD { get => ograd; set => ograd = value; }
        public string OGRSOYAD { get => ogrsoyad; set => ogrsoyad = value; }
        public int OGRID { get => ogrid; set => ogrid = value; }
        public string OGRNUMARA { get => ogrnumara; set => ogrnumara = value; }
        public string OGRFOTOGRAF { get => ogrfotograf; set => ogrfotograf = value; }
        public double OGRBAKIYE { get => ogrbakiye; set => ogrbakiye = value; }
        public string OGRSIFRE { get => ogrsifre; set => ogrsifre = value; }
    }
}
