using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace magaza
{
    public partial class urunEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool mesaj;
            Urun urun = new Urun();
        
            urun.Urunadi = TextBox2.Text;
            urun.Fiyat = Convert.ToDouble(TextBox3.Text);
            urun.Miktar = Convert.ToInt32(TextBox4.Text);

            urunCRUD islem=new urunCRUD();
            mesaj = islem.kaydet(urun);

            if(mesaj==true)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Notify", "showSucessNotification();", true);

                TextBox2.Text = string.Empty;
                TextBox3.Text = string.Empty;
                TextBox4.Text = string.Empty;  
            }
            else
            {
                basarisiz.Visible = true;
            }


        }

       
    }
}