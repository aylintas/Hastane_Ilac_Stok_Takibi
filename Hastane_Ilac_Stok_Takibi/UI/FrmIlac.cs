using System;
using System.Windows.Forms;

namespace Hastane_Ilac_Stok_Takibi
{
    public partial class FrmIlac : Form
    {
        public FrmIlac()
        {
            InitializeComponent();
        }

        private void FrmIlac_Load(object sender, EventArgs e)
        {

        }

        public Ilac Ilac { get; set; }
        public Hastalar Hastalar { get; set; }
        public Kategori Kategori { get; set; }
        private void Tamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(IlacID)) return;
            if (!ErrorControl(IlacAdi)) return;
            if (!ErrorControl(StokMiktari)) return;
            if (!ErrorControl(KategoriID)) return;
            if (!ErrorControl(HastaTC)) return;

            Ilac.IlacAdi = IlacID.Mask;
            Ilac.IlacAdi = IlacAdi.Text;
            Ilac.StokMiktari = StokMiktari.DecimalPlaces;
            Ilac.KategoriID = KategoriID.Mask;
            Ilac.HastalarTC = HastaTC.Mask;


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
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi girişi!");
                    c.Focus();
                    return false;
                }

                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi girişi!");
                    c.Focus();
                    return false;
                }

                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value==0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi girişi!");
                    c.Focus();
                    return false;
                }

                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
        }
    }
}
