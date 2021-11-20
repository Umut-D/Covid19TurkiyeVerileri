using System.Collections.Generic;
using System.Linq;

namespace Covid19TurkiyeVerileriLibrary.Sayilar
{
    public class Hasta : VeriListesi, IIslem
    {
        public Hasta(Indir indir) : base(indir)
        {
        }

        public IEnumerable<KeyValuePair<string, Veri>> Buyuktur(int sayi)
        {
            return Indir.Veriler.Where(p => p.Value.Hasta > sayi).Select(p => p).ToList();
        }

        public IEnumerable<KeyValuePair<string, Veri>> BuyukEsittir(int sayi)
        {
            return Indir.Veriler.Where(p => p.Value.Hasta >= sayi).Select(p => p);
        }

        public IEnumerable<KeyValuePair<string, Veri>> Kucuktur(int sayi)
        {
            return Indir.Veriler.Where(p => p.Value.Hasta < sayi).Select(p => p);
        }

        public IEnumerable<KeyValuePair<string, Veri>> KucukEsittir(int sayi)
        {
            return Indir.Veriler.Where(p => p.Value.Hasta <= sayi).Select(p => p);
        }
    }
}