using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityOgretmen
    {
        private string ogrtad;
        private int ogrtid;
        private string ogrtbrans;

        public string OGRTAD { get => ogrtad; set => ogrtad = value; }
        public int OGRTID { get => ogrtid; set => ogrtid = value; }
        public string OGRTBRANS { get => ogrtbrans; set => ogrtbrans = value; }
    }
}
