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
    public partial class Vatandaş_Randevularım_Ekranı : Form
    {
        public Vatandaş_Randevularım_Ekranı()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Instances.path);
        OleDbCommand cmd;
        OleDbDataReader reader;
        private void btn_listele_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Select *from Randevu where vatandaş_tckimlik='" + lb_tc.Text + "'", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem randevular = new ListViewItem(reader["randevu_tarih"].ToString());
                randevular.SubItems.Add(reader["randevu_saat"].ToString());
                randevular.SubItems.Add(reader["doktor_klinik"].ToString());
                randevular.SubItems.Add(reader["doktor_adsoyad"].ToString());
                listView1.Items.Add(randevular);
            }
            reader.Close();
            con.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string TC = "";
            string zaman = "";
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem randevu = listView1.SelectedItems[0];
                TC = lb_tc.Text;
                zaman = randevu.SubItems[0].Text;
                con.Open();
                cmd = new OleDbCommand("Delete From Randevu where vatandaş_tckimlik='" + TC + "' and randevu_tarih='" + zaman + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Randevu başarılı bir şekilde silinmiştir.");
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                con.Close();
            }
        }
    }
}
