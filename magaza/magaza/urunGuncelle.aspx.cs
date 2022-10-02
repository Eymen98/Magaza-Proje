using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace magaza
{
    public partial class urunGuncelle : System.Web.UI.Page
    {
        urunCRUD urnislem = new urunCRUD();
        Urun urn = new Urun();
        protected void Page_Load(object sender, EventArgs e)
        {
            int urno = Convert.ToInt32(Request.QueryString["prm"]);
            if (!IsPostBack)
            {
                urn = urnislem.urungetir(urno);
                TextBox1.Text = urn.Urunno.ToString();
                TextBox2.Text = urn.Urunadi;
                TextBox3.Text = urn.Fiyat.ToString();
                TextBox4.Text = urn.Miktar.ToString();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            urn.Urunno = Convert.ToInt32(TextBox1.Text);
            urn.Urunadi = TextBox2.Text;
            urn.Fiyat = Convert.ToDouble(TextBox3.Text);
            urn.Miktar = Convert.ToInt32(TextBox4.Text);

            bool mesaj = urnislem.guncelle(urn);
            if (mesaj==true)
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