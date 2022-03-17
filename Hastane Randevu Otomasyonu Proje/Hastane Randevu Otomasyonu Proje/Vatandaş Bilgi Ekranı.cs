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
    public partial class Vatandaş_Bilgi_Ekranı : Form
    {
        public Vatandaş_Bilgi_Ekranı()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Instances.path); 
        OleDbCommand cmd;
        OleDbDataReader reader;

        private void Vatandaş_Bilgi_Ekranı_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Select *from Vatandaş where vatandaş_tckimlik='" + lb_tc.Text + "'", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lb_adı.Text = reader["vatandaş_ad"].ToString();
                lb_soyadı.Text = reader["vatandaş_soyad"].ToString();
                tb_sifre.Text = reader["vatandaş_şifre"].ToString();
                dtp_dogum.Value = DateTime.Parse(reader["vatandaş_dogumgünü"].ToString());
                cb_cinsiyet.Text = reader["vatandaş_cinsiyet"].ToString();
            }
            reader.Close();
            con.Close();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Update Vatandaş set vatandaş_şifre='" + tb_sifre.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bilgileriniz başarılı bir şekilde beğiştirilmiştir.");
            con.Close();
        }
    }
}
