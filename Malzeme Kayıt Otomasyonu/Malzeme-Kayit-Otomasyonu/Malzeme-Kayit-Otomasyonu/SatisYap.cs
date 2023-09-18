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
    public partial class SatisYap : Form
    {
        public SatisYap()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();




        private void SatisYap_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_MusteriKayit", bgl.baglanti());
            da.Fill(dt);
            satisMusteriBilgileri.DataSource = dt;

            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_UrunKayit", bgl.baglanti());
            da2.Fill(dt2);
            satisUrunListeme.DataSource = dt2;

            SqlCommand komut = new SqlCommand("select il from Tbl_iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                satisIl.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select ilceadi from ilceler", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                satisIlce.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            SqlCommand komut3 = new SqlCommand("select kategoriAdı from Tbl_Kategoriler", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                satisKategori.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();

            SqlCommand komut4 = new SqlCommand("select MarkaAdi from Tbl_Markalar", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                satisMarka.Items.Add(dr4[0]);
            }
            bgl.baglanti().Close();

        }

        private void satisMusteriBilgileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = satisMusteriBilgileri.SelectedCells[0].RowIndex;
            Ad.Text = satisMusteriBilgileri.Rows[secilen].Cells[1].Value.ToString();
            Soyad.Text = satisMusteriBilgileri.Rows[secilen].Cells[2].Value.ToString();
            satisTC.Text = satisMusteriBilgileri.Rows[secilen].Cells[3].Value.ToString();
            telefon.Text = satisMusteriBilgileri.Rows[secilen].Cells[4].Value.ToString();
            satisIl.Text = satisMusteriBilgileri.Rows[secilen].Cells[5].Value.ToString();
            satisIlce.Text = satisMusteriBilgileri.Rows[secilen].Cells[6].Value.ToString();
            satisAdres.Text = satisMusteriBilgileri.Rows[secilen].Cells[7].Value.ToString();
        }

        private void satisUrunListeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void satisUrunListeme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = satisUrunListeme.SelectedCells[0].RowIndex;
            satisKategori.Text = satisUrunListeme.Rows[secilen].Cells[1].Value.ToString();
            satisMarka.Text = satisUrunListeme.Rows[secilen].Cells[2].Value.ToString();
            satisModelKodu.Text = satisUrunListeme.Rows[secilen].Cells[3].Value.ToString();
            satisStokKodu.Text = satisUrunListeme.Rows[secilen].Cells[4].Value.ToString();
           
            satisAlisFiyati.Text = satisUrunListeme.Rows[secilen].Cells[6].Value.ToString();
            satisKDV.Text = satisUrunListeme.Rows[secilen].Cells[7].Value.ToString();
            satisUrunOzellik.Text = satisUrunListeme.Rows[secilen].Cells[8].Value.ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void satisButon_Click(object sender, EventArgs e)
        {
        
            if(Ad.Text == "" || Soyad.Text == "" || musteriTC.Text == "" || telefon.Text == "" || satisIl.Text == "" || satisIlce.Text == "" || satisAdres.Text == "" || satisKategori.Text == "" || satisMarka.Text == "" || satisModelKodu.Text == "" || satisStokKodu.Text == "" || satisAdet.Text == "" || satisAlisFiyati.Text == "" || satisKDV.Text == "" || satisUrunOzellik.Text == "")
            {
                MessageBox.Show("Bilgileri eksiksiz doldurunuz");
            }
            else
            {
                double alisfiyati2 = double.Parse(satisAlisFiyati.Text);
                double adet2 = double.Parse(satisAdet.Text);
                double carp2 = alisfiyati2 * adet2;

                int secilen = satisUrunListeme.SelectedCells[0].RowIndex;
                SqlCommand komut = new SqlCommand("insert into Tbl_SatisListesi (listeMusteriAdi,listeMusteriSoyadi,listeMusteriTC,listeKategori,listeUrunMarkasi,listeUrunModelKodu,listeUrunAdet,listeUrunOzellik,listeSatisFiyati) " +
                       "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)" +
                       "update Tbl_UrunKayit set UrunAdet = UrunAdet- " + int.Parse(satisAdet.Text).ToString() + " where UrunModelKodu=@d3", bgl.baglanti());

                if (satisKDV.Text == "18")
                {
                    kontrol.Text = Convert.ToString(carp2 + (carp2 * 0.18));

                    if (fiyat.Text == kontrol.Text)
                    {
                        komut.Parameters.AddWithValue("@d3", satisModelKodu.Text);

                        komut.Parameters.AddWithValue("@p1", Ad.Text);
                        komut.Parameters.AddWithValue("@p2", Soyad.Text);
                        komut.Parameters.AddWithValue("@p3", satisTC.Text);
                        komut.Parameters.AddWithValue("@p4", satisKategori.Text);
                        komut.Parameters.AddWithValue("@p5", satisMarka.Text);
                        komut.Parameters.AddWithValue("@p6", satisModelKodu.Text);
                        komut.Parameters.AddWithValue("@p7", satisAdet.Text);
                        komut.Parameters.AddWithValue("@p8", satisUrunOzellik.Text);
                        komut.Parameters.AddWithValue("@p9", fiyat.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Satış Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("fiyat hesaplamasını yeniden yapınız");
                    }

                }

                else if (satisKDV.Text == "1")
                {
                    kontrol.Text = Convert.ToString(carp2 + (carp2 * 0.01));

                    if (fiyat.Text == kontrol.Text)
                    {
                        komut.Parameters.AddWithValue("@d3", satisModelKodu.Text);

                        komut.Parameters.AddWithValue("@p1", Ad.Text);
                        komut.Parameters.AddWithValue("@p2", Soyad.Text);
                        komut.Parameters.AddWithValue("@p3", satisTC.Text);
                        komut.Parameters.AddWithValue("@p4", satisKategori.Text);
                        komut.Parameters.AddWithValue("@p5", satisMarka.Text);
                        komut.Parameters.AddWithValue("@p6", satisModelKodu.Text);
                        komut.Parameters.AddWithValue("@p7", satisAdet.Text);
                        komut.Parameters.AddWithValue("@p8", satisUrunOzellik.Text);
                        komut.Parameters.AddWithValue("@p9", fiyat.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Satış Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("fiyat hesaplamasını yeniden yapınız");
                    }
                }

                else if (satisKDV.Text == "8")
                {
                    kontrol.Text = Convert.ToString(carp2 + (carp2 * 0.08));
                    if (fiyat.Text == kontrol.Text)
                    {
                        komut.Parameters.AddWithValue("@d3", satisModelKodu.Text);

                        komut.Parameters.AddWithValue("@p1", Ad.Text);
                        komut.Parameters.AddWithValue("@p2", Soyad.Text);
                        komut.Parameters.AddWithValue("@p3", satisTC.Text);
                        komut.Parameters.AddWithValue("@p4", satisKategori.Text);
                        komut.Parameters.AddWithValue("@p5", satisMarka.Text);
                        komut.Parameters.AddWithValue("@p6", satisModelKodu.Text);
                        komut.Parameters.AddWithValue("@p7", satisAdet.Text);
                        komut.Parameters.AddWithValue("@p8", satisUrunOzellik.Text);
                        komut.Parameters.AddWithValue("@p9", fiyat.Text);
                        komut.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show("Satış Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("fiyat hesaplamasını yeniden yapınız");
                    }
                }
            }

        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            anaSayfa fr = new anaSayfa();
            fr.Show();
            this.Hide();
        }

        private void urunKodu_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt2.DefaultView;
            dv.RowFilter = "UrunModelKodu LIKE '" + urunKodu.Text + "%'";
            satisUrunListeme.DataSource = dv;
        }

        private void satisKDV_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void fiyat_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
           

            if (satisKDV.Text == "" || satisAdet.Text == "" || satisAlisFiyati.Text == "")
            {
                MessageBox.Show("İlgili alanları doldurunuz");
            }

            else
            {
                double alisfiyati = double.Parse(satisAlisFiyati.Text);
                double adet = double.Parse(satisAdet.Text);
                double carp = alisfiyati * adet;

                if (satisKDV.Text == "18")
                {
                    fiyat.Text = Convert.ToString(carp + (carp * 0.18));
                }

                else if (satisKDV.Text == "1")
                {
                    fiyat.Text = Convert.ToString(carp + (carp * 0.01));
                }
                else if (satisKDV.Text == "8")
                {
                    fiyat.Text = Convert.ToString(carp + (carp * 0.08));
                }
            }

            
        }

        private void musteriTC_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "MusteriTC LIKE '" + musteriTC.Text + "%'";
            satisMusteriBilgileri.DataSource = dv;
        }

        private void satisIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            satisIlce.Items.Clear();
            satisIlce.Text = "";
            SqlCommand komut3 = new SqlCommand("select * from ilceler where sehirid=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", satisIl.SelectedIndex + 1);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                satisIlce.Items.Add(dr3[1]);
            }
            bgl.baglanti().Close();
        }
    }
}
