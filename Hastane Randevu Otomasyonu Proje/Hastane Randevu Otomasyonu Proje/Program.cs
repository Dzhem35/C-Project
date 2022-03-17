using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Randevu_Otomasyonu_Proje
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HastaneRandevuOtomasyonGiriş dzhem = new HastaneRandevuOtomasyonGiriş();
            Application.Run(dzhem);
        }
    }
}
