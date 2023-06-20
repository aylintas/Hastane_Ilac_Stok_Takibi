using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Ilac_Stok_Takibi.UI
{
    public partial class FrmHastalar : Form
    {
        public FrmHastalar()
        {
            InitializeComponent();
        }

        public Ilac Ilac { get; set; }
        public Hastalar Hastalar { get; set; }
            

        private void İptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Tamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(HastaTC)) return;
            if (!ErrorControl(HastaAd)) return;
            if (!ErrorControl(HastaSoyad)) return;
            if (!ErrorControl(Recete)) return;
            if (!ErrorControl(IlacID)) return;

            Hastalar.HastalarAdi = HastaAd.Text;
            Hastalar.HastalarSoyadi = HastaSoyad.Text;
            Hastalar.HastalarRecete = Recete.Text;
            Hastalar.IlacID = IlacID.Mask;
           

            DialogResult = DialogResult.OK;

        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider3.SetError(c, "Eksik veya hatalı bilgi girişi!");
                    c.Focus();
                    return false;
                }

                else
                {
                    errorProvider3.SetError(c, "");
                    return true;
                }
            }

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider3.SetError(c, "Eksik veya hatalı bilgi girişi!");
                    c.Focus();
                    return false;
                }

                else
                {
                    errorProvider3.SetError(c, "");
                    return true;
                }
            }
            return true;
        }
    }
}
