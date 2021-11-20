using System.Collections.Generic;
using System.Linq;

namespace Covid19TurkiyeVerileriLibrary.Sayilar
{
    public class ToplamEntube : VeriListesi, IIslem
    {
        public ToplamEntube(Indir indir) : base(indir)
        {
        }

        public IEnumerable<KeyValuePair<string, Veri>> Buyuktur(int sayi)
        {
            return Indir.Veriler.Where(p => p.Value.ToplamEntube > sayi).Select(p => p);
        }

        public IEnumerable<KeyValuePair<string, Veri>> BuyukEsittir(int sayi)
        {
            return Indir.Veriler.Where(p => p.Value.ToplamEntube >= sayi).Select(p => p);
        }

        public IEnumerable<KeyValuePair<string, Veri>> Kucuktur(int sayi)
        {
            return Indir.Veriler.Where(p => p.Value.ToplamEntube < sayi).Select(p => p);
        }

        public IEnumerable<KeyValuePair<string, Veri>> KucukEsittir(int sayi)
        {
            return Indir.Veriler.Where(p => p.Value.ToplamEntube <= sayi).Select(p => p);
        }
    }
}