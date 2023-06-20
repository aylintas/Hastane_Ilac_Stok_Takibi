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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        private void İptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Kategori Kategori { get; set; }
        public Ilac Ilac { get; set; }

        private void Tamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(KategoriID)) return;
            if (!ErrorControl(KategoriAd)) return;
            if (!ErrorControl(IlacID)) return;

            Kategori.KategoriAdi = KategoriAd.Text;
            Kategori.IlacID = ılac_ıd.Mask;


            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider4.SetError(c, "Eksik veya hatalı bilgi girişi!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider4.SetError(c, "");
                    return true;
                }
            }
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider4.SetError(c, "Eksik veya hatalı bilgi girişi!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider4.SetError(c, "");
                    return true;
                }
            }
            return true;
        }
    }
}
