namespace Malzeme_Kayit_Otomasyonu
{
    partial class UrunKayit
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
            this.anaSayfa = new System.Windows.Forms.Button();
            this.urunKaydet = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anaSayfa);
            this.groupBox1.Controls.Add(this.urunKaydet);
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
            this.groupBox1.Location = new System.Drawing.Point(258, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(573, 570);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Kayıt";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // anaSayfa
            // 
            this.anaSayfa.Location = new System.Drawing.Point(238, 501);
            this.anaSayfa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.anaSayfa.Name = "anaSayfa";
            this.anaSayfa.Size = new System.Drawing.Size(202, 41);
            this.anaSayfa.TabIndex = 25;
            this.anaSayfa.Text = "ANA SAYFAYA DÖN";
            this.anaSayfa.UseVisualStyleBackColor = true;
            this.anaSayfa.Click += new System.EventHandler(this.anaSayfa_Click);
            // 
            // urunKaydet
            // 
            this.urunKaydet.Location = new System.Drawing.Point(238, 452);
            this.urunKaydet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.urunKaydet.Name = "urunKaydet";
            this.urunKaydet.Size = new System.Drawing.Size(202, 41);
            this.urunKaydet.TabIndex = 24;
            this.urunKaydet.Text = "KAYDET";
            this.urunKaydet.UseVisualStyleBackColor = true;
            this.urunKaydet.Click += new System.EventHandler(this.urunKaydet_Click);
            // 
            // urunOzellik
            // 
            this.urunOzellik.Location = new System.Drawing.Point(238, 301);
            this.urunOzellik.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.urunOzellik.Name = "urunOzellik";
            this.urunOzellik.Size = new System.Drawing.Size(199, 138);
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
            this.KDV.Location = new System.Drawing.Point(238, 262);
            this.KDV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.KDV.Name = "KDV";
            this.KDV.Size = new System.Drawing.Size(199, 27);
            this.KDV.TabIndex = 22;
            // 
            // alisFiyati
            // 
            this.alisFiyati.Location = new System.Drawing.Point(238, 224);
            this.alisFiyati.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.alisFiyati.Name = "alisFiyati";
            this.alisFiyati.Size = new System.Drawing.Size(199, 26);
            this.alisFiyati.TabIndex = 21;
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(238, 186);
            this.adet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(199, 26);
            this.adet.TabIndex = 20;
            // 
            // stokKodu
            // 
            this.stokKodu.Location = new System.Drawing.Point(238, 147);
            this.stokKodu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.stokKodu.Name = "stokKodu";
            this.stokKodu.Size = new System.Drawing.Size(199, 26);
            this.stokKodu.TabIndex = 19;
            // 
            // modelKodu
            // 
            this.modelKodu.Location = new System.Drawing.Point(238, 113);
            this.modelKodu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.modelKodu.Name = "modelKodu";
            this.modelKodu.Size = new System.Drawing.Size(199, 26);
            this.modelKodu.TabIndex = 18;
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.Location = new System.Drawing.Point(238, 78);
            this.marka.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(199, 27);
            this.marka.TabIndex = 17;
            // 
            // kategori
            // 
            this.kategori.FormattingEnabled = true;
            this.kategori.Location = new System.Drawing.Point(238, 43);
            this.kategori.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(199, 27);
            this.kategori.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ürün Özellikleri:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "KDV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alış Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stok Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Model Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategori:";
            // 
            // UrunKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 658);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UrunKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunKayit";
            this.Load += new System.EventHandler(this.UrunKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox alisFiyati;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.TextBox stokKodu;
        private System.Windows.Forms.TextBox modelKodu;
        private System.Windows.Forms.Button urunKaydet;
        private System.Windows.Forms.RichTextBox urunOzellik;
        private System.Windows.Forms.ComboBox KDV;
        private System.Windows.Forms.Button anaSayfa;
    }
}