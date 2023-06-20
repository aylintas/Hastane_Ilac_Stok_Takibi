using Hastane_Ilac_Stok_Takibi.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Ilac_Stok_Takibi.BL
{
    public static class BLogic
    {
        public static bool HastaEkle(Hastalar m)
        {
            try
            {
                int res = DataLayer.HastaEkle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
    }
}
