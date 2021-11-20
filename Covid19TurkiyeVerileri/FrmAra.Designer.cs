namespace Covid19TurkiyeVerileri
{
    partial class FrmAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAra));
            this.btnAra = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.gBox = new System.Windows.Forms.GroupBox();
            this.cboxSecilenKriter = new System.Windows.Forms.ComboBox();
            this.cboxAramaAlani = new System.Windows.Forms.ComboBox();
            this.gBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(433, 23);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 44);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(317, 34);
            this.txtSayi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(109, 29);
            this.txtSayi.TabIndex = 0;
            this.txtSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSayi_KeyPress);
            // 
            // gBox
            // 
            this.gBox.Controls.Add(this.cboxSecilenKriter);
            this.gBox.Controls.Add(this.cboxAramaAlani);
            this.gBox.Controls.Add(this.btnAra);
            this.gBox.Controls.Add(this.txtSayi);
            this.gBox.Location = new System.Drawing.Point(12, 12);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(514, 91);
            this.gBox.TabIndex = 3;
            this.gBox.TabStop = false;
            this.gBox.Text = "Tür > Kriter > Sayı";
            // 
            // cboxSecilenKriter
            // 
            this.cboxSecilenKriter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxSecilenKriter.FormattingEnabled = true;
            this.cboxSecilenKriter.Items.AddRange(new object[] {
            "Büyüktür",
            "Büyük Eşittir",
            "Küçüktür",
            "Küçük Eşittir"});
            this.cboxSecilenKriter.Location = new System.Drawing.Point(195, 33);
            this.cboxSecilenKriter.Name = "cboxSecilenKriter";
            this.cboxSecilenKriter.Size = new System.Drawing.Size(115, 32);
            this.cboxSecilenKriter.TabIndex = 2;
            // 
            // cboxAramaAlani
            // 
            this.cboxAramaAlani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAramaAlani.FormattingEnabled = true;
            this.cboxAramaAlani.Items.AddRange(new object[] {
            "Test Sayısı",
            "Vaka",
            "Hasta",
            "İyileşen",
            "Vefat",
            "Toplam Test Sayısı",
            "Toplam Hasta",
            "Toplam İyileşen",
            "Toplam Vefat",
            "Ağır Hasta",
            "Zaturre Olasılığı",
            "Toplam Entübe",
            "Toplam Yoğun Bakım"});
            this.cboxAramaAlani.Location = new System.Drawing.Point(6, 33);
            this.cboxAramaAlani.Name = "cboxAramaAlani";
            this.cboxAramaAlani.Size = new System.Drawing.Size(183, 32);
            this.cboxAramaAlani.TabIndex = 2;
            // 
            // FrmAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 114);
            this.Controls.Add(this.gBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAra";
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.ComboBox cboxAramaAlani;
        private System.Windows.Forms.ComboBox cboxSecilenKriter;
    }
}