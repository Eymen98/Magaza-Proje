using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace magaza
{
    public partial class sepetEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            sepet.Mno = Convert.ToInt32(DropDownList1.SelectedValue);
            sepet.Uno = Convert.ToInt32(DropDownList2.SelectedValue);
            sepet.Tarih = DateTime.Now;
            sepet.Miktar = Convert.ToInt32(TextBox1.Text);

            sepetCRUD islem = new sepetCRUD();
            bool mesaj = islem.kaydet(sepet);
            if (mesaj == true)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Notify", "showSucessNotification();", true);
                TextBox1.Text = string.Empty;
            }
            else
            {
                basarisiz.Visible = true;
            }
        }

        

        protected void DropDownList1_DataBound(object sender, EventArgs e)
        {
            DropDownList1.Items.Insert(0, "Lütfen Seçiniz");
        }

        protected void DropDownList2_DataBound(object sender, EventArgs e)
        {
            DropDownList2.Items.Insert(0, "Lütfen Seçiniz");
        }
    }
}