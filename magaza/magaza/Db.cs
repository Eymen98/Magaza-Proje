using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace magaza
{
    public class Db
    {
        public SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["magazaDB"].ConnectionString);

        public void ac()
        {
            baglanti.Open();
        }

        public void kapat()
        {
            baglanti.Close();
        }

    }
}