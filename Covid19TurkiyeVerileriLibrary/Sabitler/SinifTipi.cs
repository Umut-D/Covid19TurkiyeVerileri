using System;
using Covid19TurkiyeVerileriLibrary.Sayilar;

namespace Covid19TurkiyeVerileriLibrary.Sabitler
{
    public static class SinifTipi
    {
        public static Type AramaTuru(int indeks)
        {
            switch (indeks)
            {
                case 0:
                    return typeof(TestSayisi);
                case 1:
                    return typeof(Vaka);
                case 2:
                    return typeof(Hasta);
                case 3:
                    return typeof(Iyilesen);
                case 4:
                    return typeof(Vefat);
                case 5:
                    return typeof(ToplamTestSayisi);
                case 6:
                    return typeof(ToplamHasta);
                case 7:
                    return typeof(ToplamIyilesen);
                case 8:
                    return typeof(ToplamVefat);
                case 9:
                    return typeof(AgirHasta);
                case 10:
                    return typeof(ZaturreOlasiligi);
                case 11:
                    return typeof(ToplamEntube);
                default:
                    return typeof(ToplamYogunBakim);
            }
        }
    }
}