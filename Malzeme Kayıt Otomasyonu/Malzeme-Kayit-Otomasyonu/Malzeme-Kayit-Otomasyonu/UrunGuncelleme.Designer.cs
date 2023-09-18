namespace Malzeme_Kayit_Otomasyonu
{
    partial class UrunGuncelleme
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
            this.button1 = new System.Windows.Forms.Button();
            this.urunSil = new System.Windows.Forms.Button();
            this.urunGuncelle = new System.Windows.Forms.Button();
            this.urunOzellik = new System.Windows.Forms.RichTextBox();
            this.KDV = new System.Windows.Forms.ComboBox();
            this.alisFiyati = new System.Windows.Forms.TextBox();
            this.adet = new System.Windows.Forms.TextBox();
            this.stokKodu = new System.Windows.Forms.TextBox();
            this.modelKodu = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.ComboBox();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.urunAra = new System.Windows.Forms.TextBox();
            this.UrunBilgileri = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrunBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.urunSil);
            this.groupBox1.Controls.Add(this.urunGuncelle);
            this.groupBox1.Controls.Add(this.urunOzellik);
            this.groupBox1.Controls.Add(this.KDV);
            this.groupBox1.Controls.Add(this.alisFiyati);
            this.groupBox1.Controls.Add(this.adet);
            this.groupBox1.Controls.Add(this.stokKodu);
            this.groupBox1.Controls.Add(this.modelKodu);
            this.groupBox1.Controls.Add(this.marka);
            this.groupBox1.Controls.Add(this.kategori);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(370, 573);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri Güncelleme";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 522);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 39);
            this.button1.TabIndex = 26;
            this.button1.Text = "Ana Sayfaya Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urunSil
            // 
            this.urunSil.Location = new System.Drawing.Point(165, 475);
            this.urunSil.Margin = new System.Windows.Forms.Padding(4);
            this.urunSil.Name = "urunSil";
            this.urunSil.Size = new System.Drawing.Size(182, 39);
            this.urunSil.TabIndex = 25;
            this.urunSil.Text = "Sil";
            this.urunSil.UseVisualStyleBackColor = true;
            this.urunSil.Click += new System.EventHandler(this.urunSil_Click);
            // 
            // urunGuncelle
            // 
            this.urunGuncelle.Location = new System.Drawing.Point(165, 428);
            this.urunGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.urunGuncelle.Name = "urunGuncelle";
            this.urunGuncelle.Size = new System.Drawing.Size(182, 39);
            this.urunGuncelle.TabIndex = 24;
            this.urunGuncelle.Text = "Güncelle";
            this.urunGuncelle.UseVisualStyleBackColor = true;
            this.urunGuncelle.Click += new System.EventHandler(this.urunGuncelle_Click);
            // 
            // urunOzellik
            // 
            this.urunOzellik.Location = new System.Drawing.Point(165, 285);
            this.urunOzellik.Margin = new System.Windows.Forms.Padding(4);
            this.urunOzellik.Name = "urunOzellik";
            this.urunOzellik.Size = new System.Drawing.Size(180, 131);
            this.urunOzellik.TabIndex = 23;
            this.urunOzellik.Text = "";
            // 
            // KDV
            // 
            this.KDV.FormattingEnabled = true;
            this.KDV.Items.AddRange(new object[] {
            "1",
            "8",
            "18"});
            this.KDV.Location = new System.Drawing.Point(165, 248);
            this.KDV.Margin = new System.Windows.Forms.Padding(4);
            this.KDV.Name = "KDV";
            this.KDV.Size = new System.Drawing.Size(180, 26);
            this.KDV.TabIndex = 22;
            // 
            // alisFiyati
            // 
            this.alisFiyati.Location = new System.Drawing.Point(165, 212);
            this.alisFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.alisFiyati.Name = "alisFiyati";
            this.alisFiyati.Size = new System.Drawing.Size(180, 25);
            this.alisFiyati.TabIndex = 21;
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(165, 176);
            this.adet.Margin = new System.Windows.Forms.Padding(4);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(180, 25);
            this.adet.TabIndex = 20;
            // 
            // stokKodu
            // 
            this.stokKodu.Location = new System.Drawing.Point(165, 140);
            this.stokKodu.Margin = new System.Windows.Forms.Padding(4);
            this.stokKodu.Name = "stokKodu";
            this.stokKodu.Size = new System.Drawing.Size(180, 25);
            this.stokKodu.TabIndex = 19;
            // 
            // modelKodu
            // 
            this.modelKodu.Location = new System.Drawing.Point(165, 107);
            this.modelKodu.Margin = new System.Windows.Forms.Padding(4);
            this.modelKodu.Name = "modelKodu";
            this.modelKodu.Size = new System.Drawing.Size(180, 25);
            this.modelKodu.TabIndex = 18;
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.Location = new System.Drawing.Point(165, 73);
            this.marka.Margin = new System.Windows.Forms.Padding(4);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(180, 26);
            this.marka.TabIndex = 17;
            this.marka.Text = "marka seç";
            // 
            // kategori
            // 
            this.kategori.FormattingEnabled = true;
            this.kategori.Location = new System.Drawing.Point(165, 39);
            this.kategori.Margin = new System.Windows.Forms.Padding(4);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(180, 26);
            this.kategori.TabIndex = 16;
            this.kategori.Text = "kategori seç";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ürün Özellikleri:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "KDV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alış Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stok Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Model Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategori:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 49);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ürün Ara:";
            // 
            // urunAra
            // 
            this.urunAra.Location = new System.Drawing.Point(151, 45);
            this.urunAra.Margin = new System.Windows.Forms.Padding(4);
            this.urunAra.Name = "urunAra";
            this.urunAra.Size = new System.Drawing.Size(180, 25);
            this.urunAra.TabIndex = 25;
            this.urunAra.Text = "Model Kodu İle";
            this.urunAra.TextChanged += new System.EventHandler(this.urunAra_TextChanged);
            // 
            // UrunBilgileri
            // 
            this.UrunBilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UrunBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrunBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunBilgileri.Location = new System.Drawing.Point(416, 20);
            this.UrunBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.UrunBilgileri.Name = "UrunBilgileri";
            this.UrunBilgileri.Size = new System.Drawing.Size(1351, 647);
            this.UrunBilgileri.TabIndex = 26;
            this.UrunBilgileri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrunBilgileri_CellClick);
            // 
            // UrunGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1780, 691);
            this.Controls.Add(this.UrunBilgileri);
            this.Controls.Add(this.urunAra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunGuncelleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunGuncelleme";
            this.Load += new System.EventHandler(this.UrunGuncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrunBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button urunGuncelle;
        private System.Windows.Forms.RichTextBox urunOzellik;
        private System.Windows.Forms.ComboBox KDV;
        private System.Windows.Forms.TextBox alisFiyati;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.TextBox stokKodu;
        private System.Windows.Forms.TextBox modelKodu;
        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox urunAra;
        private System.Windows.Forms.DataGridView UrunBilgileri;
        private System.Windows.Forms.Button urunSil;
        private System.Windows.Forms.Button button1;
    }
}