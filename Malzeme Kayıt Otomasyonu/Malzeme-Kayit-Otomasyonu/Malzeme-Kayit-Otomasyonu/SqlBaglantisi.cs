using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Malzeme_Kayit_Otomasyonu
{
    internal class SqlBaglantisi
    {
         public SqlConnection baglanti()
         {
             SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-Q9R3E9L\\SQLEXPRESS;Initial Catalog=MalzemeKayitOtomasyonu;Integrated Security=True");
             baglan.Open();
             return baglan;
         }
    }
}
