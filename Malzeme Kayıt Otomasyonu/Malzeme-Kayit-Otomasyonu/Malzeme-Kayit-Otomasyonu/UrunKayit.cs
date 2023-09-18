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
    public partial class UrunKayit : Form
    {
        public UrunKayit()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

         

        private void urunKaydet_Click(object sender, EventArgs e)
        {
            if (kategori.Text == "" || marka.Text == "" || modelKodu.Text == "" || stokKodu.Text == "" || adet.Text == "" || alisFiyati.Text == "" || KDV.Text == "" || urunOzellik.Text == "")
            {
                MessageBox.Show("Bilgileri eksiksiz giriniz.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_UrunKayit (UrunKategori,UrunMarka,UrunModelKodu,UrunStokKodu,UrunAdet,UrunAlisFiyati,UrunKDV,UrunOzellikleri) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", kategori.Text);
                komut.Parameters.AddWithValue("@p2", marka.Text);
                komut.Parameters.AddWithValue("@p3", modelKodu.Text);
                komut.Parameters.AddWithValue("@p4", stokKodu.Text);
                komut.Parameters.AddWithValue("@p5", adet.Text);
                komut.Parameters.AddWithValue("@p6", alisFiyati.Text);
                komut.Parameters.AddWithValue("@p7", KDV.Text);
                komut.Parameters.AddWithValue("@p8", urunOzellik.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız Gerçeklemiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void UrunKayit_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select kategoriAdı from Tbl_Kategoriler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kategori.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select MarkaAdi from Tbl_Markalar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                marka.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void anaSayfa_Click(object sender, EventArgs e)
        {
            anaSayfa fr = new anaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
