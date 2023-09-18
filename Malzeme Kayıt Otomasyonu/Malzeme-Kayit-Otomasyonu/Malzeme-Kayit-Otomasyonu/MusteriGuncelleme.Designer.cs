namespace Malzeme_Kayit_Otomasyonu
{
    partial class MusteriGuncelleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.adres = new System.Windows.Forms.RichTextBox();
            this.ilce = new System.Windows.Forms.ComboBox();
            this.il = new System.Windows.Forms.ComboBox();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.Ad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.muısteriBilgileri = new System.Windows.Forms.DataGridView();
            this.musteriAra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muısteriBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tc);
            this.groupBox1.Controls.Add(this.adres);
            this.groupBox1.Controls.Add(this.ilce);
            this.groupBox1.Controls.Add(this.il);
            this.groupBox1.Controls.Add(this.telefon);
            this.groupBox1.Controls.Add(this.Soyad);
            this.groupBox1.Controls.Add(this.Ad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(121, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1272, 191);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Kayıt Bilgileri";
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(150, 124);
            this.tc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(286, 26);
            this.tc.TabIndex = 15;
            this.tc.ValidatingType = typeof(int);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(940, 52);
            this.adres.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(286, 99);
            this.adres.TabIndex = 13;
            this.adres.Text = "";
            // 
            // ilce
            // 
            this.ilce.FormattingEnabled = true;
            this.ilce.Location = new System.Drawing.Point(563, 124);
            this.ilce.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ilce.Name = "ilce";
            this.ilce.Size = new System.Drawing.Size(286, 27);
            this.ilce.TabIndex = 12;
            // 
            // il
            // 
            this.il.FormattingEnabled = true;
            this.il.Location = new System.Drawing.Point(563, 86);
            this.il.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(286, 27);
            this.il.TabIndex = 11;
            this.il.SelectedIndexChanged += new System.EventHandler(this.il_SelectedIndexChanged);
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(565, 52);
            this.telefon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.telefon.Mask = "(999) 000-0000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(284, 26);
            this.telefon.TabIndex = 10;
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(150, 87);
            this.Soyad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(286, 26);
            this.Soyad.TabIndex = 8;
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(150, 52);
            this.Ad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(286, 26);
            this.Ad.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(859, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "İlçe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "İl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "TCKN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Müşteri Ara:";
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(837, 242);
            this.sil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(235, 53);
            this.sil.TabIndex = 17;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(592, 242);
            this.guncelle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(235, 53);
            this.guncelle.TabIndex = 18;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // muısteriBilgileri
            // 
            this.muısteriBilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.muısteriBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.muısteriBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.muısteriBilgileri.Location = new System.Drawing.Point(20, 324);
            this.muısteriBilgileri.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.muısteriBilgileri.Name = "muısteriBilgileri";
            this.muısteriBilgileri.Size = new System.Drawing.Size(1487, 392);
            this.muısteriBilgileri.TabIndex = 19;
            this.muısteriBilgileri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.muısteriBilgileri_CellClick);
            this.muısteriBilgileri.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.muısteriBilgileri_CellDoubleClick);
            // 
            // musteriAra
            // 
            this.musteriAra.Location = new System.Drawing.Point(283, 256);
            this.musteriAra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.musteriAra.Name = "musteriAra";
            this.musteriAra.Size = new System.Drawing.Size(286, 26);
            this.musteriAra.TabIndex = 16;
            this.musteriAra.Text = "Kimlik No İle";
            this.musteriAra.TextChanged += new System.EventHandler(this.musteriAra_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1082, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 53);
            this.button1.TabIndex = 20;
            this.button1.Text = "Ana Sayfaya Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusteriGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1529, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.musteriAra);
            this.Controls.Add(this.muısteriBilgileri);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MusteriGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Guncelleme";
            this.Load += new System.EventHandler(this.MusteriGuncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muısteriBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.RichTextBox adres;
        private System.Windows.Forms.ComboBox ilce;
        private System.Windows.Forms.ComboBox il;
        private System.Windows.Forms.MaskedTextBox telefon;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.DataGridView muısteriBilgileri;
        private System.Windows.Forms.TextBox musteriAra;
        private System.Windows.Forms.Button button1;
    }
}