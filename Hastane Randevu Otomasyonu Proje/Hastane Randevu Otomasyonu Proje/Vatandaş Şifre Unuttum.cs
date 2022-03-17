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
    public partial class Vatandaş_Şifre_Unuttum : Form
    {
        public Vatandaş_Şifre_Unuttum()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(Instances.path); 
        OleDbCommand cmd;
        OleDbDataReader reader;
        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("Select *from Vatandaş", con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (tb_tckimlik.Text == reader["vatandaş_tckimlik"].ToString())
                {
                    MessageBox.Show("Şifreniz : " + " " + reader["vatandaş_şifre"].ToString());
                }
            }
            reader.Close();
            con.Close();
        }

    }
}
