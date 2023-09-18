namespace Malzeme_Kayit_Otomasyonu
{
    partial class anaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaSayfa));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.musteriKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriGuncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.urunKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunGuncellemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.satisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satisGoruntuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1333, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriKayıtToolStripMenuItem,
            this.musteriGuncellemeToolStripMenuItem});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(148, 23);
            this.toolStripSplitButton1.Text = "Müşteri İşlemleri";
            // 
            // musteriKayıtToolStripMenuItem
            // 
            this.musteriKayıtToolStripMenuItem.Name = "musteriKayıtToolStripMenuItem";
            this.musteriKayıtToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.musteriKayıtToolStripMenuItem.Text = "Müşteri Kayıt";
            this.musteriKayıtToolStripMenuItem.Click += new System.EventHandler(this.musteriKayitToolStripMenuItem_Click);
            // 
            // musteriGuncellemeToolStripMenuItem
            // 
            this.musteriGuncellemeToolStripMenuItem.Name = "musteriGuncellemeToolStripMenuItem";
            this.musteriGuncellemeToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.musteriGuncellemeToolStripMenuItem.Text = "Müşteri Güncelleme";
            this.musteriGuncellemeToolStripMenuItem.Click += new System.EventHandler(this.musteriGuncellemeToolStripMenuItem_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunKayıtToolStripMenuItem,
            this.urunGuncellemeToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(127, 23);
            this.toolStripSplitButton2.Text = "Stok İşlemleri";
            // 
            // urunKayıtToolStripMenuItem
            // 
            this.urunKayıtToolStripMenuItem.Name = "urunKayıtToolStripMenuItem";
            this.urunKayıtToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.urunKayıtToolStripMenuItem.Text = "Ürün Kayıt";
            this.urunKayıtToolStripMenuItem.Click += new System.EventHandler(this.urunKayıtToolStripMenuItem_Click);
            // 
            // urunGuncellemeToolStripMenuItem
            // 
            this.urunGuncellemeToolStripMenuItem.Name = "urunGuncellemeToolStripMenuItem";
            this.urunGuncellemeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.urunGuncellemeToolStripMenuItem.Text = "Ürün Güncelleme";
            this.urunGuncellemeToolStripMenuItem.Click += new System.EventHandler(this.urunGuncellemeToolStripMenuItem_Click);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satisYapToolStripMenuItem,
            this.satisGoruntuleToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(130, 23);
            this.toolStripSplitButton3.Text = "Satış İşlemleri";
            // 
            // satisYapToolStripMenuItem
            // 
            this.satisYapToolStripMenuItem.Name = "satisYapToolStripMenuItem";
            this.satisYapToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.satisYapToolStripMenuItem.Text = "Satış Yap";
            this.satisYapToolStripMenuItem.Click += new System.EventHandler(this.satisYapToolStripMenuItem_Click);
            // 
            // satisGoruntuleToolStripMenuItem
            // 
            this.satisGoruntuleToolStripMenuItem.Name = "satisGoruntuleToolStripMenuItem";
            this.satisGoruntuleToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.satisGoruntuleToolStripMenuItem.Text = "Satış Görüntüle";
            this.satisGoruntuleToolStripMenuItem.Click += new System.EventHandler(this.satisGoruntuleToolStripMenuItem_Click);
            // 
            // anaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 658);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "anaSayfa";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.anaSayfa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem musteriKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriGuncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem urunKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunGuncellemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem satisYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satisGoruntuleToolStripMenuItem;
    }
}

