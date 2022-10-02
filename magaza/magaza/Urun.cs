using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace magaza
{
    public class Urun
    {
        int urunno, miktar;
        string urunadi;
        double fiyat;

        public int Urunno { get => urunno; set => urunno = value; }
        public int Miktar { get => miktar; set => miktar = value; }
        public string Urunadi { get => urunadi; set => urunadi = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
    }
}