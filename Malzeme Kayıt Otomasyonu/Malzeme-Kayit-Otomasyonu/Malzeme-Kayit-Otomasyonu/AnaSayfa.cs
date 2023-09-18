using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malzeme_Kayit_Otomasyonu
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void musteriKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriKayit mk = new MusteriKayit();
            mk.Show();
            this.Hide();
        }

        private void musteriGuncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriGuncelleme mg  = new MusteriGuncelleme();
            mg.Show();
            this.Hide();
        }

        private void urunKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunKayit uk = new UrunKayit();
            uk.Show();
            this.Hide();
        }

        private void urunGuncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunGuncelleme ug  =    new UrunGuncelleme();
            ug.Show();
            this.Hide();
        }

        private void satisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisYap sy = new SatisYap();
            sy.Show();
            this.Hide();
        }

        private void satisGoruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisGoruntule sg = new SatisGoruntule();
            sg.Show();
            this.Hide();
        }

        private void anaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
