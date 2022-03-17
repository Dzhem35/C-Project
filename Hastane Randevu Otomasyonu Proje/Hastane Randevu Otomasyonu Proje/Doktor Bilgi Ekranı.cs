using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hastane_Randevu_Otomasyonu_Proje
{
    public partial class Doktor_Bilgi_Ekranı : Form
    {
        public Doktor_Bilgi_Ekranı()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Instances.path);
        OleDbCommand cmd;
        OleDbDataReader reader;

        private void btn_randevulistele_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Select * from Randevu where doktor_adsoyad='" + lb_doktoradı.Text + "'", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem randevu = new ListViewItem(reader["vatandaş_tckimlik"].ToString());
                randevu.SubItems.Add(reader["randevu_tarih"].ToString());
                randevu.SubItems.Add(reader["randevu_saat"].ToString());
                listView1.Items.Add(randevu);
            }
            reader.Close();
            con.Close();
        }
    }
}
