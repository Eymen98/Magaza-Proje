using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace magaza
{
    public class sepetCRUD
    {
        Db db=new Db();

        public bool kaydet(Sepet ysat)
        {
            int test;
            bool cevap = true;
            db.ac();
            SqlCommand komut = new SqlCommand("insert into musteriurun values(@mno,@uno,@tar,@adet)", db.baglanti);
            komut.Parameters.AddWithValue("@mno", ysat.Mno);
            komut.Parameters.AddWithValue("@uno", ysat.Uno);
            komut.Parameters.AddWithValue("@tar", ysat.Tarih);
            komut.Parameters.AddWithValue("@adet", ysat.Miktar);
            test = komut.ExecuteNonQuery();
            if (test == 0)
            {
                cevap = false;
            }

            db.kapat();
            return cevap;
        }


        public DataTable liste()
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            db.ac();
            SqlCommand komut = new SqlCommand("" +
                "select Musteri.ad,Musteri.soyad,Urun.urun_adi,Urun.fiyat, musteriurun.tarih,musteriurun.miktar,musteriurun.id from musteriurun " +
                " inner join Musteri on Musteri.mno=musteriurun.mno " +
                " inner join Urun on Urun.urunno=musteriurun.uno ", db.baglanti);
            adp.SelectCommand = komut;
            adp.Fill(tbl);

            db.kapat();
            return tbl;
        }


        public bool sil(int sno)
        {
            bool cevap = true;
            int ksay;
            db.ac();
            SqlCommand komut = new SqlCommand("delete from musteriurun where id=@sno", db.baglanti);
            komut.Parameters.AddWithValue("@sno", sno);
            ksay = komut.ExecuteNonQuery();
            if (ksay == 0)
            {
                cevap = false;
            }
            db.kapat();
            return cevap;
        }
    }
}