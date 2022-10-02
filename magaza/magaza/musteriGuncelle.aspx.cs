using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace magaza
{
    public partial class musteriGuncelle : System.Web.UI.Page
    {
        musteriCRUD musislem = new musteriCRUD();
        Musteri musteri = new Musteri();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x =Convert.ToInt32(Request.QueryString["prm"]);
            if(!IsPostBack)
            {
                musteri = musislem.musterigetir(x);
                TextBox1.Text=musteri.Musterino.ToString();
                TextBox2.Text=musteri.Ad.ToString();
                TextBox3.Text=musteri.Soyad.ToString();
                TextBox4.Text = musteri.Dogtar.Date.ToString("yyyy-MM-dd");
                TextBox5.Text=musteri.Ceptel.ToString();
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool gelen;
            musteri.Musterino = Convert.ToInt32(TextBox1.Text);
            musteri.Ad = TextBox2.Text;
            musteri.Soyad = TextBox3.Text;
            musteri.Dogtar = Convert.ToDateTime(TextBox4.Text).Date;
            musteri.Ceptel = TextBox5.Text;

            gelen = musislem.guncelle(musteri);
            if (gelen == true)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Notify", "showSucessNotification();", true);
            }
            else
            {
                basarisiz.Visible = true;
            }

        }
    }
}