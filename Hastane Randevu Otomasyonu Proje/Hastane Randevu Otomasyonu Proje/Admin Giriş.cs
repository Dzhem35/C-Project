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
    public partial class Admin_Giriş : Form
    {
        public Admin_Giriş()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Instances.path);
        OleDbCommand cmd;
        OleDbDataReader reader;
        
        private void btn_giris_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Select * from admin where admin_tckimlik= '" + tb_tckimlik.Text.Trim() + "' and admin_şifre= '" + tb_sifre.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Admin_Panel adminPanel = new Admin_Panel();
                adminPanel.Show();
            }
            else
            {
                MessageBox.Show("Böyle bir Admin bulunmadı!");
            }
            con.Close();
        }

        private void Admin_Giriş_Load(object sender, EventArgs e)
        {

        }
    }
}
