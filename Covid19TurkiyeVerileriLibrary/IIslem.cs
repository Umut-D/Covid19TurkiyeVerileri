using System.Collections.Generic;

namespace Covid19TurkiyeVerileriLibrary
{
    public interface IIslem
    {
        IEnumerable<KeyValuePair<string, Veri>> Buyuktur(int sayi);
        IEnumerable<KeyValuePair<string, Veri>> BuyukEsittir(int sayi);
        IEnumerable<KeyValuePair<string, Veri>> Kucuktur(int sayi);
        IEnumerable<KeyValuePair<string, Veri>> KucukEsittir(int sayi);
    }
}