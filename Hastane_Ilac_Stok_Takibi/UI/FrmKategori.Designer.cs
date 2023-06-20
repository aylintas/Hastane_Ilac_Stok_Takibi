
namespace Hastane_Ilac_Stok_Takibi.UI
{
    partial class FrmKategori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.KategoriID = new System.Windows.Forms.Label();
            this.KategoriAd = new System.Windows.Forms.Label();
            this.IlacID = new System.Windows.Forms.Label();
            this.Tamam = new System.Windows.Forms.Button();
            this.İptal = new System.Windows.Forms.Button();
            this.ılac_ıd = new System.Windows.Forms.MaskedTextBox();
            this.kategori_ıd = new System.Windows.Forms.MaskedTextBox();
            this.kategori_ad = new System.Windows.Forms.ComboBox();
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // KategoriID
            // 
            this.KategoriID.AutoSize = true;
            this.KategoriID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KategoriID.Location = new System.Drawing.Point(74, 73);
            this.KategoriID.Name = "KategoriID";
            this.KategoriID.Size = new System.Drawing.Size(115, 25);
            this.KategoriID.TabIndex = 0;
            this.KategoriID.Text = "Kategori ID:";
            // 
            // KategoriAd
            // 
            this.KategoriAd.AutoSize = true;
            this.KategoriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KategoriAd.Location = new System.Drawing.Point(74, 140);
            this.KategoriAd.Name = "KategoriAd";
            this.KategoriAd.Size = new System.Drawing.Size(121, 25);
            this.KategoriAd.TabIndex = 1;
            this.KategoriAd.Text = "Kategori Ad:";
            // 
            // IlacID
            // 
            this.IlacID.AutoSize = true;
            this.IlacID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IlacID.Location = new System.Drawing.Point(74, 201);
            this.IlacID.Name = "IlacID";
            this.IlacID.Size = new System.Drawing.Size(72, 25);
            this.IlacID.TabIndex = 2;
            this.IlacID.Text = "İlaç ID:";
            // 
            // Tamam
            // 
            this.Tamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tamam.Location = new System.Drawing.Point(152, 299);
            this.Tamam.Name = "Tamam";
            this.Tamam.Size = new System.Drawing.Size(191, 53);
            this.Tamam.TabIndex = 3;
            this.Tamam.Text = "Tamam";
            this.Tamam.UseVisualStyleBackColor = true;
            this.Tamam.Click += new System.EventHandler(this.Tamam_Click);
            // 
            // İptal
            // 
            this.İptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İptal.Location = new System.Drawing.Point(374, 299);
            this.İptal.Name = "İptal";
            this.İptal.Size = new System.Drawing.Size(191, 53);
            this.İptal.TabIndex = 4;
            this.İptal.Text = "İptal";
            this.İptal.UseVisualStyleBackColor = true;
            this.İptal.Click += new System.EventHandler(this.İptal_Click);
            // 
            // ılac_ıd
            // 
            this.ılac_ıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ılac_ıd.Location = new System.Drawing.Point(216, 196);
            this.ılac_ıd.Mask = "00000000000000";
            this.ılac_ıd.Name = "ılac_ıd";
            this.ılac_ıd.Size = new System.Drawing.Size(196, 30);
            this.ılac_ıd.TabIndex = 7;
            // 
            // kategori_ıd
            // 
            this.kategori_ıd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori_ıd.Location = new System.Drawing.Point(216, 68);
            this.kategori_ıd.Mask = "0000000000";
            this.kategori_ıd.Name = "kategori_ıd";
            this.kategori_ıd.Size = new System.Drawing.Size(196, 30);
            this.kategori_ıd.TabIndex = 16;
            // 
            // kategori_ad
            // 
            this.kategori_ad.FormattingEnabled = true;
            this.kategori_ad.Items.AddRange(new object[] {
            "A Kategori",
            "B Kategori ",
            "C Kategori",
            "D Kategori ",
            "X Kategori "});
            this.kategori_ad.Location = new System.Drawing.Point(216, 137);
            this.kategori_ad.Name = "kategori_ad";
            this.kategori_ad.Size = new System.Drawing.Size(196, 28);
            this.kategori_ad.TabIndex = 17;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // FrmKategori
            // 
            this.AcceptButton = this.Tamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptal;
            this.ClientSize = new System.Drawing.Size(606, 435);
            this.Controls.Add(this.kategori_ad);
            this.Controls.Add(this.kategori_ıd);
            this.Controls.Add(this.ılac_ıd);
            this.Controls.Add(this.İptal);
            this.Controls.Add(this.Tamam);
            this.Controls.Add(this.IlacID);
            this.Controls.Add(this.KategoriAd);
            this.Controls.Add(this.KategoriID);
            this.Name = "FrmKategori";
            this.Text = "İlaç Kategori Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KategoriID;
        private System.Windows.Forms.Label KategoriAd;
        private System.Windows.Forms.Label IlacID;
        private System.Windows.Forms.Button Tamam;
        private System.Windows.Forms.Button İptal;
        private System.Windows.Forms.MaskedTextBox ılac_ıd;
        private System.Windows.Forms.MaskedTextBox kategori_ıd;
        private System.Windows.Forms.ComboBox kategori_ad;
        private System.Windows.Forms.ErrorProvider errorProvider4;
    }
}