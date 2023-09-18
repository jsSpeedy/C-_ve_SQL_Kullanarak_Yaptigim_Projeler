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
    public partial class MusteriGuncelleme : Form
    {
        public MusteriGuncelleme()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void label7_Click(object sender, EventArgs e)
        {

        }
        DataTable dt = new DataTable();

        private void MusteriGuncelleme_Load(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_MusteriKayit", bgl.baglanti());
            da.Fill(dt);
            muısteriBilgileri.DataSource = dt;

            SqlCommand komut = new SqlCommand("select il from Tbl_iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                il.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select ilceadi from ilceler", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                ilce.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void muısteriBilgileri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void muısteriBilgileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = muısteriBilgileri.SelectedCells[0].RowIndex;
            Ad.Text = muısteriBilgileri.Rows[secilen].Cells[1].Value.ToString();
            Soyad.Text = muısteriBilgileri.Rows[secilen].Cells[2].Value.ToString();
            tc.Text = muısteriBilgileri.Rows[secilen].Cells[3].Value.ToString();
            telefon.Text = muısteriBilgileri.Rows[secilen].Cells[4].Value.ToString();
            il.Text = muısteriBilgileri.Rows[secilen].Cells[5].Value.ToString();
            ilce.Text = muısteriBilgileri.Rows[secilen].Cells[6].Value.ToString();
            adres.Text = muısteriBilgileri.Rows[secilen].Cells[7].Value.ToString();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (Ad.Text == "" || Soyad.Text == "" || tc.Text == "" || telefon.Text == "" || il.Text == "" || ilce.Text == "" || adres.Text == "")
            {
                MessageBox.Show("Bilgileri eksiksiz giriniz.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("Update Tbl_MusteriKayit set MusteriAd=@d1,MusteriSoyad=@d2,MusteriTelefon=@d4,MusterIl=@d5,MusteriIlce=@d6,MusteriAdres=@d7 where MusteriTC=@d3", bgl.baglanti());
                komut.Parameters.AddWithValue("@d1", Ad.Text);
                komut.Parameters.AddWithValue("@d2", Soyad.Text);
                komut.Parameters.AddWithValue("@d3", tc.Text);
                komut.Parameters.AddWithValue("@d4", telefon.Text);
                komut.Parameters.AddWithValue("@d5", il.Text);
                komut.Parameters.AddWithValue("@d6", ilce.Text);
                komut.Parameters.AddWithValue("@d7", adres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Müşteri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void sil_Click(object sender, EventArgs e)
        {
            if (Ad.Text == "" || Soyad.Text == "" || tc.Text == "" || telefon.Text == "" || il.Text == "" || ilce.Text == "" || adres.Text == "")
            {
                MessageBox.Show("Bilgileri eksiksiz giriniz.");
            }
            else
            {
                SqlCommand komut = new SqlCommand("Delete from Tbl_MusteriKayit where MusteriTC=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", tc.Text);
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

        
        
        private void musteriAra_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "MusteriTC LIKE '" + musteriAra.Text + "%'";
            muısteriBilgileri.DataSource = dv;
        }

        private void il_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilce.Items.Clear();
            ilce.Text = "";
            SqlCommand komut3 = new SqlCommand("select * from ilceler where sehirid=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", il.SelectedIndex + 1);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                ilce.Items.Add(dr3[1]);
            }
            bgl.baglanti().Close();

        }
    }
}
