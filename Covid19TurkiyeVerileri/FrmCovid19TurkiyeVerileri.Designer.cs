namespace Covid19TurkiyeVerileri
{
    partial class FrmCovid19TurkiyeVerileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCovid19TurkiyeVerileri));
            this.lstVeriler = new System.Windows.Forms.ListView();
            this.chTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTestSayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIyilesen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVefat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chToplamTestSayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chToplamHasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chToplamIyilesen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chToplamVefat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAgirHasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chZaturreOlasiligi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chToplamEntube = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chToplamYogunBakim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbIndir = new System.Windows.Forms.ToolStripButton();
            this.tsbAra = new System.Windows.Forms.ToolStripButton();
            this.tsbKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsbBilgi = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sstrip = new System.Windows.Forms.StatusStrip();
            this.tsslDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.sfdKaydet = new System.Windows.Forms.SaveFileDialog();
            this.tsMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVeriler
            // 
            this.lstVeriler.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstVeriler.AllowColumnReorder = true;
            this.lstVeriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTarih,
            this.chTestSayisi,
            this.chVaka,
            this.chHasta,
            this.chIyilesen,
            this.chVefat,
            this.chToplamTestSayisi,
            this.chToplamHasta,
            this.chToplamIyilesen,
            this.chToplamVefat,
            this.chAgirHasta,
            this.chZaturreOlasiligi,
            this.chToplamEntube,
            this.chToplamYogunBakim});
            this.lstVeriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVeriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstVeriler.FullRowSelect = true;
            this.lstVeriler.GridLines = true;
            this.lstVeriler.HideSelection = false;
            this.lstVeriler.Location = new System.Drawing.Point(0, 0);
            this.lstVeriler.Name = "lstVeriler";
            this.lstVeriler.Size = new System.Drawing.Size(1128, 536);
            this.lstVeriler.TabIndex = 1;
            this.lstVeriler.UseCompatibleStateImageBehavior = false;
            this.lstVeriler.View = System.Windows.Forms.View.Details;
            // 
            // chTarih
            // 
            this.chTarih.Text = "Tarih";
            this.chTarih.Width = 90;
            // 
            // chTestSayisi
            // 
            this.chTestSayisi.Text = "Test Sayısı";
            this.chTestSayisi.Width = 110;
            // 
            // chVaka
            // 
            this.chVaka.Text = "Vaka";
            this.chVaka.Width = 100;
            // 
            // chHasta
            // 
            this.chHasta.Text = "Hasta";
            this.chHasta.Width = 100;
            // 
            // chIyilesen
            // 
            this.chIyilesen.Text = "İyileşen";
            this.chIyilesen.Width = 100;
            // 
            // chVefat
            // 
            this.chVefat.Text = "Vefat";
            this.chVefat.Width = 100;
            // 
            // chToplamTestSayisi
            // 
            this.chToplamTestSayisi.Text = "Toplam Test Sayısı";
            this.chToplamTestSayisi.Width = 100;
            // 
            // chToplamHasta
            // 
            this.chToplamHasta.Text = "Toplam Hasta";
            // 
            // chToplamIyilesen
            // 
            this.chToplamIyilesen.Text = "Toplam İyileşen";
            // 
            // chToplamVefat
            // 
            this.chToplamVefat.Text = "Toplam Vefat";
            // 
            // chAgirHasta
            // 
            this.chAgirHasta.Text = "Ağır Hasta";
            this.chAgirHasta.Width = 100;
            // 
            // chZaturreOlasiligi
            // 
            this.chZaturreOlasiligi.Text = "Zatürre Olasılığı";
            // 
            // chToplamEntube
            // 
            this.chToplamEntube.Text = "Toplam Entübe";
            // 
            // chToplamYogunBakim
            // 
            this.chToplamYogunBakim.Text = "Toplam Yoğun Bakım";
            // 
            // tsMenu
            // 
            this.tsMenu.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIndir,
            this.tsbAra,
            this.tsbKaydet,
            this.tsbBilgi});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(1128, 33);
            this.tsMenu.TabIndex = 2;
            // 
            // tsbIndir
            // 
            this.tsbIndir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbIndir.Image = global::Covid19TurkiyeVerileri.Properties.Resources.database_arrow_down_icon;
            this.tsbIndir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIndir.Name = "tsbIndir";
            this.tsbIndir.Size = new System.Drawing.Size(142, 29);
            this.tsbIndir.Text = "&Verileri indir";
            this.tsbIndir.Click += new System.EventHandler(this.TsbIndir_Click);
            // 
            // tsbAra
            // 
            this.tsbAra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbAra.Image = global::Covid19TurkiyeVerileri.Properties.Resources.database_search_icon;
            this.tsbAra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAra.Name = "tsbAra";
            this.tsbAra.Size = new System.Drawing.Size(67, 29);
            this.tsbAra.Text = "&Ara";
            this.tsbAra.Click += new System.EventHandler(this.TsbAra_Click);
            // 
            // tsbKaydet
            // 
            this.tsbKaydet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbKaydet.Image = global::Covid19TurkiyeVerileri.Properties.Resources.folder_add_icon;
            this.tsbKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKaydet.Name = "tsbKaydet";
            this.tsbKaydet.Size = new System.Drawing.Size(95, 29);
            this.tsbKaydet.Text = "&Kaydet";
            this.tsbKaydet.Click += new System.EventHandler(this.TsbKaydet_Click);
            // 
            // tsbBilgi
            // 
            this.tsbBilgi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbBilgi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tsbBilgi.Image = global::Covid19TurkiyeVerileri.Properties.Resources.information_icon;
            this.tsbBilgi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBilgi.Name = "tsbBilgi";
            this.tsbBilgi.Size = new System.Drawing.Size(75, 29);
            this.tsbBilgi.Text = "Bilgi";
            this.tsbBilgi.Click += new System.EventHandler(this.TsbBilgi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstVeriler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 536);
            this.panel1.TabIndex = 3;
            // 
            // sstrip
            // 
            this.sstrip.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.sstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslDurum});
            this.sstrip.Location = new System.Drawing.Point(0, 547);
            this.sstrip.Name = "sstrip";
            this.sstrip.Size = new System.Drawing.Size(1128, 22);
            this.sstrip.TabIndex = 4;
            // 
            // tsslDurum
            // 
            this.tsslDurum.Name = "tsslDurum";
            this.tsslDurum.Size = new System.Drawing.Size(0, 15);
            // 
            // sfdKaydet
            // 
            this.sfdKaydet.Filter = "Excel Çalışma Kitabı|*.xlsx";
            // 
            // FrmCovid19TurkiyeVerileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 569);
            this.Controls.Add(this.sstrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCovid19TurkiyeVerileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid-19 Türkiye Verileri";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.sstrip.ResumeLayout(false);
            this.sstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstVeriler;
        private System.Windows.Forms.ColumnHeader chTarih;
        private System.Windows.Forms.ColumnHeader chTestSayisi;
        private System.Windows.Forms.ColumnHeader chVaka;
        private System.Windows.Forms.ColumnHeader chHasta;
        private System.Windows.Forms.ColumnHeader chIyilesen;
        private System.Windows.Forms.ColumnHeader chVefat;
        private System.Windows.Forms.ColumnHeader chToplamTestSayisi;
        private System.Windows.Forms.ColumnHeader chToplamHasta;
        private System.Windows.Forms.ColumnHeader chToplamIyilesen;
        private System.Windows.Forms.ColumnHeader chToplamVefat;
        private System.Windows.Forms.ColumnHeader chAgirHasta;
        private System.Windows.Forms.ColumnHeader chZaturreOlasiligi;
        private System.Windows.Forms.ColumnHeader chToplamEntube;
        private System.Windows.Forms.ColumnHeader chToplamYogunBakim;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton tsbIndir;
        private System.Windows.Forms.StatusStrip sstrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslDurum;
        private System.Windows.Forms.ToolStripButton tsbAra;
        private System.Windows.Forms.ToolStripButton tsbKaydet;
        private System.Windows.Forms.ToolStripButton tsbBilgi;
        private System.Windows.Forms.SaveFileDialog sfdKaydet;
    }
}

