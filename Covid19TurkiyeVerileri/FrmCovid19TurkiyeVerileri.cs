using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Covid19TurkiyeVerileri.Properties;
using Covid19TurkiyeVerileriLibrary;

namespace Covid19TurkiyeVerileri
{
    public partial class FrmCovid19TurkiyeVerileri : Form
    {
        private Indir _indir;

        public FrmCovid19TurkiyeVerileri()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            SutunGenisliginiOtomatikAyarla();
        }

        private void SutunGenisliginiOtomatikAyarla()
        {
            for (int i = 0; i < lstVeriler.Columns.Count; i++)
                lstVeriler.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private async void TsbIndir_Click(object sender, EventArgs e)
        {
            IndirButonAktif(false);

            if (Baglanti.InternetVarMi())
            {
                _indir = new Indir();
                await _indir.VerileriSiraliYukle();
                ListViewYukle(_indir.Veriler);

                SayisalBilgiler();
            }

            IndirButonAktif(true);
        }

        private void IndirButonAktif(bool durum)
        {
            tsbIndir.Enabled = durum;
        }

        public void ListViewYukle(IEnumerable<KeyValuePair<string, Veri>> veriler)
        {
            lstVeriler.Items.Clear();

            foreach (var kvp in veriler)
            {
                ListViewItem lvi = lstVeriler.Items.Add(kvp.Key);
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value.TestSayisi:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value.Vaka:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.Hasta:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.Iyilesen:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.Vefat:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.ToplamTestSayisi:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.ToplamHasta:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.ToplamIyilesen:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.ToplamVefat:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.AgirHasta:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.ZaturreOlasiligi:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.ToplamEntube:#,0}"));
                lvi.SubItems.Add(string.Join(", ", $"{kvp.Value?.ToplamYogunBakim:#,0}"));
            }

            SutunGenisliginiOtomatikAyarla();

            SayisalBilgiler();
        }

        private void SayisalBilgiler()
        {
            int veriSayisi = lstVeriler.Items.Count;
            if (veriSayisi > 0)
            {
                string ilkVeri = lstVeriler.Items[0].SubItems[0].Text;
                string sonVeri = lstVeriler.Items[veriSayisi - 1].SubItems[0].Text;

                string ilkTarih = Convert.ToDateTime(ilkVeri).ToLongDateString();
                string sonTarih = Convert.ToDateTime(sonVeri).ToLongDateString();

                tsslDurum.Text = $@"{sonTarih} - {ilkTarih} tarihleri arasında, {veriSayisi} adet veri gösterildi.";
            }
        }

        private void TsbAra_Click(object sender, EventArgs e)
        {
            using (FrmAra frmAra = new FrmAra(this, _indir))
                frmAra.ShowDialog();
        }

        private void TsbKaydet_Click(object sender, EventArgs e)
        {
            if (sfdKaydet.ShowDialog() != DialogResult.OK)
                return;

            Dosya dosya = new Dosya(lstVeriler.Items, tsslDurum)
            {
                KayitYeri = sfdKaydet.FileName
            };
            dosya.Kaydet();
        }

        private void TsbBilgi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.ProgramaDair + Environment.NewLine + Environment.NewLine + Resources.OzanErturkeDair,
                @"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}