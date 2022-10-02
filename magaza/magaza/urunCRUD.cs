using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace magaza
{
    public class urunCRUD
    {
        Db db=new Db();

        public bool kaydet(Urun un)
        {
            int test;
            bool cevap;
            
            db.ac();
            SqlCommand komut = new SqlCommand("insert into Urun values(@Urunadi,@Fiyat,@Miktar)",db.baglanti);
            komut.Parameters.AddWithValue("@Urunadi", un.Urunadi);
            komut.Parameters.AddWithValue("@Fiyat", un.Fiyat);
            komut.Parameters.AddWithValue("@Miktar", un.Miktar);
            test = komut.ExecuteNonQuery();

            if(test==1)
            {
                cevap = true;
            }
            else
            {
                cevap = false;
            }
            db.kapat();

            return cevap;
        }

        public DataTable listele()
        {
            DataTable dt = new DataTable();
            db.ac();
            SqlCommand komut = new SqlCommand("select * from Urun", db.baglanti);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = komut;
            adpt.Fill(dt);
            db.kapat();
            return dt;
        }

        public bool sil(int urno)
        {
            int test;
            bool cevap;
            db.ac();
            SqlCommand komut = new SqlCommand("delete from Urun where urunno=@a",db.baglanti);
            komut.Parameters.AddWithValue("@a", urno);
            test = komut.ExecuteNonQuery();
            if(test == 1)
            {
                cevap=true;
            }
            else
            {
                cevap = false;
            }
            db.kapat();
            return cevap;

        }

        public Urun urungetir(int uNo)
        {
            Urun urun = new Urun();
            db.ac();
            DataTable dt = new DataTable();
            SqlCommand komut = new SqlCommand("select * from Urun where urunno=@uNo", db.baglanti);
            komut.Parameters.AddWithValue("@uNo",uNo);
            SqlDataAdapter adp=new SqlDataAdapter();
            adp.SelectCommand = komut;
            adp.Fill(dt);
            urun.Urunno = Convert.ToInt32(dt.Rows[0][0]);
            urun.Urunadi=Convert.ToString(dt.Rows[0][1]);
            urun.Fiyat=Convert.ToDouble(dt.Rows[0][2]);
            urun.Miktar = Convert.ToInt32(dt.Rows[0][3]);
            db.kapat(); 
            return urun;
        }

        public bool guncelle(Urun UR)
        {
            int test;
            bool cevap;
            db.ac();
            SqlCommand komut = new SqlCommand("update Urun set urun_adi=@b, fiyat=@c, miktar=@d where urunno=@a", db.baglanti);
            komut.Parameters.AddWithValue("@a", UR.Urunno);
            komut.Parameters.AddWithValue("@b", UR.Urunadi);
            komut.Parameters.AddWithValue("@c", UR.Fiyat);
            komut.Parameters.AddWithValue("@d", UR.Miktar);
            test = komut.ExecuteNonQuery();

            if(test==1)
            {
                cevap = true;
            }
            else
            {
                cevap = false;
            }
            db.kapat();
            return cevap;



        }
    }
}