using Biletall.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biletall.Web.Models
{
    public class MusteriViewModel
    {
        //public Sefer sefer { get; set; }
        public string SeferId { get; set; }
        public List<PostData> SelectedData { get; set; }
    }
}
