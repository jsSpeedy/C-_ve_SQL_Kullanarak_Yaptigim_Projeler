namespace Malzeme_Kayit_Otomasyonu
{
    partial class MusteriKayit
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
            this.anasayfa = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.MaskedTextBox();
            this.kaydet = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.anasayfa);
            this.groupBox1.Controls.Add(this.tc);
            this.groupBox1.Controls.Add(this.kaydet);
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
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(313, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(660, 589);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Kayıt Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // anasayfa
            // 
            this.anasayfa.Location = new System.Drawing.Point(182, 522);
            this.anasayfa.Margin = new System.Windows.Forms.Padding(5);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(288, 33);
            this.anasayfa.TabIndex = 16;
            this.anasayfa.Text = "ANA SAYFAYA DÖN";
            this.anasayfa.UseVisualStyleBackColor = true;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // tc
            // 
            this.tc.Location = new System.Drawing.Point(182, 169);
            this.tc.Margin = new System.Windows.Forms.Padding(5);
            this.tc.Mask = "00000000000";
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(286, 26);
            this.tc.TabIndex = 15;
            this.tc.ValidatingType = typeof(int);
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(182, 480);
            this.kaydet.Margin = new System.Windows.Forms.Padding(5);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(288, 33);
            this.kaydet.TabIndex = 14;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(182, 330);
            this.adres.Margin = new System.Windows.Forms.Padding(5);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(286, 139);
            this.adres.TabIndex = 13;
            this.adres.Text = "";
            // 
            // ilce
            // 
            this.ilce.FormattingEnabled = true;
            this.ilce.Location = new System.Drawing.Point(182, 287);
            this.ilce.Margin = new System.Windows.Forms.Padding(5);
            this.ilce.Name = "ilce";
            this.ilce.Size = new System.Drawing.Size(286, 27);
            this.ilce.TabIndex = 12;
            // 
            // il
            // 
            this.il.FormattingEnabled = true;
            this.il.Location = new System.Drawing.Point(182, 247);
            this.il.Margin = new System.Windows.Forms.Padding(5);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(286, 27);
            this.il.TabIndex = 11;
            this.il.SelectedIndexChanged += new System.EventHandler(this.il_SelectedIndexChanged);
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(182, 207);
            this.telefon.Margin = new System.Windows.Forms.Padding(5);
            this.telefon.Mask = "(999) 000-0000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(286, 26);
            this.telefon.TabIndex = 10;
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(182, 131);
            this.Soyad.Margin = new System.Windows.Forms.Padding(5);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(286, 26);
            this.Soyad.TabIndex = 8;
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(182, 98);
            this.Ad.Margin = new System.Windows.Forms.Padding(5);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(286, 26);
            this.Ad.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 290);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "İlçe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "İl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "TCKN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // MusteriKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 658);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MusteriKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müsteri Kayit";
            this.Load += new System.EventHandler(this.MusteriKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ilce;
        private System.Windows.Forms.ComboBox il;
        private System.Windows.Forms.MaskedTextBox telefon;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.RichTextBox adres;
        private System.Windows.Forms.MaskedTextBox tc;
        private System.Windows.Forms.Button anasayfa;
    }
}