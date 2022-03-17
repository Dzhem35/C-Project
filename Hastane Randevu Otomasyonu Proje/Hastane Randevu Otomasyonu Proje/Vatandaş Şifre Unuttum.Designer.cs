
namespace Hastane_Randevu_Otomasyonu_Proje
{
    partial class Vatandaş_Şifre_Unuttum
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
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.tb_tckimlik = new System.Windows.Forms.TextBox();
            this.lb_tckimlik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.Location = new System.Drawing.Point(254, 215);
            this.btn_sorgula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(112, 36);
            this.btn_sorgula.TabIndex = 5;
            this.btn_sorgula.Text = "Sorgula";
            this.btn_sorgula.UseVisualStyleBackColor = true;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // tb_tckimlik
            // 
            this.tb_tckimlik.Location = new System.Drawing.Point(297, 121);
            this.tb_tckimlik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_tckimlik.Name = "tb_tckimlik";
            this.tb_tckimlik.Size = new System.Drawing.Size(228, 30);
            this.tb_tckimlik.TabIndex = 4;
            // 
            // lb_tckimlik
            // 
            this.lb_tckimlik.AutoSize = true;
            this.lb_tckimlik.Location = new System.Drawing.Point(62, 121);
            this.lb_tckimlik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tckimlik.Name = "lb_tckimlik";
            this.lb_tckimlik.Size = new System.Drawing.Size(182, 25);
            this.lb_tckimlik.TabIndex = 3;
            this.lb_tckimlik.Text = "T.C Kimlik Numara:";
            // 
            // Vatandaş_Şifre_Unuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 373);
            this.Controls.Add(this.btn_sorgula);
            this.Controls.Add(this.tb_tckimlik);
            this.Controls.Add(this.lb_tckimlik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vatandaş_Şifre_Unuttum";
            this.Text = "Vatandaş Şifre Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sorgula;
        private System.Windows.Forms.TextBox tb_tckimlik;
        private System.Windows.Forms.Label lb_tckimlik;
    }
}