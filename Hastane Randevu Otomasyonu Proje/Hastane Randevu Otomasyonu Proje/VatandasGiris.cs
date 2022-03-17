
using System;

namespace Hastane_Randevu_Otomasyonu_Proje
{
    partial class VatandasGiris
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

        internal void Show()
        {
            throw new NotImplementedException();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VatandasGiris));
            this.btn_sifreunuttum = new System.Windows.Forms.Button();
            this.btn_yeniuye = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.tb_tckimlik = new System.Windows.Forms.TextBox();
            this.lb_sifre = new System.Windows.Forms.Label();
            this.lb_tckimlik = new System.Windows.Forms.Label();
            this.pb_sağlık = new System.Windows.Forms.PictureBox();
            this.pb_182 = new System.Windows.Forms.PictureBox();
            this.lb_vatandasgiris = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sağlık)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_182)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sifreunuttum
            // 
            this.btn_sifreunuttum.AutoSize = true;
            this.btn_sifreunuttum.Location = new System.Drawing.Point(50, 288);
            this.btn_sifreunuttum.Name = "btn_sifreunuttum";
            this.btn_sifreunuttum.Size = new System.Drawing.Size(160, 35);
            this.btn_sifreunuttum.TabIndex = 19;
            this.btn_sifreunuttum.Text = "Şifremi Unuttum";
            this.btn_sifreunuttum.UseVisualStyleBackColor = true;
            this.btn_sifreunuttum.Click += new System.EventHandler(this.btn_sifreunuttum_Click);
            // 
            // btn_yeniuye
            // 
            this.btn_yeniuye.AutoSize = true;
            this.btn_yeniuye.Location = new System.Drawing.Point(289, 288);
            this.btn_yeniuye.Name = "btn_yeniuye";
            this.btn_yeniuye.Size = new System.Drawing.Size(101, 35);
            this.btn_yeniuye.TabIndex = 18;
            this.btn_yeniuye.Text = "Yeni Üye";
            this.btn_yeniuye.UseVisualStyleBackColor = true;
            this.btn_yeniuye.Click += new System.EventHandler(this.btn_yeniuye_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.AutoSize = true;
            this.btn_giris.Location = new System.Drawing.Point(469, 288);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 35);
            this.btn_giris.TabIndex = 17;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(292, 220);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(203, 30);
            this.tb_sifre.TabIndex = 16;
            this.tb_sifre.UseSystemPasswordChar = true;
            // 
            // tb_tckimlik
            // 
            this.tb_tckimlik.Location = new System.Drawing.Point(292, 170);
            this.tb_tckimlik.Name = "tb_tckimlik";
            this.tb_tckimlik.Size = new System.Drawing.Size(203, 30);
            this.tb_tckimlik.TabIndex = 15;
            // 
            // lb_sifre
            // 
            this.lb_sifre.AutoSize = true;
            this.lb_sifre.Location = new System.Drawing.Point(49, 220);
            this.lb_sifre.Name = "lb_sifre";
            this.lb_sifre.Size = new System.Drawing.Size(58, 25);
            this.lb_sifre.TabIndex = 14;
            this.lb_sifre.Text = "Şifre:";
            // 
            // lb_tckimlik
            // 
            this.lb_tckimlik.AutoSize = true;
            this.lb_tckimlik.Location = new System.Drawing.Point(49, 168);
            this.lb_tckimlik.Name = "lb_tckimlik";
            this.lb_tckimlik.Size = new System.Drawing.Size(196, 25);
            this.lb_tckimlik.TabIndex = 13;
            this.lb_tckimlik.Text = "T.C Kimlik Numarası:";
            // 
            // pb_sağlık
            // 
            this.pb_sağlık.Image = ((System.Drawing.Image)(resources.GetObject("pb_sağlık.Image")));
            this.pb_sağlık.Location = new System.Drawing.Point(444, 24);
            this.pb_sağlık.Name = "pb_sağlık";
            this.pb_sağlık.Size = new System.Drawing.Size(100, 82);
            this.pb_sağlık.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_sağlık.TabIndex = 12;
            this.pb_sağlık.TabStop = false;
            // 
            // pb_182
            // 
            this.pb_182.Image = ((System.Drawing.Image)(resources.GetObject("pb_182.Image")));
            this.pb_182.Location = new System.Drawing.Point(35, 24);
            this.pb_182.Name = "pb_182";
            this.pb_182.Size = new System.Drawing.Size(100, 82);
            this.pb_182.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_182.TabIndex = 11;
            this.pb_182.TabStop = false;
            // 
            // lb_vatandasgiris
            // 
            this.lb_vatandasgiris.AutoSize = true;
            this.lb_vatandasgiris.Location = new System.Drawing.Point(186, 53);
            this.lb_vatandasgiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_vatandasgiris.Name = "lb_vatandasgiris";
            this.lb_vatandasgiris.Size = new System.Drawing.Size(200, 25);
            this.lb_vatandasgiris.TabIndex = 10;
            this.lb_vatandasgiris.Text = "Vatandaş Giriş Ekranı";
            // 
            // Vatandaş_Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 349);
            this.Controls.Add(this.btn_sifreunuttum);
            this.Controls.Add(this.btn_yeniuye);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.tb_tckimlik);
            this.Controls.Add(this.lb_sifre);
            this.Controls.Add(this.lb_tckimlik);
            this.Controls.Add(this.pb_sağlık);
            this.Controls.Add(this.pb_182);
            this.Controls.Add(this.lb_vatandasgiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vatandaş_Giriş";
            this.Text = "Vatandaş Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pb_sağlık)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_182)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sifreunuttum;
        private System.Windows.Forms.Button btn_yeniuye;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox tb_sifre;
        public System.Windows.Forms.TextBox tb_tckimlik;
        private System.Windows.Forms.Label lb_sifre;
        private System.Windows.Forms.Label lb_tckimlik;
        private System.Windows.Forms.PictureBox pb_sağlık;
        private System.Windows.Forms.PictureBox pb_182;
        private System.Windows.Forms.Label lb_vatandasgiris;
    }
}