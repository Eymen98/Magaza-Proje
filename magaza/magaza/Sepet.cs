using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace magaza
{
    public class Sepet
    {
        int satisno, mno, uno, miktar;
        DateTime tarih;

        public int Satisno { get => satisno; set => satisno = value; }
        public int Mno { get => mno; set => mno = value; }
        public int Uno { get => uno; set => uno = value; }
        public int Miktar { get => miktar; set => miktar = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
    }
}