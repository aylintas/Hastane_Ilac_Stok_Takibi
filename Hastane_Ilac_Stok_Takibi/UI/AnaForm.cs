using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastane_Ilac_Stok_Takibi.BL;
using Hastane_Ilac_Stok_Takibi.UI;


namespace Hastane_Ilac_Stok_Takibi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void HastaEkle_Click(object sender, EventArgs e)
        {
            FrmHastalar frmHastalar = new FrmHastalar();
            {
                Text = "Hasta Ekle";
                Hastalar Hastalar = new Hastalar() { HastalarTC = Guid.NewGuid() };
            };

            var sonuc = frmHastalar.ShowDialog();
            if(sonuc == DialogResult.OK)
            {
                BLogic.HastaEkle(frmHastalar.Hastalar);
            }

        }

        private void HastaDuzenle_Click(object sender, EventArgs e)
        {
           

        }
    }
}
