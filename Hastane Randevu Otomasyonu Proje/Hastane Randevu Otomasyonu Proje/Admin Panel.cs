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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Instances.path);
        OleDbCommand cmd;
        OleDbDataReader reader;
        private void btn_klinikekle_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Insert into Klinik(klinik_ad) values('" + tb_klinik.Text.Trim() + "')", con);
            cmd.ExecuteNonQuery();
            if (tb_klinik.Text != "")
            {
                MessageBox.Show("Klinik başarılı bir şekilde kaydedilmiştir.");
                tb_klinik.Text = "";
            }
            else
            {
                MessageBox.Show("Klinik adı boş bırakılamaz!");
            }

            con.Close();
        }

        private void btn_kliniklistele_Click(object sender, EventArgs e)
        {
            listBoxKlinik.Items.Clear();
            con.Open();
            cmd = new OleDbCommand("Select *from Klinik", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBoxKlinik.Items.Add(reader["klinik_ad"]);
                listBoxKlinik.Sorted = true;
            }
            reader.Close();
            con.Close();
        }

        private void btn_kliniksil_Click(object sender, EventArgs e)
        {
            con.Open();
            if (listBoxKlinik.SelectedItem != null)
            {
                cmd = new OleDbCommand("Delete from KlinikAdı where klinik_ad= '" + listBoxKlinik.SelectedItem.ToString() + "'", con);
                reader = cmd.ExecuteReader();
                MessageBox.Show("Klinik başarılı bir şekilde silinmiştir");
                listBoxKlinik.Items.Remove(listBoxKlinik.SelectedItem.ToString());
            }
            reader.Close();
            con.Close();
        }

        private void btn_doktorekle_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Insert into Doktor(doktor_tckimlik, doktor_adsoyad,doktor_şifre, doktor_klinik, doktor_cinsiyet) values('" + tb_doktortckimlik.Text.Trim() + "','" + tb_doktoradsoyad.Text.Trim() + "','" + tb_doktorşifre.Text.Trim() + "','" + listBoxKlinik.SelectedItem.ToString() + "','" + cb_doktorcinsiyet.SelectedItem.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarılı bir şekilde gerçekleştirilmiştir.");
            tb_doktoradsoyad.Text = "";
            tb_doktortckimlik.Text = "";
            tb_doktorşifre.Text = "";
            cb_doktorcinsiyet.Text = "";
            reader.Close();
            con.Close();
        }

        private void btn_vatandaşlistele_Click(object sender, EventArgs e)
        {
            con.Open();

            cmd = new OleDbCommand("Select * from Vatandaş", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (listView1.Items.Cast<ListViewItem>().Select(f => f.Text.Trim()).Contains(reader["vatandaş_tckimlik"].ToString()) == false)
                {
                    ListViewItem vatandaş = new ListViewItem(reader["vatandaş_tckimlik"].ToString());
                    vatandaş.SubItems.Add(reader["vatandaş_ad"].ToString());
                    vatandaş.SubItems.Add(reader["vatandaş_soyad"].ToString());
                    vatandaş.SubItems.Add(reader["vatandaş_cinsiyet"].ToString());
                    listView1.Items.Add(vatandaş);
                }

            }
            reader.Close();
            con.Close();
        }
        private void btn_vatandaşsil_Click(object sender, EventArgs e)
        {
            string TC = "";
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem vatandaş = listView1.SelectedItems[0];
                TC = vatandaş.SubItems[0].Text;
                con.Open();
                cmd = new OleDbCommand("Delete From Vatandaş where vatandaş_tckimlik='" + TC + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vatandaş başarılı bir şekilde silinmiştir.");
                listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                con.Close();
            }
        }

        private void btn_doktorlistele_Click(object sender, EventArgs e)
        {
            listBoxDoktorlar.Items.Clear();
            con.Open();
            if (listBoxKlinik.SelectedIndex != -1)
            {
                cmd = new OleDbCommand("Select * from Doktor where doktor_klinik='" + listBoxKlinik.SelectedItem.ToString() + "'", con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    listBoxDoktorlar.Items.Add(reader["doktor_adsoyad"]);
                    listBoxDoktorlar.Sorted = true;
                }
            }
            else
            {
                MessageBox.Show("Klinik seçmediniz!");
            }
            reader.Close();
            con.Close();
        }

        private void btn_doktorsil_Click(object sender, EventArgs e)
        {
            con.Open();
            if (listBoxDoktorlar.SelectedItem != null)
            {
                cmd = new OleDbCommand("Delete from Doktor where doktor_adsoyad= '" + listBoxDoktorlar.SelectedItem.ToString() + "'", con);
                reader = cmd.ExecuteReader();
                MessageBox.Show("Doktor başarılı bir şekilde silinmiştir");
                listBoxDoktorlar.Items.Remove(listBoxDoktorlar.SelectedItem.ToString());
            }
            reader.Close();
            con.Close();
        }

        private void Admin_Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
