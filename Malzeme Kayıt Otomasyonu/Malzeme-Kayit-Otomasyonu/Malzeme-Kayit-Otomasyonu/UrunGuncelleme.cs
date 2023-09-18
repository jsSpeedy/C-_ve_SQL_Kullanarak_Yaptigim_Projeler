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
    public partial class UrunGuncelleme : Form
    {
        public UrunGuncelleme()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        DataTable dt = new DataTable();

        private void UrunGuncelleme_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_UrunKayit", bgl.baglanti());
            da.Fill(dt);
            UrunBilgileri.DataSource = dt;

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

        private void urunGuncelle_Click(object sender, EventArgs e)
        {
            if (kategori.Text == "" || marka.Text == "" || modelKodu.Text == "" || stokKodu.Text == "" || adet.Text == "" || alisFiyati.Text == "" || KDV.Text == "" || urunOzellik.Text == "")
            {
                MessageBox.Show("Bilgileri eksiksiz giriniz.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("Update Tbl_UrunKayit set UrunKategori=@d1,UrunMarka=@d2,UrunStokKodu=@d4,UrunAdet=@d5,UrunAlisFiyati=@d6,UrunKDV=@d7,UrunOzellikleri=@d8 where UrunModelKodu=@d3", bgl.baglanti());
                komut.Parameters.AddWithValue("@d1", kategori.Text);
                komut.Parameters.AddWithValue("@d2", marka.Text);
                komut.Parameters.AddWithValue("@d3", modelKodu.Text);
                komut.Parameters.AddWithValue("@d4", stokKodu.Text);
                komut.Parameters.AddWithValue("@d5", adet.Text);
                komut.Parameters.AddWithValue("@d6", alisFiyati.Text);
                komut.Parameters.AddWithValue("@d7", KDV.Text);
                komut.Parameters.AddWithValue("@d8", urunOzellik.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void urunAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "UrunModelKodu LIKE '" + urunAra.Text + "%'";
            UrunBilgileri.DataSource = dv;
        }

        private void UrunBilgileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = UrunBilgileri.SelectedCells[0].RowIndex;
            kategori.Text = UrunBilgileri.Rows[secilen].Cells[1].Value.ToString();
            marka.Text = UrunBilgileri.Rows[secilen].Cells[2].Value.ToString();
            modelKodu.Text = UrunBilgileri.Rows[secilen].Cells[3].Value.ToString();
            stokKodu.Text = UrunBilgileri.Rows[secilen].Cells[4].Value.ToString();
            adet.Text = UrunBilgileri.Rows[secilen].Cells[5].Value.ToString();
            alisFiyati.Text = UrunBilgileri.Rows[secilen].Cells[6].Value.ToString();
            KDV.Text = UrunBilgileri.Rows[secilen].Cells[7].Value.ToString();
            urunOzellik.Text = UrunBilgileri.Rows[secilen].Cells[8].Value.ToString();
        }

        private void urunSil_Click(object sender, EventArgs e)
        {
            if (kategori.Text == "" || marka.Text == "" || modelKodu.Text == "" || stokKodu.Text == "" || adet.Text == "" || alisFiyati.Text == "" || KDV.Text == "" || urunOzellik.Text == "")
            {
                MessageBox.Show("Bilgileri eksiksiz giriniz.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("Delete from Tbl_UrunKayit where UrunModelKodu=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", modelKodu.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaSayfa fr = new anaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
