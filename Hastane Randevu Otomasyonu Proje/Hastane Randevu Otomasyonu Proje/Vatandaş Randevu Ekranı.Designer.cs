
namespace Hastane_Randevu_Otomasyonu_Proje
{
    partial class Vatandaş_Randevu_Ekranı
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
            this.btn_randevual = new System.Windows.Forms.Button();
            this.cb_saat = new System.Windows.Forms.ComboBox();
            this.lb_saat = new System.Windows.Forms.Label();
            this.btn_randevuara = new System.Windows.Forms.Button();
            this.pnl_bilgi = new System.Windows.Forms.Panel();
            this.btn_randevu = new System.Windows.Forms.Button();
            this.btn_hesap = new System.Windows.Forms.Button();
            this.dtp_randevu = new System.Windows.Forms.DateTimePicker();
            this.cb_doktor = new System.Windows.Forms.ComboBox();
            this.cb_klinik = new System.Windows.Forms.ComboBox();
            this.lb_tarih = new System.Windows.Forms.Label();
            this.lb_doktor = new System.Windows.Forms.Label();
            this.lb_klinik = new System.Windows.Forms.Label();
            this.lb_vatandaşbilgi = new System.Windows.Forms.Label();
            this.pnl_vatandaş = new System.Windows.Forms.Panel();
            this.lb_cinsiyeti = new System.Windows.Forms.Label();
            this.lb_dogumtarihi = new System.Windows.Forms.Label();
            this.lb_soyadı = new System.Windows.Forms.Label();
            this.lb_adı = new System.Windows.Forms.Label();
            this.lb_tc = new System.Windows.Forms.Label();
            this.lb_cinsiyet = new System.Windows.Forms.Label();
            this.lb_dogumgünü = new System.Windows.Forms.Label();
            this.lb_soyad = new System.Windows.Forms.Label();
            this.lb_ad = new System.Windows.Forms.Label();
            this.lb_tckimlik = new System.Windows.Forms.Label();
            this.pnl_bilgi.SuspendLayout();
            this.pnl_vatandaş.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_randevual
            // 
            this.btn_randevual.AutoSize = true;
            this.btn_randevual.Location = new System.Drawing.Point(853, 422);
            this.btn_randevual.Name = "btn_randevual";
            this.btn_randevual.Size = new System.Drawing.Size(123, 35);
            this.btn_randevual.TabIndex = 41;
            this.btn_randevual.Text = "Randevu Al";
            this.btn_randevual.UseVisualStyleBackColor = true;
            this.btn_randevual.Visible = false;
            this.btn_randevual.Click += new System.EventHandler(this.btn_randevual_Click);
            // 
            // cb_saat
            // 
            this.cb_saat.FormattingEnabled = true;
            this.cb_saat.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00"});
            this.cb_saat.Location = new System.Drawing.Point(776, 316);
            this.cb_saat.Name = "cb_saat";
            this.cb_saat.Size = new System.Drawing.Size(200, 33);
            this.cb_saat.TabIndex = 40;
            this.cb_saat.Visible = false;
            // 
            // lb_saat
            // 
            this.lb_saat.AutoSize = true;
            this.lb_saat.Location = new System.Drawing.Point(613, 316);
            this.lb_saat.Name = "lb_saat";
            this.lb_saat.Size = new System.Drawing.Size(146, 25);
            this.lb_saat.TabIndex = 39;
            this.lb_saat.Text = "Randevu Saati:";
            this.lb_saat.Visible = false;
            // 
            // btn_randevuara
            // 
            this.btn_randevuara.AutoSize = true;
            this.btn_randevuara.Location = new System.Drawing.Point(840, 248);
            this.btn_randevuara.Name = "btn_randevuara";
            this.btn_randevuara.Size = new System.Drawing.Size(136, 35);
            this.btn_randevuara.TabIndex = 38;
            this.btn_randevuara.Text = "Randevu Ara";
            this.btn_randevuara.UseVisualStyleBackColor = true;
            this.btn_randevuara.Click += new System.EventHandler(this.btn_randevuara_Click);
            // 
            // pnl_bilgi
            // 
            this.pnl_bilgi.Controls.Add(this.btn_randevu);
            this.pnl_bilgi.Controls.Add(this.btn_hesap);
            this.pnl_bilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_bilgi.Location = new System.Drawing.Point(0, 0);
            this.pnl_bilgi.Name = "pnl_bilgi";
            this.pnl_bilgi.Size = new System.Drawing.Size(1155, 50);
            this.pnl_bilgi.TabIndex = 37;
            // 
            // btn_randevu
            // 
            this.btn_randevu.AutoSize = true;
            this.btn_randevu.Location = new System.Drawing.Point(1002, 12);
            this.btn_randevu.Name = "btn_randevu";
            this.btn_randevu.Size = new System.Drawing.Size(141, 35);
            this.btn_randevu.TabIndex = 2;
            this.btn_randevu.Text = "Randevularım";
            this.btn_randevu.UseVisualStyleBackColor = true;
            this.btn_randevu.Click += new System.EventHandler(this.btn_randevu_Click);
            // 
            // btn_hesap
            // 
            this.btn_hesap.AutoSize = true;
            this.btn_hesap.Location = new System.Drawing.Point(12, 12);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(161, 35);
            this.btn_hesap.TabIndex = 0;
            this.btn_hesap.Text = "Hesap Bilgilerim";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // dtp_randevu
            // 
            this.dtp_randevu.Location = new System.Drawing.Point(776, 201);
            this.dtp_randevu.Name = "dtp_randevu";
            this.dtp_randevu.Size = new System.Drawing.Size(200, 30);
            this.dtp_randevu.TabIndex = 36;
            // 
            // cb_doktor
            // 
            this.cb_doktor.FormattingEnabled = true;
            this.cb_doktor.Location = new System.Drawing.Point(776, 139);
            this.cb_doktor.Name = "cb_doktor";
            this.cb_doktor.Size = new System.Drawing.Size(200, 33);
            this.cb_doktor.TabIndex = 35;
            // 
            // cb_klinik
            // 
            this.cb_klinik.FormattingEnabled = true;
            this.cb_klinik.Location = new System.Drawing.Point(776, 77);
            this.cb_klinik.Name = "cb_klinik";
            this.cb_klinik.Size = new System.Drawing.Size(200, 33);
            this.cb_klinik.TabIndex = 34;
            this.cb_klinik.SelectedIndexChanged += new System.EventHandler(this.cb_klinik_SelectedIndexChanged);
            // 
            // lb_tarih
            // 
            this.lb_tarih.AutoSize = true;
            this.lb_tarih.Location = new System.Drawing.Point(609, 207);
            this.lb_tarih.Name = "lb_tarih";
            this.lb_tarih.Size = new System.Drawing.Size(150, 25);
            this.lb_tarih.TabIndex = 33;
            this.lb_tarih.Text = "Randevu Tarihi:";
            // 
            // lb_doktor
            // 
            this.lb_doktor.AutoSize = true;
            this.lb_doktor.Location = new System.Drawing.Point(609, 146);
            this.lb_doktor.Name = "lb_doktor";
            this.lb_doktor.Size = new System.Drawing.Size(75, 25);
            this.lb_doktor.TabIndex = 32;
            this.lb_doktor.Text = "Doktor:";
            // 
            // lb_klinik
            // 
            this.lb_klinik.AutoSize = true;
            this.lb_klinik.Location = new System.Drawing.Point(609, 85);
            this.lb_klinik.Name = "lb_klinik";
            this.lb_klinik.Size = new System.Drawing.Size(65, 25);
            this.lb_klinik.TabIndex = 31;
            this.lb_klinik.Text = "Klinik:";
            // 
            // lb_vatandaşbilgi
            // 
            this.lb_vatandaşbilgi.AutoSize = true;
            this.lb_vatandaşbilgi.Location = new System.Drawing.Point(36, 82);
            this.lb_vatandaşbilgi.Name = "lb_vatandaşbilgi";
            this.lb_vatandaşbilgi.Size = new System.Drawing.Size(168, 25);
            this.lb_vatandaşbilgi.TabIndex = 30;
            this.lb_vatandaşbilgi.Text = "Vatandaş Bilgileri:";
            // 
            // pnl_vatandaş
            // 
            this.pnl_vatandaş.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_vatandaş.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_vatandaş.Controls.Add(this.lb_cinsiyeti);
            this.pnl_vatandaş.Controls.Add(this.lb_dogumtarihi);
            this.pnl_vatandaş.Controls.Add(this.lb_soyadı);
            this.pnl_vatandaş.Controls.Add(this.lb_adı);
            this.pnl_vatandaş.Controls.Add(this.lb_tc);
            this.pnl_vatandaş.Controls.Add(this.lb_cinsiyet);
            this.pnl_vatandaş.Controls.Add(this.lb_dogumgünü);
            this.pnl_vatandaş.Controls.Add(this.lb_soyad);
            this.pnl_vatandaş.Controls.Add(this.lb_ad);
            this.pnl_vatandaş.Controls.Add(this.lb_tckimlik);
            this.pnl_vatandaş.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_vatandaş.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_vatandaş.Location = new System.Drawing.Point(36, 124);
            this.pnl_vatandaş.Name = "pnl_vatandaş";
            this.pnl_vatandaş.Size = new System.Drawing.Size(451, 240);
            this.pnl_vatandaş.TabIndex = 29;
            // 
            // lb_cinsiyeti
            // 
            this.lb_cinsiyeti.AutoSize = true;
            this.lb_cinsiyeti.Location = new System.Drawing.Point(245, 169);
            this.lb_cinsiyeti.Name = "lb_cinsiyeti";
            this.lb_cinsiyeti.Size = new System.Drawing.Size(0, 25);
            this.lb_cinsiyeti.TabIndex = 9;
            // 
            // lb_dogumtarihi
            // 
            this.lb_dogumtarihi.AutoSize = true;
            this.lb_dogumtarihi.Location = new System.Drawing.Point(245, 132);
            this.lb_dogumtarihi.Name = "lb_dogumtarihi";
            this.lb_dogumtarihi.Size = new System.Drawing.Size(0, 25);
            this.lb_dogumtarihi.TabIndex = 8;
            // 
            // lb_soyadı
            // 
            this.lb_soyadı.AutoSize = true;
            this.lb_soyadı.Location = new System.Drawing.Point(245, 95);
            this.lb_soyadı.Name = "lb_soyadı";
            this.lb_soyadı.Size = new System.Drawing.Size(0, 25);
            this.lb_soyadı.TabIndex = 7;
            // 
            // lb_adı
            // 
            this.lb_adı.AutoSize = true;
            this.lb_adı.Location = new System.Drawing.Point(245, 58);
            this.lb_adı.Name = "lb_adı";
            this.lb_adı.Size = new System.Drawing.Size(0, 25);
            this.lb_adı.TabIndex = 6;
            // 
            // lb_tc
            // 
            this.lb_tc.AutoSize = true;
            this.lb_tc.Location = new System.Drawing.Point(245, 21);
            this.lb_tc.Name = "lb_tc";
            this.lb_tc.Size = new System.Drawing.Size(0, 25);
            this.lb_tc.TabIndex = 5;
            // 
            // lb_cinsiyet
            // 
            this.lb_cinsiyet.AutoSize = true;
            this.lb_cinsiyet.Location = new System.Drawing.Point(18, 169);
            this.lb_cinsiyet.Name = "lb_cinsiyet";
            this.lb_cinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lb_cinsiyet.TabIndex = 4;
            this.lb_cinsiyet.Text = "Cinsiyet:";
            // 
            // lb_dogumgünü
            // 
            this.lb_dogumgünü.AutoSize = true;
            this.lb_dogumgünü.Location = new System.Drawing.Point(18, 132);
            this.lb_dogumgünü.Name = "lb_dogumgünü";
            this.lb_dogumgünü.Size = new System.Drawing.Size(135, 25);
            this.lb_dogumgünü.TabIndex = 3;
            this.lb_dogumgünü.Text = "Doğum Tarihi:";
            // 
            // lb_soyad
            // 
            this.lb_soyad.AutoSize = true;
            this.lb_soyad.Location = new System.Drawing.Point(18, 95);
            this.lb_soyad.Name = "lb_soyad";
            this.lb_soyad.Size = new System.Drawing.Size(75, 25);
            this.lb_soyad.TabIndex = 2;
            this.lb_soyad.Text = "Soyad:";
            // 
            // lb_ad
            // 
            this.lb_ad.AutoSize = true;
            this.lb_ad.Location = new System.Drawing.Point(18, 58);
            this.lb_ad.Name = "lb_ad";
            this.lb_ad.Size = new System.Drawing.Size(43, 25);
            this.lb_ad.TabIndex = 1;
            this.lb_ad.Text = "Ad:";
            // 
            // lb_tckimlik
            // 
            this.lb_tckimlik.AutoSize = true;
            this.lb_tckimlik.Location = new System.Drawing.Point(18, 21);
            this.lb_tckimlik.Name = "lb_tckimlik";
            this.lb_tckimlik.Size = new System.Drawing.Size(196, 25);
            this.lb_tckimlik.TabIndex = 0;
            this.lb_tckimlik.Text = "T.C Kimlik Numarası:";
            // 
            // Vatandaş_Randevu_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 463);
            this.Controls.Add(this.btn_randevual);
            this.Controls.Add(this.cb_saat);
            this.Controls.Add(this.lb_saat);
            this.Controls.Add(this.btn_randevuara);
            this.Controls.Add(this.pnl_bilgi);
            this.Controls.Add(this.dtp_randevu);
            this.Controls.Add(this.cb_doktor);
            this.Controls.Add(this.cb_klinik);
            this.Controls.Add(this.lb_tarih);
            this.Controls.Add(this.lb_doktor);
            this.Controls.Add(this.lb_klinik);
            this.Controls.Add(this.lb_vatandaşbilgi);
            this.Controls.Add(this.pnl_vatandaş);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vatandaş_Randevu_Ekranı";
            this.Text = "Vatandaş Randevu Ekranı";
            this.Load += new System.EventHandler(this.Vatandaş_Randevu_Ekranı_Load);
            this.pnl_bilgi.ResumeLayout(false);
            this.pnl_bilgi.PerformLayout();
            this.pnl_vatandaş.ResumeLayout(false);
            this.pnl_vatandaş.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_randevual;
        private System.Windows.Forms.ComboBox cb_saat;
        private System.Windows.Forms.Label lb_saat;
        private System.Windows.Forms.Button btn_randevuara;
        private System.Windows.Forms.Panel pnl_bilgi;
        private System.Windows.Forms.Button btn_randevu;
        private System.Windows.Forms.Button btn_hesap;
        private System.Windows.Forms.DateTimePicker dtp_randevu;
        private System.Windows.Forms.ComboBox cb_doktor;
        private System.Windows.Forms.ComboBox cb_klinik;
        private System.Windows.Forms.Label lb_tarih;
        private System.Windows.Forms.Label lb_doktor;
        private System.Windows.Forms.Label lb_klinik;
        private System.Windows.Forms.Label lb_vatandaşbilgi;
        private System.Windows.Forms.Panel pnl_vatandaş;
        public System.Windows.Forms.Label lb_cinsiyeti;
        public System.Windows.Forms.Label lb_dogumtarihi;
        public System.Windows.Forms.Label lb_soyadı;
        public System.Windows.Forms.Label lb_adı;
        public System.Windows.Forms.Label lb_tc;
        private System.Windows.Forms.Label lb_cinsiyet;
        private System.Windows.Forms.Label lb_dogumgünü;
        private System.Windows.Forms.Label lb_soyad;
        private System.Windows.Forms.Label lb_ad;
        private System.Windows.Forms.Label lb_tckimlik;
    }
}