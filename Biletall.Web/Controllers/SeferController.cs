using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biletall.Web.BusinesLogic;
using Biletall.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biletall.Web.Controllers
{
    public class SeferController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult KoltukBilgisi(string seferReferans)
        {
            var koltukInfo = BiletAllService.KoltukBilgisiAl(seferReferans);
            return Json(new Response
            {
                Status = true,
                Data = koltukInfo
            });
        }
    }
}
