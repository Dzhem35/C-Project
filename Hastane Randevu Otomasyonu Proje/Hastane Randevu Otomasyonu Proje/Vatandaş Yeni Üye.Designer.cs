
namespace Hastane_Randevu_Otomasyonu_Proje
{
    partial class Vatandaş_Yeni_Üye
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
            this.cb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.dtp_doğumtarihi = new System.Windows.Forms.DateTimePicker();
            this.btn_kayıtol = new System.Windows.Forms.Button();
            this.tb_şifretekrar = new System.Windows.Forms.TextBox();
            this.tb_şifre = new System.Windows.Forms.TextBox();
            this.tb_soyad = new System.Windows.Forms.TextBox();
            this.tb_ad = new System.Windows.Forms.TextBox();
            this.tb_tckimlik = new System.Windows.Forms.TextBox();
            this.lb_şifretekrar = new System.Windows.Forms.Label();
            this.lb_şifre = new System.Windows.Forms.Label();
            this.lb_cinsiyet = new System.Windows.Forms.Label();
            this.lb_doğumtarihi = new System.Windows.Forms.Label();
            this.lb_soyad = new System.Windows.Forms.Label();
            this.lb_ad = new System.Windows.Forms.Label();
            this.lb_tckimlik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_cinsiyet
            // 
            this.cb_cinsiyet.FormattingEnabled = true;
            this.cb_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cb_cinsiyet.Location = new System.Drawing.Point(238, 180);
            this.cb_cinsiyet.Name = "cb_cinsiyet";
            this.cb_cinsiyet.Size = new System.Drawing.Size(280, 33);
            this.cb_cinsiyet.TabIndex = 32;
            // 
            // dtp_doğumtarihi
            // 
            this.dtp_doğumtarihi.Location = new System.Drawing.Point(238, 138);
            this.dtp_doğumtarihi.Name = "dtp_doğumtarihi";
            this.dtp_doğumtarihi.Size = new System.Drawing.Size(280, 30);
            this.dtp_doğumtarihi.TabIndex = 31;
            // 
            // btn_kayıtol
            // 
            this.btn_kayıtol.AutoSize = true;
            this.btn_kayıtol.Location = new System.Drawing.Point(460, 325);
            this.btn_kayıtol.Name = "btn_kayıtol";
            this.btn_kayıtol.Size = new System.Drawing.Size(91, 35);
            this.btn_kayıtol.TabIndex = 30;
            this.btn_kayıtol.Text = "Kayıt Ol";
            this.btn_kayıtol.UseVisualStyleBackColor = true;
            this.btn_kayıtol.Click += new System.EventHandler(this.btn_kayıtol_Click);
            // 
            // tb_şifretekrar
            // 
            this.tb_şifretekrar.Location = new System.Drawing.Point(238, 264);
            this.tb_şifretekrar.Name = "tb_şifretekrar";
            this.tb_şifretekrar.Size = new System.Drawing.Size(280, 30);
            this.tb_şifretekrar.TabIndex = 29;
            this.tb_şifretekrar.UseSystemPasswordChar = true;
            // 
            // tb_şifre
            // 
            this.tb_şifre.Location = new System.Drawing.Point(238, 222);
            this.tb_şifre.Name = "tb_şifre";
            this.tb_şifre.Size = new System.Drawing.Size(280, 30);
            this.tb_şifre.TabIndex = 28;
            this.tb_şifre.UseSystemPasswordChar = true;
            // 
            // tb_soyad
            // 
            this.tb_soyad.Location = new System.Drawing.Point(238, 96);
            this.tb_soyad.Name = "tb_soyad";
            this.tb_soyad.Size = new System.Drawing.Size(280, 30);
            this.tb_soyad.TabIndex = 27;
            // 
            // tb_ad
            // 
            this.tb_ad.Location = new System.Drawing.Point(238, 54);
            this.tb_ad.Name = "tb_ad";
            this.tb_ad.Size = new System.Drawing.Size(280, 30);
            this.tb_ad.TabIndex = 26;
            // 
            // tb_tckimlik
            // 
            this.tb_tckimlik.Location = new System.Drawing.Point(238, 12);
            this.tb_tckimlik.Name = "tb_tckimlik";
            this.tb_tckimlik.Size = new System.Drawing.Size(280, 30);
            this.tb_tckimlik.TabIndex = 25;
            // 
            // lb_şifretekrar
            // 
            this.lb_şifretekrar.AutoSize = true;
            this.lb_şifretekrar.Location = new System.Drawing.Point(36, 264);
            this.lb_şifretekrar.Name = "lb_şifretekrar";
            this.lb_şifretekrar.Size = new System.Drawing.Size(120, 25);
            this.lb_şifretekrar.TabIndex = 24;
            this.lb_şifretekrar.Text = "Şifre Tekrar:";
            // 
            // lb_şifre
            // 
            this.lb_şifre.AutoSize = true;
            this.lb_şifre.Location = new System.Drawing.Point(36, 222);
            this.lb_şifre.Name = "lb_şifre";
            this.lb_şifre.Size = new System.Drawing.Size(58, 25);
            this.lb_şifre.TabIndex = 23;
            this.lb_şifre.Text = "Şifre:";
            // 
            // lb_cinsiyet
            // 
            this.lb_cinsiyet.AutoSize = true;
            this.lb_cinsiyet.Location = new System.Drawing.Point(36, 180);
            this.lb_cinsiyet.Name = "lb_cinsiyet";
            this.lb_cinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lb_cinsiyet.TabIndex = 22;
            this.lb_cinsiyet.Text = "Cinsiyet:";
            // 
            // lb_doğumtarihi
            // 
            this.lb_doğumtarihi.AutoSize = true;
            this.lb_doğumtarihi.Location = new System.Drawing.Point(36, 138);
            this.lb_doğumtarihi.Name = "lb_doğumtarihi";
            this.lb_doğumtarihi.Size = new System.Drawing.Size(135, 25);
            this.lb_doğumtarihi.TabIndex = 21;
            this.lb_doğumtarihi.Text = "Doğum Tarihi:";
            // 
            // lb_soyad
            // 
            this.lb_soyad.AutoSize = true;
            this.lb_soyad.Location = new System.Drawing.Point(36, 96);
            this.lb_soyad.Name = "lb_soyad";
            this.lb_soyad.Size = new System.Drawing.Size(79, 25);
            this.lb_soyad.TabIndex = 20;
            this.lb_soyad.Text = "Soyadı:";
            // 
            // lb_ad
            // 
            this.lb_ad.AutoSize = true;
            this.lb_ad.Location = new System.Drawing.Point(36, 54);
            this.lb_ad.Name = "lb_ad";
            this.lb_ad.Size = new System.Drawing.Size(47, 25);
            this.lb_ad.TabIndex = 19;
            this.lb_ad.Text = "Adı:";
            // 
            // lb_tckimlik
            // 
            this.lb_tckimlik.AutoSize = true;
            this.lb_tckimlik.Location = new System.Drawing.Point(36, 12);
            this.lb_tckimlik.Name = "lb_tckimlik";
            this.lb_tckimlik.Size = new System.Drawing.Size(196, 25);
            this.lb_tckimlik.TabIndex = 18;
            this.lb_tckimlik.Text = "T.C Kimlik Numarası:";
            // 
            // Vatandaş_Yeni_Üye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 373);
            this.Controls.Add(this.cb_cinsiyet);
            this.Controls.Add(this.dtp_doğumtarihi);
            this.Controls.Add(this.btn_kayıtol);
            this.Controls.Add(this.tb_şifretekrar);
            this.Controls.Add(this.tb_şifre);
            this.Controls.Add(this.tb_soyad);
            this.Controls.Add(this.tb_ad);
            this.Controls.Add(this.tb_tckimlik);
            this.Controls.Add(this.lb_şifretekrar);
            this.Controls.Add(this.lb_şifre);
            this.Controls.Add(this.lb_cinsiyet);
            this.Controls.Add(this.lb_doğumtarihi);
            this.Controls.Add(this.lb_soyad);
            this.Controls.Add(this.lb_ad);
            this.Controls.Add(this.lb_tckimlik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vatandaş_Yeni_Üye";
            this.Text = "Vatandaş Yeni Üye";
            this.Load += new System.EventHandler(this.Vatandaş_Yeni_Üye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_cinsiyet;
        private System.Windows.Forms.DateTimePicker dtp_doğumtarihi;
        private System.Windows.Forms.Button btn_kayıtol;
        private System.Windows.Forms.TextBox tb_şifretekrar;
        private System.Windows.Forms.TextBox tb_şifre;
        private System.Windows.Forms.TextBox tb_soyad;
        private System.Windows.Forms.TextBox tb_ad;
        private System.Windows.Forms.TextBox tb_tckimlik;
        private System.Windows.Forms.Label lb_şifretekrar;
        private System.Windows.Forms.Label lb_şifre;
        private System.Windows.Forms.Label lb_cinsiyet;
        private System.Windows.Forms.Label lb_doğumtarihi;
        private System.Windows.Forms.Label lb_soyad;
        private System.Windows.Forms.Label lb_ad;
        private System.Windows.Forms.Label lb_tckimlik;
    }
}