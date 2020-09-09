using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biletall.Web.BusinesLogic;
using Biletall.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Biletall.Web.Controllers
{
    public class RezervasyonController : Controller
    {
        
        public IActionResult Index()
        {
            //string values = TempData["values"].ToString();

            //var result = JsonConvert.DeserializeObject<List<Values>>(values);
           
            return View();
        }
    }
    public class PostData
    {
        public int KoltukNo { get; set; }
        public string Gender { get; set; }
    }
   
}
