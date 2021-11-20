using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel.Application;

namespace Covid19TurkiyeVerileriLibrary
{
    public class Dosya
    {
        public string KayitYeri { get; set; }
        private readonly ICollection _lstVerilerItems;
        private readonly ToolStripStatusLabel _tsslDurum;
        private Excel _excel;
        private int _veriSayisi;

        public Dosya(ICollection lstVerilerItems, ToolStripStatusLabel tsslDurum)
        {
            _lstVerilerItems = lstVerilerItems;
            _tsslDurum = tsslDurum;
        }

        public async void Kaydet()
        {
            if (ExcelYukluMu())
                return;

            _excel = new Excel();
            Workbook kitap = _excel.Workbooks.Add();
            Worksheet sayfa = _excel.Worksheets.Add();

            BasliklariYaz(sayfa);
            await Task.Run(() => { IcerikleriYaz(_lstVerilerItems, sayfa); });

            KitapKaydet(kitap);
            ExceliKapat(sayfa, kitap);
        }

        private bool ExcelYukluMu()
        {
            return Type.GetTypeFromProgID("Excel.Application") == null;
        }

        private void BasliklariYaz(Worksheet sayfa)
        {
            Veri veri = new Veri();

            int sutun = 2;
            sayfa.Cells[1, sutun - 1] = "Tarih";
            foreach (var baslik in veri.GetType().GetProperties())
            {
                sayfa.Cells[1, sutun] = baslik.Name;
                sutun++;
            }

            sayfa.Cells.EntireRow.Range["a1"].Font.Bold = true;
            sayfa.Cells.Range["a1"].Select();
        }

        private void IcerikleriYaz(IEnumerable lstVerilerItems, Worksheet sayfa)
        {
            _veriSayisi = 0;
            int satirIndeksi = 2;
            foreach (ListViewItem itemRow in lstVerilerItems)
            {
                HucrelereYaz(sayfa, satirIndeksi, itemRow);

                satirIndeksi++;
                _veriSayisi++;

                IlerlemeDurumu();
            }

            sayfa.Columns.AutoFit();
        }

        private void HucrelereYaz(Worksheet sayfa, int satirIndeksi, ListViewItem itemRow)
        {
            sayfa.Cells[satirIndeksi, 1] = Convert.ToDateTime(itemRow.SubItems[0].Text);
            for (int i = 2; i <= 14; i++)
                sayfa.Cells[satirIndeksi, i] = itemRow.SubItems[i - 1].Text;
        }

        private void IlerlemeDurumu()
        {
            int toplamVeriSayisi = _lstVerilerItems.Count;
            _tsslDurum.Text =
                $@"Veriler Excel'e kaydediliyor. Lütfen bekleyiniz... {_veriSayisi} / {toplamVeriSayisi} ";

            if (_veriSayisi == toplamVeriSayisi)
                _tsslDurum.Text = @"Tüm veriler başarıyla kaydedildi";
        }

        private void KitapKaydet(Workbook kitap)
        {
            kitap.SaveAs(KayitYeri, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true,
                false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing,
                Type.Missing);
        }

        // Verileri kayıt için açılan Excel'i hafızadan düşmek baya meşakkatli işmiş
        private void ExceliKapat(Worksheet sayfa, Workbook kitap)
        {
            kitap.Close();
            _excel.Quit();

            Marshal.ReleaseComObject(sayfa);
            Marshal.ReleaseComObject(kitap);
            Marshal.ReleaseComObject(_excel);

            _excel = null;
            GC.Collect();
        }
    }
}