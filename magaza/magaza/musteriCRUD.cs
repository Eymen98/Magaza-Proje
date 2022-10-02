using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace magaza
{
    public class musteriCRUD
    {
         Db db=new Db();

        public bool kaydet(Musteri mu)
        {
            int test;
            bool cevap = true;
            db.ac();

            SqlCommand komut = new SqlCommand("insert into Musteri values(@Ad,@Soyad,@Dogtar,@Ceptel)", db.baglanti);
            komut.Parameters.AddWithValue("@Ad", mu.Ad);
            komut.Parameters.AddWithValue("@Soyad", mu.Soyad);
            komut.Parameters.AddWithValue("@Dogtar", Convert.ToDateTime(mu.Dogtar));
            komut.Parameters.AddWithValue("@Ceptel", mu.Ceptel);
            test = komut.ExecuteNonQuery();
            if(test == 0)
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
            SqlCommand komut = new SqlCommand("select * from Musteri", db.baglanti);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = komut;
            adp.Fill(dt);
            db.kapat();
            return dt;
        }

        public bool sil(int mno)
        {
            int test;
            bool cevap=true;
            db.ac();
            SqlCommand komut = new SqlCommand("delete from Musteri where mno=@s",db.baglanti);
            komut.Parameters.AddWithValue("@s",mno);
            test= komut.ExecuteNonQuery();
            if(test == 0)
            {
                cevap = false;
            }
            db.kapat();
            return cevap;

        }


        public Musteri musterigetir(int MNO)
        {
            Musteri m = new Musteri();
            db.ac();
            DataTable dt = new DataTable();
            SqlCommand komut = new SqlCommand("select * from Musteri where mno=@MNO", db.baglanti);
            komut.Parameters.AddWithValue("@MNO",MNO);
            SqlDataAdapter adp=new SqlDataAdapter();
            adp.SelectCommand=komut;
            adp.Fill(dt);
            m.Musterino = Convert.ToInt32(dt.Rows[0][0]);
            m.Ad =Convert.ToString(dt.Rows[0][1]);
            m.Soyad= Convert.ToString(dt.Rows[0][2]);
            m.Dogtar= Convert.ToDateTime(dt.Rows[0][3]);
            m.Ceptel = Convert.ToString(dt.Rows[0][4]);
            db.kapat();
            return m;
        }


        public bool guncelle(Musteri ymu)
        {
            int test;
            bool cevap = true;
            db.ac();
            SqlCommand komut = new SqlCommand("update Musteri set ad=@b, soyad=@c, dtarih=@d, tel=@e where mno=@a", db.baglanti);
            komut.Parameters.AddWithValue("@a", ymu.Musterino);
            komut.Parameters.AddWithValue("@b",ymu.Ad);
            komut.Parameters.AddWithValue("@c",ymu.Soyad);
            komut.Parameters.AddWithValue("@d",ymu.Dogtar);
            komut.Parameters.AddWithValue("@e",ymu.Ceptel);
            test = komut.ExecuteNonQuery();

            if(test==0)
            {
                cevap=false;
            }

            db.kapat();
            return cevap;
        }
    }
}