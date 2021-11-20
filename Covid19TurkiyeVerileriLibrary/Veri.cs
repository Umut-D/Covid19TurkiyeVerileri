using System.Globalization;
using Newtonsoft.Json;

namespace Covid19TurkiyeVerileriLibrary
{
    public class Veri
    {
        [JsonProperty("tests")] public double TestSayisi { get; set; }
        [JsonProperty("cases")] public double Vaka { get; set; }
        [JsonProperty("patients")] public double? Hasta { get; set; }
        [JsonProperty("recovered")] public double? Iyilesen { get; set; }
        [JsonProperty("deaths")] public double? Vefat { get; set; }
        [JsonProperty("totalTests")] public double? ToplamTestSayisi { get; set; }
        [JsonProperty("totalPatients")] public double? ToplamHasta { get; set; }
        [JsonProperty("totalRecovered")] public double? ToplamIyilesen { get; set; }
        [JsonProperty("totalDeaths")] public double? ToplamVefat { get; set; }
        [JsonProperty("critical")] public double? AgirHasta { get; set; }

        private dynamic _zaturreOlasiligi;

        [JsonProperty("pneumoniaPercent")]
        public dynamic ZaturreOlasiligi
        {
            get
            {
                if (double.TryParse(_zaturreOlasiligi, out double sifir))
                    return _zaturreOlasiligi;

                return sifir.ToString(CultureInfo.InvariantCulture).Replace("0", "");
            }
            set => _zaturreOlasiligi = value.Replace("%", "");
        }

        [JsonProperty("totalIntubated")] public double? ToplamEntube { get; set; }
        [JsonProperty("totalIntensiveCare")] public double? ToplamYogunBakim { get; set; }
    }
}