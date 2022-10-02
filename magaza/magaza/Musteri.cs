using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace magaza
{
    public class Musteri
    {
        int musterino;
        string ad, soyad,ceptel;
        DateTime dogtar;

        public int Musterino { get => musterino; set => musterino = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public DateTime Dogtar { get => dogtar; set => dogtar = value; }
        public string Ceptel { get => ceptel; set => ceptel = value; }
    }
}