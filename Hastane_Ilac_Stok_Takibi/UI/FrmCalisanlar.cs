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
    public partial class FrmCalisanlar : Form
    {
        public FrmCalisanlar()
        {
            InitializeComponent();
        }

         public Calısanlar Calısanlar { get; set; }

        private void Tamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(CalisanID)) return;
            if (!ErrorControl(CalisanAdi)) return;
            if (!ErrorControl(CalisanSoyad)) return;
            if (!ErrorControl(CalisanTelefon)) return;
            if (!ErrorControl(CalisanMail)) return;

            Calısanlar.CalisanlarAdi = CalisanAdi.Text;
            Calısanlar.CalisanlarSoyadi = CalisanSoyad.Text;
            Calısanlar.CalisanlarTelefon = CalisanTelefon.Text;
            Calısanlar.CalisanlarMail = CalisanMail.Text;
            
            DialogResult = DialogResult.OK;
        }

        private void Iptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider2.SetError(c, "Eksik veya hatalı bilgi girişi!");
                    c.Focus();
                    return false;
                }

                else
                {
                    errorProvider2.SetError(c, "");
                    return true;
                }
            }

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider2.SetError(c, "Eksik veya hatalı bilgi girişi!");
                    c.Focus();
                    return false;
                }

                else
                {
                    errorProvider2.SetError(c, "");
                    return true;
                }
            }
            return true;
        }
    }
}
