
namespace Hastane_Ilac_Stok_Takibi.UI
{
    partial class FrmCalisanlar
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
            this.Iptal = new System.Windows.Forms.Button();
            this.Tamam = new System.Windows.Forms.Button();
            this.CalisanID = new System.Windows.Forms.MaskedTextBox();
            this.Telefon = new System.Windows.Forms.MaskedTextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.Adi = new System.Windows.Forms.TextBox();
            this.CalisanMail = new System.Windows.Forms.Label();
            this.CalisanTelefon = new System.Windows.Forms.Label();
            this.CalisanSoyad = new System.Windows.Forms.Label();
            this.CalisanAdi = new System.Windows.Forms.Label();
            this.Calisanlar_ID = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Iptal
            // 
            this.Iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Iptal.Location = new System.Drawing.Point(298, 331);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(149, 50);
            this.Iptal.TabIndex = 25;
            this.Iptal.Text = "İptal";
            this.Iptal.UseVisualStyleBackColor = true;
            this.Iptal.Click += new System.EventHandler(this.Iptal_Click);
            // 
            // Tamam
            // 
            this.Tamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tamam.Location = new System.Drawing.Point(109, 331);
            this.Tamam.Name = "Tamam";
            this.Tamam.Size = new System.Drawing.Size(149, 50);
            this.Tamam.TabIndex = 24;
            this.Tamam.Text = "Tamam";
            this.Tamam.UseVisualStyleBackColor = true;
            this.Tamam.Click += new System.EventHandler(this.Tamam_Click);
            // 
            // CalisanID
            // 
            this.CalisanID.Location = new System.Drawing.Point(198, 50);
            this.CalisanID.Mask = "00000000000000";
            this.CalisanID.Name = "CalisanID";
            this.CalisanID.Size = new System.Drawing.Size(211, 26);
            this.CalisanID.TabIndex = 23;
            // 
            // Telefon
            // 
            this.Telefon.Location = new System.Drawing.Point(198, 190);
            this.Telefon.Mask = "(500) 000-0000";
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(211, 26);
            this.Telefon.TabIndex = 21;
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(198, 145);
            this.Soyad.Multiline = true;
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(211, 26);
            this.Soyad.TabIndex = 20;
            // 
            // Adi
            // 
            this.Adi.Location = new System.Drawing.Point(198, 100);
            this.Adi.Multiline = true;
            this.Adi.Name = "Adi";
            this.Adi.Size = new System.Drawing.Size(211, 26);
            this.Adi.TabIndex = 19;
            // 
            // CalisanMail
            // 
            this.CalisanMail.AutoSize = true;
            this.CalisanMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanMail.Location = new System.Drawing.Point(65, 242);
            this.CalisanMail.Name = "CalisanMail";
            this.CalisanMail.Size = new System.Drawing.Size(115, 25);
            this.CalisanMail.TabIndex = 18;
            this.CalisanMail.Text = "Mail Adresi:";
            // 
            // CalisanTelefon
            // 
            this.CalisanTelefon.AutoSize = true;
            this.CalisanTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanTelefon.Location = new System.Drawing.Point(65, 195);
            this.CalisanTelefon.Name = "CalisanTelefon";
            this.CalisanTelefon.Size = new System.Drawing.Size(84, 25);
            this.CalisanTelefon.TabIndex = 17;
            this.CalisanTelefon.Text = "Telefon:";
            // 
            // CalisanSoyad
            // 
            this.CalisanSoyad.AutoSize = true;
            this.CalisanSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanSoyad.Location = new System.Drawing.Point(62, 150);
            this.CalisanSoyad.Name = "CalisanSoyad";
            this.CalisanSoyad.Size = new System.Drawing.Size(79, 25);
            this.CalisanSoyad.TabIndex = 16;
            this.CalisanSoyad.Text = "Soyadı:";
            // 
            // CalisanAdi
            // 
            this.CalisanAdi.AutoSize = true;
            this.CalisanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CalisanAdi.Location = new System.Drawing.Point(65, 99);
            this.CalisanAdi.Name = "CalisanAdi";
            this.CalisanAdi.Size = new System.Drawing.Size(52, 25);
            this.CalisanAdi.TabIndex = 15;
            this.CalisanAdi.Text = " Adı:";
            // 
            // Calisanlar_ID
            // 
            this.Calisanlar_ID.AutoSize = true;
            this.Calisanlar_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Calisanlar_ID.Location = new System.Drawing.Point(65, 49);
            this.Calisanlar_ID.Name = "Calisanlar_ID";
            this.Calisanlar_ID.Size = new System.Drawing.Size(108, 25);
            this.Calisanlar_ID.TabIndex = 14;
            this.Calisanlar_ID.Text = "Çalışan ID:";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(198, 241);
            this.Mail.Multiline = true;
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(211, 26);
            this.Mail.TabIndex = 26;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FrmCalisanlar
            // 
            this.AcceptButton = this.Tamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Iptal;
            this.ClientSize = new System.Drawing.Size(498, 448);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Iptal);
            this.Controls.Add(this.Tamam);
            this.Controls.Add(this.CalisanID);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.Adi);
            this.Controls.Add(this.CalisanMail);
            this.Controls.Add(this.CalisanTelefon);
            this.Controls.Add(this.CalisanSoyad);
            this.Controls.Add(this.CalisanAdi);
            this.Controls.Add(this.Calisanlar_ID);
            this.Name = "FrmCalisanlar";
            this.Text = "Çalışan Bilgileri ";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.Button Tamam;
        private System.Windows.Forms.MaskedTextBox CalisanID;
        private System.Windows.Forms.MaskedTextBox Telefon;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.TextBox Adi;
        private System.Windows.Forms.Label CalisanMail;
        private System.Windows.Forms.Label CalisanTelefon;
        private System.Windows.Forms.Label CalisanSoyad;
        private System.Windows.Forms.Label CalisanAdi;
        private System.Windows.Forms.Label Calisanlar_ID;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}