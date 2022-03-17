
namespace Hastane_Randevu_Otomasyonu_Proje
{
    partial class Admin_Giriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Giriş));
            this.btn_sifreunuttum = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.tb_tckimlik = new System.Windows.Forms.TextBox();
            this.lb_sifre = new System.Windows.Forms.Label();
            this.lb_tckimlik = new System.Windows.Forms.Label();
            this.pb_sağlık = new System.Windows.Forms.PictureBox();
            this.pb_182 = new System.Windows.Forms.PictureBox();
            this.lb_admingiris = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sağlık)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_182)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sifreunuttum
            // 
            this.btn_sifreunuttum.AutoSize = true;
            this.btn_sifreunuttum.Location = new System.Drawing.Point(109, 310);
            this.btn_sifreunuttum.Name = "btn_sifreunuttum";
            this.btn_sifreunuttum.Size = new System.Drawing.Size(160, 35);
            this.btn_sifreunuttum.TabIndex = 38;
            this.btn_sifreunuttum.Text = "Şifremi Unuttum";
            this.btn_sifreunuttum.UseVisualStyleBackColor = true;
            // 
            // btn_giris
            // 
            this.btn_giris.AutoSize = true;
            this.btn_giris.Location = new System.Drawing.Point(354, 310);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 35);
            this.btn_giris.TabIndex = 37;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(279, 232);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(203, 30);
            this.tb_sifre.TabIndex = 36;
            this.tb_sifre.UseSystemPasswordChar = true;
            // 
            // tb_tckimlik
            // 
            this.tb_tckimlik.Location = new System.Drawing.Point(279, 182);
            this.tb_tckimlik.Name = "tb_tckimlik";
            this.tb_tckimlik.Size = new System.Drawing.Size(203, 30);
            this.tb_tckimlik.TabIndex = 35;
            // 
            // lb_sifre
            // 
            this.lb_sifre.AutoSize = true;
            this.lb_sifre.Location = new System.Drawing.Point(36, 232);
            this.lb_sifre.Name = "lb_sifre";
            this.lb_sifre.Size = new System.Drawing.Size(58, 25);
            this.lb_sifre.TabIndex = 34;
            this.lb_sifre.Text = "Şifre:";
            // 
            // lb_tckimlik
            // 
            this.lb_tckimlik.AutoSize = true;
            this.lb_tckimlik.Location = new System.Drawing.Point(36, 180);
            this.lb_tckimlik.Name = "lb_tckimlik";
            this.lb_tckimlik.Size = new System.Drawing.Size(196, 25);
            this.lb_tckimlik.TabIndex = 33;
            this.lb_tckimlik.Text = "T.C Kimlik Numarası:";
            // 
            // pb_sağlık
            // 
            this.pb_sağlık.Image = ((System.Drawing.Image)(resources.GetObject("pb_sağlık.Image")));
            this.pb_sağlık.Location = new System.Drawing.Point(450, 27);
            this.pb_sağlık.Name = "pb_sağlık";
            this.pb_sağlık.Size = new System.Drawing.Size(100, 82);
            this.pb_sağlık.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_sağlık.TabIndex = 32;
            this.pb_sağlık.TabStop = false;
            // 
            // pb_182
            // 
            this.pb_182.Image = ((System.Drawing.Image)(resources.GetObject("pb_182.Image")));
            this.pb_182.Location = new System.Drawing.Point(41, 27);
            this.pb_182.Name = "pb_182";
            this.pb_182.Size = new System.Drawing.Size(100, 82);
            this.pb_182.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_182.TabIndex = 31;
            this.pb_182.TabStop = false;
            // 
            // lb_admingiris
            // 
            this.lb_admingiris.AutoSize = true;
            this.lb_admingiris.Location = new System.Drawing.Point(192, 56);
            this.lb_admingiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_admingiris.Name = "lb_admingiris";
            this.lb_admingiris.Size = new System.Drawing.Size(172, 25);
            this.lb_admingiris.TabIndex = 30;
            this.lb_admingiris.Text = "Admin Giriş Ekranı";
            // 
            // Admin_Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 373);
            this.Controls.Add(this.btn_sifreunuttum);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.tb_tckimlik);
            this.Controls.Add(this.lb_sifre);
            this.Controls.Add(this.lb_tckimlik);
            this.Controls.Add(this.pb_sağlık);
            this.Controls.Add(this.pb_182);
            this.Controls.Add(this.lb_admingiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_Giriş";
            this.Text = "Admin Giriş";
            this.Load += new System.EventHandler(this.Admin_Giriş_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_sağlık)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_182)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sifreunuttum;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.TextBox tb_tckimlik;
        private System.Windows.Forms.Label lb_sifre;
        private System.Windows.Forms.Label lb_tckimlik;
        private System.Windows.Forms.PictureBox pb_sağlık;
        private System.Windows.Forms.PictureBox pb_182;
        private System.Windows.Forms.Label lb_admingiris;
    }
}