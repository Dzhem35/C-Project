using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hastane_Randevu_Otomasyonu_Proje
{
    public partial class Vatandaş_Yeni_Üye : Form
    {
        
        public Vatandaş_Yeni_Üye()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Instances.path); 
        OleDbCommand cmd;
        OleDbConnection reader;
        private void btn_kayıtol_Click(object sender, EventArgs e)
        {
            con.Open();
            if (tb_ad.Text != "" && tb_soyad.Text != "" && tb_tckimlik.Text != "" && tb_şifre.Text != "" && tb_şifretekrar.Text != "" && cb_cinsiyet.Text != "")
                if (tb_şifre.Text == tb_şifretekrar.Text)
                {
                    cmd = new OleDbCommand("Insert into Vatandas(vatandaş_tckimlik, vatandaş_ad, vatandaş_soyad, vatandaş_şifre, vatandaş_dogumgünü, vatandaş_cinsiyet) values('" + tb_tckimlik.Text.Trim() + "','" + tb_ad.Text.Trim() + "','" + tb_soyad.Text.Trim() + "','" + tb_şifre.Text.Trim() + "','" + dtp_doğumtarihi.Value.Date.ToShortDateString() + "','" + cb_cinsiyet.SelectedItem.ToString() + "')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı bir şekilde gerçekleştirilmiştir.");
                    con.Close();
                    tb_ad.Text = "";
                    tb_soyad.Text = "";
                    tb_tckimlik.Text = "";
                    tb_şifre.Text = "";
                    tb_şifretekrar.Text = "";
                    dtp_doğumtarihi.Value = DateTime.Now;
                    cb_cinsiyet.SelectedItem = "";
                }
                else
                {
                    MessageBox.Show("Şifreniz aynı değil!");
                }
            else
            {
                MessageBox.Show("Boş bırakılamaz!");
            }
            con.Close();
        }

        private void Vatandaş_Yeni_Üye_Load(object sender, EventArgs e)
        {

        }
    }
}
