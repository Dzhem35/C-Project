using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Randevu_Otomasyonu_Proje
{
    public partial class HastaneRandevuOtomasyonGiriş : Form
    {
        public HastaneRandevuOtomasyonGiriş()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Admin_Giriş adminGiriş = new Admin_Giriş();
            adminGiriş.Show();
        }

        private void btn_vatandas_Click(object sender, EventArgs e)
        {
            VatandasGiris vatandaşGiriş = new VatandasGiris();
            vatandaşGiriş.Show();
        }

        private void btn_doktor_Click(object sender, EventArgs e)
        {
            Doktor_Giriş doktorGiriş = new Doktor_Giriş();
            doktorGiriş.Show();
        }
    }
}
