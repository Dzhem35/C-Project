
namespace Hastane_Randevu_Otomasyonu_Proje
{
    partial class Doktor_Bilgi_Ekranı
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
            this.components = new System.ComponentModel.Container();
            this.lb_hastalar = new System.Windows.Forms.Label();
            this.randevuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneDataSet = new Hastane_Randevu_Otomasyonu_Proje.HastaneDataSet();
            this.btn_randevulistele = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_doktoradı = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_hastalar
            // 
            this.lb_hastalar.AutoSize = true;
            this.lb_hastalar.Location = new System.Drawing.Point(62, 48);
            this.lb_hastalar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_hastalar.Name = "lb_hastalar";
            this.lb_hastalar.Size = new System.Drawing.Size(95, 25);
            this.lb_hastalar.TabIndex = 5;
            this.lb_hastalar.Text = " Hastalar:";
            // 
            // randevuBindingSource
            // 
            this.randevuBindingSource.DataMember = "Randevu";
            this.randevuBindingSource.DataSource = this.hastaneDataSet;
            // 
            // hastaneDataSet
            // 
            this.hastaneDataSet.DataSetName = "HastaneDataSet";
            this.hastaneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // randevuTableAdapter
            // 
            // 
            // btn_randevulistele
            // 
            this.btn_randevulistele.AutoSize = true;
            this.btn_randevulistele.Location = new System.Drawing.Point(476, 379);
            this.btn_randevulistele.Name = "btn_randevulistele";
            this.btn_randevulistele.Size = new System.Drawing.Size(87, 35);
            this.btn_randevulistele.TabIndex = 6;
            this.btn_randevulistele.Text = "Listele";
            this.btn_randevulistele.UseVisualStyleBackColor = true;
            this.btn_randevulistele.Click += new System.EventHandler(this.btn_randevulistele_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(67, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(496, 268);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vatandaş TC ";
            this.columnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Randevu Tarih";
            this.columnHeader2.Width = 177;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Randevu Saat";
            this.columnHeader3.Width = 161;
            // 
            // lb_doktoradı
            // 
            this.lb_doktoradı.AutoSize = true;
            this.lb_doktoradı.Location = new System.Drawing.Point(197, 13);
            this.lb_doktoradı.Name = "lb_doktoradı";
            this.lb_doktoradı.Size = new System.Drawing.Size(0, 25);
            this.lb_doktoradı.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hoş geldiniz!";
            // 
            // Doktor_Bilgi_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_doktoradı);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_randevulistele);
            this.Controls.Add(this.lb_hastalar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Doktor_Bilgi_Ekranı";
            this.Text = "Doktor Bilgi Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.randevuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_hastalar;
        private HastaneDataSet hastaneDataSet;
        private System.Windows.Forms.BindingSource randevuBindingSource;
        private System.Windows.Forms.Button btn_randevulistele;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.Label lb_doktoradı;
        private System.Windows.Forms.Label label1;
    }
}