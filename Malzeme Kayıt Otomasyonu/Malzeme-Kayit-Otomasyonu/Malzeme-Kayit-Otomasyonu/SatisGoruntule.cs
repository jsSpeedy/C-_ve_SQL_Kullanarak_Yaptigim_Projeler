using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malzeme_Kayit_Otomasyonu
{
    public partial class SatisGoruntule : Form
    {
        public SatisGoruntule()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        DataTable dt = new DataTable();

        private void SatisGoruntule_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_SatisListesi", bgl.baglanti());
            da.Fill(dt);
            satisListesi.DataSource = dt;
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            anaSayfa fr = new anaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
