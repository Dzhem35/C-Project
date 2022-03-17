
namespace Hastane_Randevu_Otomasyonu_Proje
{
    partial class Admin_Panel
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
            this.tb_doktorşifre = new System.Windows.Forms.TextBox();
            this.lb_doktorşifre = new System.Windows.Forms.Label();
            this.tb_doktortckimlik = new System.Windows.Forms.TextBox();
            this.lb_doktortckimlik = new System.Windows.Forms.Label();
            this.btn_vatandaşlistele = new System.Windows.Forms.Button();
            this.btn_vatandaşsil = new System.Windows.Forms.Button();
            this.btn_doktorlistele = new System.Windows.Forms.Button();
            this.btn_kliniklistele = new System.Windows.Forms.Button();
            this.cb_doktorcinsiyet = new System.Windows.Forms.ComboBox();
            this.lbdoktorcinsiyet = new System.Windows.Forms.Label();
            this.btn_doktorsil = new System.Windows.Forms.Button();
            this.btn_kliniksil = new System.Windows.Forms.Button();
            this.tb_klinik = new System.Windows.Forms.TextBox();
            this.tb_doktoradsoyad = new System.Windows.Forms.TextBox();
            this.lb_doktorad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderTCKimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_doktorekle = new System.Windows.Forms.Button();
            this.btn_klinikekle = new System.Windows.Forms.Button();
            this.listBoxDoktorlar = new System.Windows.Forms.ListBox();
            this.listBoxKlinik = new System.Windows.Forms.ListBox();
            this.lb_Doktorlar = new System.Windows.Forms.Label();
            this.lbKlinikler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_doktorşifre
            // 
            this.tb_doktorşifre.Location = new System.Drawing.Point(513, 394);
            this.tb_doktorşifre.Name = "tb_doktorşifre";
            this.tb_doktorşifre.Size = new System.Drawing.Size(178, 30);
            this.tb_doktorşifre.TabIndex = 48;
            this.tb_doktorşifre.UseSystemPasswordChar = true;
            // 
            // lb_doktorşifre
            // 
            this.lb_doktorşifre.AutoSize = true;
            this.lb_doktorşifre.Location = new System.Drawing.Point(313, 394);
            this.lb_doktorşifre.Name = "lb_doktorşifre";
            this.lb_doktorşifre.Size = new System.Drawing.Size(58, 25);
            this.lb_doktorşifre.TabIndex = 47;
            this.lb_doktorşifre.Text = "Şifre:";
            // 
            // tb_doktortckimlik
            // 
            this.tb_doktortckimlik.Location = new System.Drawing.Point(513, 295);
            this.tb_doktortckimlik.Name = "tb_doktortckimlik";
            this.tb_doktortckimlik.Size = new System.Drawing.Size(177, 30);
            this.tb_doktortckimlik.TabIndex = 46;
            // 
            // lb_doktortckimlik
            // 
            this.lb_doktortckimlik.AutoSize = true;
            this.lb_doktortckimlik.Location = new System.Drawing.Point(313, 295);
            this.lb_doktortckimlik.Name = "lb_doktortckimlik";
            this.lb_doktortckimlik.Size = new System.Drawing.Size(138, 25);
            this.lb_doktortckimlik.TabIndex = 45;
            this.lb_doktortckimlik.Text = "T.C Kimlik No:";
            // 
            // btn_vatandaşlistele
            // 
            this.btn_vatandaşlistele.AutoSize = true;
            this.btn_vatandaşlistele.Location = new System.Drawing.Point(696, 396);
            this.btn_vatandaşlistele.Name = "btn_vatandaşlistele";
            this.btn_vatandaşlistele.Size = new System.Drawing.Size(167, 35);
            this.btn_vatandaşlistele.TabIndex = 44;
            this.btn_vatandaşlistele.Text = "Vatandaş Listele";
            this.btn_vatandaşlistele.UseVisualStyleBackColor = true;
            this.btn_vatandaşlistele.Click += new System.EventHandler(this.btn_vatandaşlistele_Click);
            // 
            // btn_vatandaşsil
            // 
            this.btn_vatandaşsil.AutoSize = true;
            this.btn_vatandaşsil.Location = new System.Drawing.Point(1029, 396);
            this.btn_vatandaşsil.Name = "btn_vatandaşsil";
            this.btn_vatandaşsil.Size = new System.Drawing.Size(133, 35);
            this.btn_vatandaşsil.TabIndex = 43;
            this.btn_vatandaşsil.Text = "Vatandaş Sil";
            this.btn_vatandaşsil.UseVisualStyleBackColor = true;
            this.btn_vatandaşsil.Click += new System.EventHandler(this.btn_vatandaşsil_Click);
            // 
            // btn_doktorlistele
            // 
            this.btn_doktorlistele.AutoSize = true;
            this.btn_doktorlistele.Location = new System.Drawing.Point(519, 254);
            this.btn_doktorlistele.Name = "btn_doktorlistele";
            this.btn_doktorlistele.Size = new System.Drawing.Size(78, 35);
            this.btn_doktorlistele.TabIndex = 42;
            this.btn_doktorlistele.Text = "Listele";
            this.btn_doktorlistele.UseVisualStyleBackColor = true;
            this.btn_doktorlistele.Click += new System.EventHandler(this.btn_doktorlistele_Click);
            // 
            // btn_kliniklistele
            // 
            this.btn_kliniklistele.AutoSize = true;
            this.btn_kliniklistele.Location = new System.Drawing.Point(194, 253);
            this.btn_kliniklistele.Name = "btn_kliniklistele";
            this.btn_kliniklistele.Size = new System.Drawing.Size(87, 35);
            this.btn_kliniklistele.TabIndex = 41;
            this.btn_kliniklistele.Text = "Listele";
            this.btn_kliniklistele.UseVisualStyleBackColor = true;
            this.btn_kliniklistele.Click += new System.EventHandler(this.btn_kliniklistele_Click);
            // 
            // cb_doktorcinsiyet
            // 
            this.cb_doktorcinsiyet.FormattingEnabled = true;
            this.cb_doktorcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cb_doktorcinsiyet.Location = new System.Drawing.Point(513, 359);
            this.cb_doktorcinsiyet.Name = "cb_doktorcinsiyet";
            this.cb_doktorcinsiyet.Size = new System.Drawing.Size(178, 33);
            this.cb_doktorcinsiyet.TabIndex = 40;
            // 
            // lbdoktorcinsiyet
            // 
            this.lbdoktorcinsiyet.AutoSize = true;
            this.lbdoktorcinsiyet.Location = new System.Drawing.Point(313, 361);
            this.lbdoktorcinsiyet.Name = "lbdoktorcinsiyet";
            this.lbdoktorcinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lbdoktorcinsiyet.TabIndex = 39;
            this.lbdoktorcinsiyet.Text = "Cinsiyet:";
            // 
            // btn_doktorsil
            // 
            this.btn_doktorsil.AutoSize = true;
            this.btn_doktorsil.Location = new System.Drawing.Point(510, 430);
            this.btn_doktorsil.Name = "btn_doktorsil";
            this.btn_doktorsil.Size = new System.Drawing.Size(87, 35);
            this.btn_doktorsil.TabIndex = 38;
            this.btn_doktorsil.Text = "Sil";
            this.btn_doktorsil.UseVisualStyleBackColor = true;
            this.btn_doktorsil.Click += new System.EventHandler(this.btn_doktorsil_Click);
            // 
            // btn_kliniksil
            // 
            this.btn_kliniksil.AutoSize = true;
            this.btn_kliniksil.Location = new System.Drawing.Point(194, 387);
            this.btn_kliniksil.Name = "btn_kliniksil";
            this.btn_kliniksil.Size = new System.Drawing.Size(87, 35);
            this.btn_kliniksil.TabIndex = 37;
            this.btn_kliniksil.Text = "Sil";
            this.btn_kliniksil.UseVisualStyleBackColor = true;
            this.btn_kliniksil.Click += new System.EventHandler(this.btn_kliniksil_Click);
            // 
            // tb_klinik
            // 
            this.tb_klinik.Location = new System.Drawing.Point(140, 338);
            this.tb_klinik.Name = "tb_klinik";
            this.tb_klinik.Size = new System.Drawing.Size(141, 30);
            this.tb_klinik.TabIndex = 36;
            // 
            // tb_doktoradsoyad
            // 
            this.tb_doktoradsoyad.Location = new System.Drawing.Point(513, 327);
            this.tb_doktoradsoyad.Name = "tb_doktoradsoyad";
            this.tb_doktoradsoyad.Size = new System.Drawing.Size(177, 30);
            this.tb_doktoradsoyad.TabIndex = 35;
            // 
            // lb_doktorad
            // 
            this.lb_doktorad.AutoSize = true;
            this.lb_doktorad.Location = new System.Drawing.Point(313, 328);
            this.lb_doktorad.Name = "lb_doktorad";
            this.lb_doktorad.Size = new System.Drawing.Size(193, 25);
            this.lb_doktorad.TabIndex = 34;
            this.lb_doktorad.Text = "Doktor Ad ve Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Klinik Adı:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTCKimlik,
            this.columnHeaderAd,
            this.columnHeaderSoyad,
            this.columnHeaderCinsiyet});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(696, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(466, 349);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTCKimlik
            // 
            this.columnHeaderTCKimlik.Text = "T.C Kimlik No";
            this.columnHeaderTCKimlik.Width = 117;
            // 
            // columnHeaderAd
            // 
            this.columnHeaderAd.Text = "Ad";
            this.columnHeaderAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderAd.Width = 128;
            // 
            // columnHeaderSoyad
            // 
            this.columnHeaderSoyad.Text = "Soyad";
            this.columnHeaderSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSoyad.Width = 110;
            // 
            // columnHeaderCinsiyet
            // 
            this.columnHeaderCinsiyet.Text = "Cinsiyet";
            this.columnHeaderCinsiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCinsiyet.Width = 106;
            // 
            // btn_doktorekle
            // 
            this.btn_doktorekle.AutoSize = true;
            this.btn_doktorekle.Location = new System.Drawing.Point(334, 430);
            this.btn_doktorekle.Name = "btn_doktorekle";
            this.btn_doktorekle.Size = new System.Drawing.Size(87, 35);
            this.btn_doktorekle.TabIndex = 31;
            this.btn_doktorekle.Text = "Ekle";
            this.btn_doktorekle.UseVisualStyleBackColor = true;
            this.btn_doktorekle.Click += new System.EventHandler(this.btn_doktorekle_Click);
            // 
            // btn_klinikekle
            // 
            this.btn_klinikekle.AutoSize = true;
            this.btn_klinikekle.Location = new System.Drawing.Point(40, 387);
            this.btn_klinikekle.Name = "btn_klinikekle";
            this.btn_klinikekle.Size = new System.Drawing.Size(87, 35);
            this.btn_klinikekle.TabIndex = 30;
            this.btn_klinikekle.Text = "Ekle";
            this.btn_klinikekle.UseVisualStyleBackColor = true;
            this.btn_klinikekle.Click += new System.EventHandler(this.btn_klinikekle_Click);
            // 
            // listBoxDoktorlar
            // 
            this.listBoxDoktorlar.FormattingEnabled = true;
            this.listBoxDoktorlar.ItemHeight = 25;
            this.listBoxDoktorlar.Location = new System.Drawing.Point(334, 67);
            this.listBoxDoktorlar.Name = "listBoxDoktorlar";
            this.listBoxDoktorlar.Size = new System.Drawing.Size(263, 179);
            this.listBoxDoktorlar.TabIndex = 29;
            // 
            // listBoxKlinik
            // 
            this.listBoxKlinik.FormattingEnabled = true;
            this.listBoxKlinik.ItemHeight = 25;
            this.listBoxKlinik.Location = new System.Drawing.Point(40, 67);
            this.listBoxKlinik.Name = "listBoxKlinik";
            this.listBoxKlinik.Size = new System.Drawing.Size(241, 179);
            this.listBoxKlinik.TabIndex = 28;
            // 
            // lb_Doktorlar
            // 
            this.lb_Doktorlar.AutoSize = true;
            this.lb_Doktorlar.Location = new System.Drawing.Point(439, 16);
            this.lb_Doktorlar.Name = "lb_Doktorlar";
            this.lb_Doktorlar.Size = new System.Drawing.Size(90, 25);
            this.lb_Doktorlar.TabIndex = 27;
            this.lb_Doktorlar.Text = "Doktorlar";
            // 
            // lbKlinikler
            // 
            this.lbKlinikler.AutoSize = true;
            this.lbKlinikler.Location = new System.Drawing.Point(116, 16);
            this.lbKlinikler.Name = "lbKlinikler";
            this.lbKlinikler.Size = new System.Drawing.Size(80, 25);
            this.lbKlinikler.TabIndex = 26;
            this.lbKlinikler.Text = "Klinikler";
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 480);
            this.Controls.Add(this.tb_doktorşifre);
            this.Controls.Add(this.lb_doktorşifre);
            this.Controls.Add(this.tb_doktortckimlik);
            this.Controls.Add(this.lb_doktortckimlik);
            this.Controls.Add(this.btn_vatandaşlistele);
            this.Controls.Add(this.btn_vatandaşsil);
            this.Controls.Add(this.btn_doktorlistele);
            this.Controls.Add(this.btn_kliniklistele);
            this.Controls.Add(this.cb_doktorcinsiyet);
            this.Controls.Add(this.lbdoktorcinsiyet);
            this.Controls.Add(this.btn_doktorsil);
            this.Controls.Add(this.btn_kliniksil);
            this.Controls.Add(this.tb_klinik);
            this.Controls.Add(this.tb_doktoradsoyad);
            this.Controls.Add(this.lb_doktorad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_doktorekle);
            this.Controls.Add(this.btn_klinikekle);
            this.Controls.Add(this.listBoxDoktorlar);
            this.Controls.Add(this.listBoxKlinik);
            this.Controls.Add(this.lb_Doktorlar);
            this.Controls.Add(this.lbKlinikler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin_Panel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_doktorşifre;
        private System.Windows.Forms.Label lb_doktorşifre;
        private System.Windows.Forms.TextBox tb_doktortckimlik;
        private System.Windows.Forms.Label lb_doktortckimlik;
        private System.Windows.Forms.Button btn_vatandaşlistele;
        private System.Windows.Forms.Button btn_vatandaşsil;
        private System.Windows.Forms.Button btn_doktorlistele;
        private System.Windows.Forms.Button btn_kliniklistele;
        private System.Windows.Forms.ComboBox cb_doktorcinsiyet;
        private System.Windows.Forms.Label lbdoktorcinsiyet;
        private System.Windows.Forms.Button btn_doktorsil;
        private System.Windows.Forms.Button btn_kliniksil;
        private System.Windows.Forms.TextBox tb_klinik;
        private System.Windows.Forms.TextBox tb_doktoradsoyad;
        private System.Windows.Forms.Label lb_doktorad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderTCKimlik;
        private System.Windows.Forms.ColumnHeader columnHeaderAd;
        private System.Windows.Forms.ColumnHeader columnHeaderSoyad;
        private System.Windows.Forms.ColumnHeader columnHeaderCinsiyet;
        private System.Windows.Forms.Button btn_doktorekle;
        private System.Windows.Forms.Button btn_klinikekle;
        private System.Windows.Forms.ListBox listBoxDoktorlar;
        private System.Windows.Forms.ListBox listBoxKlinik;
        private System.Windows.Forms.Label lb_Doktorlar;
        private System.Windows.Forms.Label lbKlinikler;
    }
}