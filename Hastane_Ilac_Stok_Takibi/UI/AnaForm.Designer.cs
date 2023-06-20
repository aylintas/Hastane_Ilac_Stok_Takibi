
namespace Hastane_Ilac_Stok_Takibi
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.HASTALAR = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.HastaEkle = new System.Windows.Forms.ToolStripButton();
            this.HastaDuzenle = new System.Windows.Forms.ToolStripButton();
            this.HastaSil = new System.Windows.Forms.ToolStripButton();
            this.HastaAra = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.IlacEkle = new System.Windows.Forms.ToolStripButton();
            this.IlacDuzenle = new System.Windows.Forms.ToolStripButton();
            this.IlacSil = new System.Windows.Forms.ToolStripButton();
            this.IlacBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.HASTALAR.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HASTALAR
            // 
            this.HASTALAR.Controls.Add(this.tabPage1);
            this.HASTALAR.Controls.Add(this.tabPage2);
            this.HASTALAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HASTALAR.Location = new System.Drawing.Point(0, 0);
            this.HASTALAR.Name = "HASTALAR";
            this.HASTALAR.SelectedIndex = 0;
            this.HASTALAR.Size = new System.Drawing.Size(836, 517);
            this.HASTALAR.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(828, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HASTALAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(822, 444);
            this.dataGridView1.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HastaEkle,
            this.HastaDuzenle,
            this.HastaSil,
            this.HastaAra,
            this.toolStripLabel1,
            this.toolStripTextBox1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(822, 34);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // HastaEkle
            // 
            this.HastaEkle.Image = global::Hastane_Ilac_Stok_Takibi.Properties.Resources.users_woman_man_filled_add;
            this.HastaEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HastaEkle.Name = "HastaEkle";
            this.HastaEkle.Size = new System.Drawing.Size(76, 29);
            this.HastaEkle.Text = "EKLE";
            this.HastaEkle.Click += new System.EventHandler(this.HastaEkle_Click);
            // 
            // HastaDuzenle
            // 
            this.HastaDuzenle.Image = global::Hastane_Ilac_Stok_Takibi.Properties.Resources.users_woman_man_filled_edit;
            this.HastaDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HastaDuzenle.Name = "HastaDuzenle";
            this.HastaDuzenle.Size = new System.Drawing.Size(114, 29);
            this.HastaDuzenle.Text = "DÜZENLE";
            this.HastaDuzenle.Click += new System.EventHandler(this.HastaDuzenle_Click);
            // 
            // HastaSil
            // 
            this.HastaSil.Image = global::Hastane_Ilac_Stok_Takibi.Properties.Resources.users_woman_man_filled_cancel;
            this.HastaSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HastaSil.Name = "HastaSil";
            this.HastaSil.Size = new System.Drawing.Size(63, 29);
            this.HastaSil.Text = "SİL";
            // 
            // HastaAra
            // 
            this.HastaAra.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HastaAra.Image = ((System.Drawing.Image)(resources.GetObject("HastaAra.Image")));
            this.HastaAra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HastaAra.Name = "HastaAra";
            this.HastaAra.Size = new System.Drawing.Size(34, 29);
            this.HastaAra.Text = "toolStripButton7";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(47, 29);
            this.toolStripLabel1.Text = "ARA";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 34);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "İLAÇLAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(822, 444);
            this.dataGridView2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IlacEkle,
            this.IlacDuzenle,
            this.IlacSil,
            this.IlacBul,
            this.toolStripLabel2,
            this.toolStripTextBox2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(822, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // IlacEkle
            // 
            this.IlacEkle.Image = ((System.Drawing.Image)(resources.GetObject("IlacEkle.Image")));
            this.IlacEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IlacEkle.Name = "IlacEkle";
            this.IlacEkle.Size = new System.Drawing.Size(81, 29);
            this.IlacEkle.Text = "EKLE ";
            // 
            // IlacDuzenle
            // 
            this.IlacDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("IlacDuzenle.Image")));
            this.IlacDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IlacDuzenle.Name = "IlacDuzenle";
            this.IlacDuzenle.Size = new System.Drawing.Size(114, 29);
            this.IlacDuzenle.Text = "DÜZENLE";
            // 
            // IlacSil
            // 
            this.IlacSil.Image = ((System.Drawing.Image)(resources.GetObject("IlacSil.Image")));
            this.IlacSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IlacSil.Name = "IlacSil";
            this.IlacSil.Size = new System.Drawing.Size(63, 29);
            this.IlacSil.Text = "SİL";
            // 
            // IlacBul
            // 
            this.IlacBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.IlacBul.Image = ((System.Drawing.Image)(resources.GetObject("IlacBul.Image")));
            this.IlacBul.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IlacBul.Name = "IlacBul";
            this.IlacBul.Size = new System.Drawing.Size(34, 29);
            this.IlacBul.Text = "toolStripButton8";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 29);
            this.toolStripLabel2.Text = "ARA";
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 34);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 517);
            this.Controls.Add(this.HASTALAR);
            this.Name = "AnaForm";
            this.Text = "Veri Giriş Sistemi";
            this.HASTALAR.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl HASTALAR;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton HastaEkle;
        private System.Windows.Forms.ToolStripButton HastaDuzenle;
        private System.Windows.Forms.ToolStripButton HastaSil;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton IlacEkle;
        private System.Windows.Forms.ToolStripButton IlacDuzenle;
        private System.Windows.Forms.ToolStripButton IlacSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton HastaAra;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripButton IlacBul;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
    }
}

