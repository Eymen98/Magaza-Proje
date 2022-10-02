using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace magaza
{
    public partial class urunListe : System.Web.UI.Page
    {
        bool gelen;
        urunCRUD urislem = new urunCRUD();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["prm"]==null)
            {
                DataTable tbl = new DataTable();
                tbl = urislem.listele();
                Tablo.InnerHtml = "<table class='table table-success table-bordered table-hover table-striped'>";
                Tablo.InnerHtml += "<tr class='fw-bold'><td>Ürün No</td> <td>Ürün Adı</td> <td>Fiyat</td> <td>Miktar</td> <td>SİL</td> <td>Güncelle</td> </tr>";

                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    Tablo.InnerHtml += "<tr><td>" + tbl.Rows[i][0] + "</td><td>" + tbl.Rows[i][1] + "</td><td>" + tbl.Rows[i][2] + "</td><td>" + tbl.Rows[i][3]
                       + "</td><td><a href='urunListe.aspx?prm=" + tbl.Rows[i][0] + "' onclick=\"return confirm('Kaydı silmek istediğinizden emin misiniz?');\"><img src='images/delete.png' width='20px' height='20px'></a></td><td><a href='urunGuncelle.aspx?prm=" + tbl.Rows[i][0] + "'><img src='images/guncelle.png' width='20px' height='20px'></a></td></tr>";
                }

                Tablo.InnerHtml += "</table>";
            }

            else
            {
                gelen = urislem.sil(Convert.ToInt32(Request.QueryString["prm"]));
                if(gelen==true)
                {
                    Response.Redirect("urunListe.aspx");
                }
                else
                {
                    basarili.Visible = false;
                    basarisiz.Visible = true;
                }

            }
            
            
        }
    }
}