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
    public partial class Vatandaş_Randevu_Ekranı : Form
    {
        public Vatandaş_Randevu_Ekranı()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Instances.path); 
        OleDbCommand cmd;
        OleDbDataReader reader;
        private void Vatandaş_Randevu_Ekranı_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Select * from Klinik", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb_klinik.Items.Add(reader["klinik_ad"].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void cb_klinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_doktor.Items.Clear();
            cb_doktor.Text = "";
            con.Open();
            cmd = new OleDbCommand("Select * from Doktor where doktor_klinik='" + cb_klinik.Text + "'", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb_doktor.Items.Add(reader["doktor_adsoyad"].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void btn_randevuara_Click(object sender, EventArgs e)
        {
            var tarih = DateTime.Parse(dtp_randevu.Value.ToShortDateString());
            DateTime dt = DateTime.Parse(DateTime.Now.ToShortDateString());
            int tarih1 = DateTime.Compare(tarih, dt);
            if (tarih1 < 0)
            {
                MessageBox.Show("Geçmiş tarihte randevu alınamaz.");
            }
            else
            {
                if (cb_klinik.Text != "" && cb_doktor.Text != "")
                {
                    lb_saat.Visible = true;
                    cb_saat.Visible = true;
                    btn_randevual.Visible = true;
                }
                else
                {
                    MessageBox.Show("Klinik ve doktor boş bırakılamaz.");
                }
            }
        }

        private void btn_randevual_Click(object sender, EventArgs e)
        {
            int a = 0;
            con.Open();
            cmd = new OleDbCommand("Select *from Randevu", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (cb_doktor.Text == reader["doktor_adsoyad"].ToString() && dtp_randevu.Value.ToShortDateString() == reader["randevu_tarih"].ToString() && cb_saat.Text == reader["randevu_saat"].ToString())
                {
                    MessageBox.Show("Kayıtlı randevu mevcuttur.");
                    a = 1;
                }
            }
            reader.Close();
            con.Close();
            con.Open();
            if (a == 0)
            {
                string ay = dtp_randevu.Value.ToShortDateString();
                string saat = cb_saat.Text;
                string tarih = ay + " " + saat;
                var tarih1 = DateTime.Parse(tarih);
                int değer = DateTime.Compare(tarih1, DateTime.Now);
                if (değer >= 0)
                {

                    cmd = new OleDbCommand("Insert into Randevu(vatandaş_tckimlik, randevu_tarih, randevu_saat, doktor_adsoyad, doktor_klinik) values('" + lb_tc.Text + "', '" + dtp_randevu.Value.ToShortDateString() + "', '" + cb_saat.Text + "', '" + cb_doktor.Text + "', '" + cb_klinik.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Randevu kaydınız başarılı bir şekilde alınmıştır.");
                }
                else
                {
                    MessageBox.Show("Geçmiş saate ait randevu alınamaz.");
                }
            }
            con.Close();
        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            Vatandaş_Bilgi_Ekranı vatandaşBilgi = new Vatandaş_Bilgi_Ekranı();
            vatandaşBilgi.lb_tc.Text = lb_tc.Text;
            vatandaşBilgi.Show();
        }
        private void btn_randevu_Click(object sender, EventArgs e)
        {
            Vatandaş_Randevularım_Ekranı vatandaşRandevuEkranı = new Vatandaş_Randevularım_Ekranı();
            vatandaşRandevuEkranı.lb_tc.Text = lb_tc.Text;
            vatandaşRandevuEkranı.Show();
        }

    }
}
