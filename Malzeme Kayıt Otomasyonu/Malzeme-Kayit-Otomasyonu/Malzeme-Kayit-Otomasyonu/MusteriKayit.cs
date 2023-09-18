using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Malzeme_Kayit_Otomasyonu
{
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }


        SqlBaglantisi bgl = new SqlBaglantisi();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            anaSayfa fr = new anaSayfa();
            fr.Show();
            this.Hide();
        }

        private void kaydet_Click(object sender, EventArgs e)
        {

            if (Ad.Text == "" || Soyad.Text == ""|| tc.Text == "" || telefon.Text == "" || il.Text == "" || ilce.Text == "" || adres.Text == "")
            {
                MessageBox.Show("Bilgileri eksiksiz giriniz.");
            }

            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_MusteriKayit (MusteriAd,MusteriSoyad,MusteriTC,MusteriTelefon,MusterIl,MusteriIlce,MusteriAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Ad.Text);
                komut.Parameters.AddWithValue("@p2", Soyad.Text);
                komut.Parameters.AddWithValue("@p3", tc.Text);
                komut.Parameters.AddWithValue("@p4", telefon.Text);
                komut.Parameters.AddWithValue("@p5", il.Text);
                komut.Parameters.AddWithValue("@p6", ilce.Text);
                komut.Parameters.AddWithValue("@p7", adres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız Gerçeklemiştir Müşteri AD: " + Ad.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {
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

        private void il_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilce.Items.Clear();
            ilce.Text = "";
            SqlCommand komut3 = new SqlCommand("select * from ilceler where sehirid=@p1", bgl.baglanti());
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
