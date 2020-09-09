
using System.Collections.Generic;

namespace Biletall.Web.Models
{
    public class Sefer
    {
        public string ID { get; set; }
        public string FirmaAdi { get; set; }
        public string KalkisSaati { get; set; }
        public string Koltuk { get; set; }
        public string YaklasikSeyahatSuresi { get; set; }
        public string VarisNokta { get; set; }
        public string KalkisNokta { get; set; }
        public string OTipOzellik { get; set; }
        public int BiletFiyatiInternet { get; set; }
        public int BiletFiyati1 { get; set; }
        public string OtobusKoltukYerlesimTipi { get; set; }
        public List<Guzergah> Guzergahlar { get; set; }
        public string SeferTakipNo { get; set; }

        


    }
}
