
namespace Hastane_Ilac_Stok_Takibi.UI
{
    partial class FrmHastalar
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
            this.Hasta_tc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HastaTC = new System.Windows.Forms.MaskedTextBox();
            this.HastaAd = new System.Windows.Forms.TextBox();
            this.HastaSoyad = new System.Windows.Forms.TextBox();
            this.Recete = new System.Windows.Forms.ComboBox();
            this.IlacID = new System.Windows.Forms.MaskedTextBox();
            this.Tamam = new System.Windows.Forms.Button();
            this.İptal = new System.Windows.Forms.Button();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // Hasta_tc
            // 
            this.Hasta_tc.AutoSize = true;
            this.Hasta_tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hasta_tc.Location = new System.Drawing.Point(102, 48);
            this.Hasta_tc.Name = "Hasta_tc";
            this.Hasta_tc.Size = new System.Drawing.Size(102, 25);
            this.Hasta_tc.TabIndex = 0;
            this.Hasta_tc.Text = "Hasta TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(102, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(98, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(98, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reçete:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(98, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "İlaç ID:";
            // 
            // HastaTC
            // 
            this.HastaTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HastaTC.Location = new System.Drawing.Point(266, 41);
            this.HastaTC.Mask = "00000000000";
            this.HastaTC.Name = "HastaTC";
            this.HastaTC.Size = new System.Drawing.Size(187, 30);
            this.HastaTC.TabIndex = 5;
            // 
            // HastaAd
            // 
            this.HastaAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HastaAd.Location = new System.Drawing.Point(266, 93);
            this.HastaAd.Multiline = true;
            this.HastaAd.Name = "HastaAd";
            this.HastaAd.Size = new System.Drawing.Size(187, 31);
            this.HastaAd.TabIndex = 6;
            // 
            // HastaSoyad
            // 
            this.HastaSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HastaSoyad.Location = new System.Drawing.Point(266, 148);
            this.HastaSoyad.Multiline = true;
            this.HastaSoyad.Name = "HastaSoyad";
            this.HastaSoyad.Size = new System.Drawing.Size(187, 31);
            this.HastaSoyad.TabIndex = 7;
            // 
            // Recete
            // 
            this.Recete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Recete.FormattingEnabled = true;
            this.Recete.Items.AddRange(new object[] {
            "Reçete Var",
            "Reçete Yok "});
            this.Recete.Location = new System.Drawing.Point(266, 201);
            this.Recete.Name = "Recete";
            this.Recete.Size = new System.Drawing.Size(187, 33);
            this.Recete.TabIndex = 8;
            // 
            // IlacID
            // 
            this.IlacID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IlacID.Location = new System.Drawing.Point(266, 252);
            this.IlacID.Mask = "00000000000000";
            this.IlacID.Name = "IlacID";
            this.IlacID.Size = new System.Drawing.Size(187, 30);
            this.IlacID.TabIndex = 9;
            // 
            // Tamam
            // 
            this.Tamam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tamam.Location = new System.Drawing.Point(142, 360);
            this.Tamam.Name = "Tamam";
            this.Tamam.Size = new System.Drawing.Size(195, 63);
            this.Tamam.TabIndex = 10;
            this.Tamam.Text = "Tamam";
            this.Tamam.UseVisualStyleBackColor = true;
            this.Tamam.Click += new System.EventHandler(this.Tamam_Click);
            // 
            // İptal
            // 
            this.İptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İptal.Location = new System.Drawing.Point(363, 360);
            this.İptal.Name = "İptal";
            this.İptal.Size = new System.Drawing.Size(195, 63);
            this.İptal.TabIndex = 11;
            this.İptal.Text = "İptal";
            this.İptal.UseVisualStyleBackColor = true;
            this.İptal.Click += new System.EventHandler(this.İptal_Click);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // FrmHastalar
            // 
            this.AcceptButton = this.Tamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.İptal;
            this.ClientSize = new System.Drawing.Size(584, 465);
            this.Controls.Add(this.İptal);
            this.Controls.Add(this.Tamam);
            this.Controls.Add(this.IlacID);
            this.Controls.Add(this.Recete);
            this.Controls.Add(this.HastaSoyad);
            this.Controls.Add(this.HastaAd);
            this.Controls.Add(this.HastaTC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hasta_tc);
            this.Name = "FrmHastalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hasta Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hasta_tc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox HastaTC;
        private System.Windows.Forms.TextBox HastaAd;
        private System.Windows.Forms.TextBox HastaSoyad;
        private System.Windows.Forms.ComboBox Recete;
        private System.Windows.Forms.MaskedTextBox IlacID;
        private System.Windows.Forms.Button Tamam;
        private System.Windows.Forms.Button İptal;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}