
namespace Hastane_Ilac_Stok_Takibi
{
    partial class FrmIlac
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IlacAdi = new System.Windows.Forms.TextBox();
            this.KategoriID = new System.Windows.Forms.MaskedTextBox();
            this.HastaTC = new System.Windows.Forms.MaskedTextBox();
            this.IlacID = new System.Windows.Forms.MaskedTextBox();
            this.Tamam = new System.Windows.Forms.Button();
            this.Iptal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.StokMiktari = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlaç ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlaç Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(71, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Miktarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(74, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kategori ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hasta TC:";
            // 
            // IlacAdi
            // 
            this.IlacAdi.Location = new System.Drawing.Point(207, 109);
            this.IlacAdi.Multiline = true;
            this.IlacAdi.Name = "IlacAdi";
            this.IlacAdi.Size = new System.Drawing.Size(171, 26);
            this.IlacAdi.TabIndex = 7;
            // 
            // KategoriID
            // 
            this.KategoriID.Location = new System.Drawing.Point(207, 199);
            this.KategoriID.Mask = "0000000000";
            this.KategoriID.Name = "KategoriID";
            this.KategoriID.Size = new System.Drawing.Size(171, 26);
            this.KategoriID.TabIndex = 9;
            // 
            // HastaTC
            // 
            this.HastaTC.Location = new System.Drawing.Point(207, 252);
            this.HastaTC.Mask = "***********";
            this.HastaTC.Name = "HastaTC";
            this.HastaTC.Size = new System.Drawing.Size(171, 26);
            this.HastaTC.TabIndex = 10;
            // 
            // IlacID
            // 
            this.IlacID.Location = new System.Drawing.Point(207, 59);
            this.IlacID.Mask = "00000000000000";
            this.IlacID.Name = "IlacID";
            this.IlacID.Size = new System.Drawing.Size(171, 26);
            this.IlacID.TabIndex = 11;
            // 
            // Tamam
            // 
            this.Tamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tamam.Location = new System.Drawing.Point(118, 340);
            this.Tamam.Name = "Tamam";
            this.Tamam.Size = new System.Drawing.Size(149, 50);
            this.Tamam.TabIndex = 12;
            this.Tamam.Text = "Tamam";
            this.Tamam.UseVisualStyleBackColor = true;
            this.Tamam.Click += new System.EventHandler(this.Tamam_Click);
            // 
            // Iptal
            // 
            this.Iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Iptal.Location = new System.Drawing.Point(307, 340);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(149, 50);
            this.Iptal.TabIndex = 13;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            this.Iptal.Click += new System.EventHandler(this.Iptal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StokMiktari
            // 
            this.StokMiktari.Location = new System.Drawing.Point(207, 158);
            this.StokMiktari.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StokMiktari.Name = "StokMiktari";
            this.StokMiktari.Size = new System.Drawing.Size(171, 26);
            this.StokMiktari.TabIndex = 14;
            // 
            // FrmIlac
            // 
            this.AcceptButton = this.Tamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Iptal;
            this.ClientSize = new System.Drawing.Size(478, 416);
            this.Controls.Add(this.StokMiktari);
            this.Controls.Add(this.Iptal);
            this.Controls.Add(this.Tamam);
            this.Controls.Add(this.IlacID);
            this.Controls.Add(this.HastaTC);
            this.Controls.Add(this.KategoriID);
            this.Controls.Add(this.IlacAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmIlac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İlaç Bilgileri";
            this.Load += new System.EventHandler(this.FrmIlac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokMiktari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IlacAdi;
        private System.Windows.Forms.MaskedTextBox KategoriID;
        private System.Windows.Forms.MaskedTextBox HastaTC;
        private System.Windows.Forms.MaskedTextBox IlacID;
        private System.Windows.Forms.Button Tamam;
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown StokMiktari;
    }
}