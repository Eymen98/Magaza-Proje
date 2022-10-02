using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace magaza
{
    public partial class sepetListe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool gelen;
            sepetCRUD sislem = new sepetCRUD();
            if (Request.QueryString["prm"] == null)
            {
                DataTable tablom = new DataTable();

                tablom = sislem.liste();
                tabloliste.InnerHtml = "<table class='table table-light table-bordered table-hover table-striped'>";
                tabloliste.InnerHtml += "<tr class='fw-bold'> <td>Müşteri Adı</td> <td>Müşteri Soyadı</td> <td>Ürün Adı</td> <td>Ürün Fiyat</td> <td>İşlem Tarihi</td> <td>Miktar</td> <td>Sil</td></tr>";
                for (int i = 0; i < tablom.Rows.Count; i++)
                {
                    tabloliste.InnerHtml += "<tr><td>" + tablom.Rows[i][0] + "</td><td>" + tablom.Rows[i][1] + "</td><td>" + tablom.Rows[i][2] + "</td><td> " + tablom.Rows[i][3] + "</td><td> " + tablom.Rows[i][4]+ "</td><td> " + tablom.Rows[i][5] + "</td><td><a href='sepetListe.aspx?prm=" + tablom.Rows[i][6] + "' onclick=\"return confirm('Kaydı silmek istediğinizden emin misiniz?');\" ><img src='images/delete.png' width='20px' height='20px'></a></td></tr>";
                }
                tabloliste.InnerHtml += "</table>";
            }
            else
            {
                gelen = sislem.sil(Convert.ToInt32(Request.QueryString["prm"]));
                if (gelen == true)
                {
                    Response.Redirect("sepetListe.aspx");
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