
namespace Hastane_Randevu_Otomasyonu_Proje
{
    partial class Vatandaş_Randevularım_Ekranı
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
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.lb_tc = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderRandevuTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKlinik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDoktor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_sil
            // 
            this.btn_sil.AutoSize = true;
            this.btn_sil.Location = new System.Drawing.Point(582, 436);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(87, 35);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.AutoSize = true;
            this.btn_listele.Location = new System.Drawing.Point(687, 436);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(78, 35);
            this.btn_listele.TabIndex = 7;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // lb_tc
            // 
            this.lb_tc.AutoSize = true;
            this.lb_tc.Location = new System.Drawing.Point(47, 28);
            this.lb_tc.Name = "lb_tc";
            this.lb_tc.Size = new System.Drawing.Size(0, 25);
            this.lb_tc.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRandevuTarih,
            this.columnHeaderSaat,
            this.columnHeaderKlinik,
            this.columnHeaderDoktor});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(718, 363);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRandevuTarih
            // 
            this.columnHeaderRandevuTarih.Text = "Randevu Tarihi";
            this.columnHeaderRandevuTarih.Width = 157;
            // 
            // columnHeaderSaat
            // 
            this.columnHeaderSaat.Text = "Randevu Saati";
            this.columnHeaderSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSaat.Width = 141;
            // 
            // columnHeaderKlinik
            // 
            this.columnHeaderKlinik.Text = "Klinik Adı";
            this.columnHeaderKlinik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderKlinik.Width = 181;
            // 
            // columnHeaderDoktor
            // 
            this.columnHeaderDoktor.Text = "Doktor Ad/Soyad";
            this.columnHeaderDoktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDoktor.Width = 187;
            // 
            // Vatandaş_Randevularım_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 499);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.lb_tc);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vatandaş_Randevularım_Ekranı";
            this.Text = "Vatandaş_Randevularım_Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_listele;
        public System.Windows.Forms.Label lb_tc;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderRandevuTarih;
        private System.Windows.Forms.ColumnHeader columnHeaderSaat;
        private System.Windows.Forms.ColumnHeader columnHeaderKlinik;
        private System.Windows.Forms.ColumnHeader columnHeaderDoktor;
    }
}