using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace magaza
{
    public partial class musteriListe : System.Web.UI.Page
    {
        musteriCRUD muislem = new musteriCRUD();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["prm"]==null)
            {
                DataTable tbl = new DataTable();
                tbl = muislem.listele();
                Tablo.InnerHtml = "<table class='table table-warning  table-bordered table-hover table-striped'>";
                Tablo.InnerHtml += "<tr class='fw-bold'><td>Müşteri No</td> <td>Müşterinin Adi</td> <td>Müşterinin Soyadı</td> <td>Doğum Tarihi</td> <td>Cep telefon</td> <td>SİL</td> <td>Güncelle</td> </tr>";
                for (int i = 0; i < tbl.Rows.Count; i++)
                {
                    Tablo.InnerHtml += "<tr><td>" + tbl.Rows[i][0] + "</td><td>" + tbl.Rows[i][1] + "</td><td>" + tbl.Rows[i][2] + "</td><td>"
                        + Convert.ToDateTime(tbl.Rows[i][3].ToString()).ToShortDateString() + "</td><td>" + tbl.Rows[i][4] + "</td><td><a href='musteriListe.aspx?prm=" + tbl.Rows[i][0] + "' onclick=\"return confirm('Kaydı silmek istediğinizden emin misiniz?');\"><img src='images/delete.png' width='20px' height='20px'></a></td><td><a href='musteriGuncelle.aspx?prm=" + tbl.Rows[i][0] + "'><img src='images/guncelle.png' width='20px' height='20px'></a></td></tr>"; ;
                }
                Tablo.InnerHtml += "</table>";
            }

            else
            {
                bool mesaj;
                mesaj=muislem.sil(Convert.ToInt32(Request.QueryString["prm"]));
                if (mesaj == true)
                {
                    Response.Redirect("musteriListe.aspx");
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