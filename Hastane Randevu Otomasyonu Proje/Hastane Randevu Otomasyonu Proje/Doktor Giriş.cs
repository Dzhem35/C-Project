using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Hastane_Randevu_Otomasyonu_Proje
{
    public partial class Doktor_Giriş : Form
    {
        public Doktor_Giriş()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Instances.path);
        OleDbCommand cmd;
        OleDbDataReader reader;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Select * from Doktor where doktor_tckimlik= '" + tb_tckimlik.Text.Trim() + "' and doktor_şifre= '" + tb_sifre.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Doktor_Bilgi_Ekranı doktorBilgi = new Doktor_Bilgi_Ekranı();
                doktorBilgi.lb_doktoradı.Text= reader["doktor_adsoyad"].ToString();
                doktorBilgi.Show();

            }
            else
            {
                MessageBox.Show("Böyle bir doktor bulunmadı!");
            }
            con.Close();
        }

        private void btn_sifreunuttum_Click(object sender, EventArgs e)
        {
            Doktor_Şifre_Unuttum doktorŞifreUnuttum = new Doktor_Şifre_Unuttum();
            doktorŞifreUnuttum.Show();
        }
    }
}
