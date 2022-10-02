using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace magaza
{
    public partial class musteriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool mesaj;
            Musteri musteri = new Musteri();
            musteri.Ad = TextBox2.Text;
            musteri.Soyad = TextBox3.Text;
            musteri.Dogtar = Convert.ToDateTime(TextBox4.Text);
            musteri.Ceptel = TextBox5.Text;

            musteriCRUD islem = new musteriCRUD();
            mesaj=islem.kaydet(musteri);
            if(mesaj==true)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Notify", "showSucessNotification();", true);

                TextBox2.Text = string.Empty;
                TextBox3.Text = string.Empty;
                TextBox4.Text = string.Empty;
                TextBox5.Text = string.Empty;
            }
            else
            {
                basarisiz.Visible = true;
            }
        }
    }
}