using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Covid19TurkiyeVerileriLibrary;
using Covid19TurkiyeVerileriLibrary.Sabitler;

namespace Covid19TurkiyeVerileri
{
    public partial class FrmAra : Form
    {
        private readonly FrmCovid19TurkiyeVerileri _frmAna;
        private readonly Indir _indir;

        public FrmAra()
        {
            InitializeComponent();

            cboxAramaAlani.SelectedIndex = 0;
            cboxSecilenKriter.SelectedIndex = 0;
        }

        public FrmAra(FrmCovid19TurkiyeVerileri frmAna, Indir indir) : this()
        {
            _frmAna = frmAna;
            _indir = indir;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            var sonuc = Filtrele(
                sinif: SinifTipi.AramaTuru(cboxAramaAlani.SelectedIndex),
                metot: SecilenOperatorTuru(),
                indir: _indir,
                degerler: new object[] { GirilenSayi() });

            _frmAna.ListViewYukle((IEnumerable<KeyValuePair<string, Veri>>)sonuc);
        }

        private object Filtrele(Type sinif, string metot, Indir indir, object[] degerler)
        {
            ConstructorInfo yapiciMetot = sinif.GetConstructor(new[] { typeof(Indir) });
            object nesne = yapiciMetot?.Invoke(new object[] { indir });
            MethodInfo metotBilgi = nesne?.GetType().GetMethod(metot);
            return metotBilgi?.Invoke(nesne, degerler);
        }

        private string SecilenOperatorTuru()
        {
            var secilenOperator = (Operator)cboxSecilenKriter.SelectedIndex;
            return secilenOperator.ToString();
        }

        private int GirilenSayi()
        {
            int sayi = 0;
            if (!string.IsNullOrWhiteSpace(txtSayi.Text))
                sayi = int.Parse(txtSayi.Text);

            return sayi;
        }

        private void TxtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}