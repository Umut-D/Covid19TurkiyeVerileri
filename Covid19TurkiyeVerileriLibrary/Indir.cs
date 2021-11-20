using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Covid19TurkiyeVerileriLibrary.Properties;
using Newtonsoft.Json;

namespace Covid19TurkiyeVerileriLibrary
{
    /// <summary>
    /// Veriler Ozan Ertürk’ün Covid-19 GitHub Repo'sundan indirilmektedir.
    /// <strong><a href="https://github.com/ozanerturk/covid19-turkey-api">(Github Link)</a></strong>
    /// </summary>
    [VeriSahibi(Repo = "Ozan Ertürk", Link = "https://github.com/ozanerturk/covid19-turkey-api")]
    public class Indir
    {
        public IEnumerable<KeyValuePair<string, Veri>> Veriler { get; private set; }

        public async Task VerileriSiraliYukle()
        {
            string covid19Verileri = await VerileriCek(Resources.Link);

            Veriler = new Dictionary<string, Veri>();
            Veriler = JsonConvert.DeserializeObject<Dictionary<string, Veri>>(covid19Verileri).Reverse();
        }

        private async Task<string> VerileriCek(string link)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            using (HttpClient httpIstem = new HttpClient())
                return await httpIstem.GetStringAsync(link);
        }
    }
}