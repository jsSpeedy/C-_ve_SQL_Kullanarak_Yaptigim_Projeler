namespace Malzeme_Kayit_Otomasyonu
{
    partial class SatisGoruntule
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
            this.satisListesi = new System.Windows.Forms.DataGridView();
            this.anasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.satisListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // satisListesi
            // 
            this.satisListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.satisListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.satisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satisListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.satisListesi.Location = new System.Drawing.Point(0, 0);
            this.satisListesi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.satisListesi.Name = "satisListesi";
            this.satisListesi.Size = new System.Drawing.Size(1802, 698);
            this.satisListesi.TabIndex = 0;
            // 
            // anasayfa
            // 
            this.anasayfa.AutoSize = true;
            this.anasayfa.Location = new System.Drawing.Point(0, 663);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(1802, 36);
            this.anasayfa.TabIndex = 1;
            this.anasayfa.Text = "ANA SAYFAYA DÖN";
            this.anasayfa.UseVisualStyleBackColor = true;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // SatisGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1802, 698);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.satisListesi);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SatisGoruntule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatisGoruntule";
            this.Load += new System.EventHandler(this.SatisGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.satisListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView satisListesi;
        private System.Windows.Forms.Button anasayfa;
    }
}