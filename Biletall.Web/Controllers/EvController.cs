using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biletall.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biletall.Web.Controllers
{
    public class EvController : Controller
    {
        [HttpPost]
        [Route("test1")]
        public IActionResult Index(string values)
        {
           
            TempData["values"] = values;
            return RedirectToAction("Index", "Rezervasyon");
        }
    }
}
