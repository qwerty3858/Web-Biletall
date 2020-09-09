using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biletall.Web.Data.Entity
{
    public class Rezervasyon
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }
        public string Tc { get; set; }
        public string  Mail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
