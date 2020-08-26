using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biletall.Web.Models
{
    public class KaraNokta
    {
        public string ID { get; set; }
        public string SeyahatSehirID { get; set; }
        public string Bolge { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string MerkezMi { get; set; }
        public string BagliOlduguNoktaID { get; set; }
    }
}
