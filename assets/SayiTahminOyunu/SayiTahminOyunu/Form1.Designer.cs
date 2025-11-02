namespace SayiTahminOyunu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBaslik = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDogruSayi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AllowDrop = true;
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblBaslik.Location = new System.Drawing.Point(52, 90);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(306, 45);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Sayı Tahmin Oyunu";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Enabled = false;
            this.txtTahmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Location = new System.Drawing.Point(73, 213);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(142, 29);
            this.txtTahmin.TabIndex = 1;
            this.txtTahmin.Text = "Tahmin (4 haneli)";
            this.txtTahmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTahminEt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTahminEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTahminEt.Enabled = false;
            this.btnTahminEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTahminEt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahminEt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTahminEt.Location = new System.Drawing.Point(235, 212);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(98, 29);
            this.btnTahminEt.TabIndex = 2;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = false;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBaslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaslat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaslat.Location = new System.Drawing.Point(73, 138);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(260, 47);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Başlat / Yeniden Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.BackColor = System.Drawing.Color.Honeydew;
            this.lblKalanHak.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanHak.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKalanHak.Location = new System.Drawing.Point(162, 188);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(104, 21);
            this.lblKalanHak.TabIndex = 4;
            this.lblKalanHak.Text = "Kalan Hak: 15";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.BackColor = System.Drawing.Color.Khaki;
            this.lblDurum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDurum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.ForeColor = System.Drawing.Color.Black;
            this.lblDurum.Location = new System.Drawing.Point(73, 244);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(260, 27);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "🎉 Tebrikler! Sayıyı buldunuz!";
            this.lblDurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDurum.Visible = false;
            this.lblDurum.Click += new System.EventHandler(this.lblDurum_Click);
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.Location = new System.Drawing.Point(49, 312);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(309, 121);
            this.lstHistory.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tahminler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDogruSayi
            // 
            this.lblDogruSayi.AutoSize = true;
            this.lblDogruSayi.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblDogruSayi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDogruSayi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogruSayi.ForeColor = System.Drawing.Color.Black;
            this.lblDogruSayi.Location = new System.Drawing.Point(128, 271);
            this.lblDogruSayi.Name = "lblDogruSayi";
            this.lblDogruSayi.Size = new System.Drawing.Size(157, 27);
            this.lblDogruSayi.TabIndex = 6;
            this.lblDogruSayi.Text = "Doğru sayı: XXXX";
            this.lblDogruSayi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDogruSayi.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTahminEt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(406, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.lblDogruSayi);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKalanHak);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblBaslik);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayı Tahmin Oyunu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDogruSayi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

