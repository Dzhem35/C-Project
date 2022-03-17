
namespace Hastane_Randevu_Otomasyonu_Proje
{
    partial class Vatandaş_Bilgi_Ekranı
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
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.cb_cinsiyet = new System.Windows.Forms.ComboBox();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.dtp_dogum = new System.Windows.Forms.DateTimePicker();
            this.lb_soyadı = new System.Windows.Forms.Label();
            this.lb_adı = new System.Windows.Forms.Label();
            this.lb_cinsiyet = new System.Windows.Forms.Label();
            this.lb_dogumgünü = new System.Windows.Forms.Label();
            this.lb_şifre = new System.Windows.Forms.Label();
            this.lb_soyad = new System.Windows.Forms.Label();
            this.lb_ad = new System.Windows.Forms.Label();
            this.lb_tc = new System.Windows.Forms.Label();
            this.lb_tckimlik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.AutoSize = true;
            this.btn_güncelle.Location = new System.Drawing.Point(297, 277);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(99, 35);
            this.btn_güncelle.TabIndex = 26;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // cb_cinsiyet
            // 
            this.cb_cinsiyet.FormattingEnabled = true;
            this.cb_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cb_cinsiyet.Location = new System.Drawing.Point(196, 218);
            this.cb_cinsiyet.Name = "cb_cinsiyet";
            this.cb_cinsiyet.Size = new System.Drawing.Size(200, 33);
            this.cb_cinsiyet.TabIndex = 25;
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(196, 140);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(200, 30);
            this.tb_sifre.TabIndex = 24;
            this.tb_sifre.UseSystemPasswordChar = true;
            // 
            // dtp_dogum
            // 
            this.dtp_dogum.Location = new System.Drawing.Point(196, 177);
            this.dtp_dogum.Name = "dtp_dogum";
            this.dtp_dogum.Size = new System.Drawing.Size(200, 30);
            this.dtp_dogum.TabIndex = 23;
            // 
            // lb_soyadı
            // 
            this.lb_soyadı.AutoSize = true;
            this.lb_soyadı.Location = new System.Drawing.Point(191, 104);
            this.lb_soyadı.Name = "lb_soyadı";
            this.lb_soyadı.Size = new System.Drawing.Size(0, 25);
            this.lb_soyadı.TabIndex = 22;
            // 
            // lb_adı
            // 
            this.lb_adı.AutoSize = true;
            this.lb_adı.Location = new System.Drawing.Point(191, 65);
            this.lb_adı.Name = "lb_adı";
            this.lb_adı.Size = new System.Drawing.Size(0, 25);
            this.lb_adı.TabIndex = 21;
            // 
            // lb_cinsiyet
            // 
            this.lb_cinsiyet.AutoSize = true;
            this.lb_cinsiyet.Location = new System.Drawing.Point(36, 221);
            this.lb_cinsiyet.Name = "lb_cinsiyet";
            this.lb_cinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lb_cinsiyet.TabIndex = 20;
            this.lb_cinsiyet.Text = "Cinsiyet:";
            // 
            // lb_dogumgünü
            // 
            this.lb_dogumgünü.AutoSize = true;
            this.lb_dogumgünü.Location = new System.Drawing.Point(36, 182);
            this.lb_dogumgünü.Name = "lb_dogumgünü";
            this.lb_dogumgünü.Size = new System.Drawing.Size(135, 25);
            this.lb_dogumgünü.TabIndex = 19;
            this.lb_dogumgünü.Text = "Doğum Tarihi:";
            // 
            // lb_şifre
            // 
            this.lb_şifre.AutoSize = true;
            this.lb_şifre.Location = new System.Drawing.Point(36, 143);
            this.lb_şifre.Name = "lb_şifre";
            this.lb_şifre.Size = new System.Drawing.Size(58, 25);
            this.lb_şifre.TabIndex = 18;
            this.lb_şifre.Text = "Şifre:";
            // 
            // lb_soyad
            // 
            this.lb_soyad.AutoSize = true;
            this.lb_soyad.Location = new System.Drawing.Point(36, 104);
            this.lb_soyad.Name = "lb_soyad";
            this.lb_soyad.Size = new System.Drawing.Size(75, 25);
            this.lb_soyad.TabIndex = 17;
            this.lb_soyad.Text = "Soyad:";
            // 
            // lb_ad
            // 
            this.lb_ad.AutoSize = true;
            this.lb_ad.Location = new System.Drawing.Point(36, 65);
            this.lb_ad.Name = "lb_ad";
            this.lb_ad.Size = new System.Drawing.Size(43, 25);
            this.lb_ad.TabIndex = 16;
            this.lb_ad.Text = "Ad:";
            // 
            // lb_tc
            // 
            this.lb_tc.AutoSize = true;
            this.lb_tc.Location = new System.Drawing.Point(191, 26);
            this.lb_tc.Name = "lb_tc";
            this.lb_tc.Size = new System.Drawing.Size(0, 25);
            this.lb_tc.TabIndex = 15;
            // 
            // lb_tckimlik
            // 
            this.lb_tckimlik.AutoSize = true;
            this.lb_tckimlik.Location = new System.Drawing.Point(36, 26);
            this.lb_tckimlik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tckimlik.Name = "lb_tckimlik";
            this.lb_tckimlik.Size = new System.Drawing.Size(138, 25);
            this.lb_tckimlik.TabIndex = 14;
            this.lb_tckimlik.Text = "T.C Kimlik No:";
            // 
            // Vatandaş_Bilgi_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 330);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.cb_cinsiyet);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.dtp_dogum);
            this.Controls.Add(this.lb_soyadı);
            this.Controls.Add(this.lb_adı);
            this.Controls.Add(this.lb_cinsiyet);
            this.Controls.Add(this.lb_dogumgünü);
            this.Controls.Add(this.lb_şifre);
            this.Controls.Add(this.lb_soyad);
            this.Controls.Add(this.lb_ad);
            this.Controls.Add(this.lb_tc);
            this.Controls.Add(this.lb_tckimlik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vatandaş_Bilgi_Ekranı";
            this.Text = "Vatandaş_Bilgi_Ekranı";
            this.Load += new System.EventHandler(this.Vatandaş_Bilgi_Ekranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_güncelle;
        public System.Windows.Forms.ComboBox cb_cinsiyet;
        public System.Windows.Forms.TextBox tb_sifre;
        public System.Windows.Forms.DateTimePicker dtp_dogum;
        public System.Windows.Forms.Label lb_soyadı;
        public System.Windows.Forms.Label lb_adı;
        private System.Windows.Forms.Label lb_cinsiyet;
        private System.Windows.Forms.Label lb_dogumgünü;
        private System.Windows.Forms.Label lb_şifre;
        private System.Windows.Forms.Label lb_soyad;
        private System.Windows.Forms.Label lb_ad;
        public System.Windows.Forms.Label lb_tc;
        private System.Windows.Forms.Label lb_tckimlik;
    }
}