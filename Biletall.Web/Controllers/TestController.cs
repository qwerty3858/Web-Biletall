using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Biletall.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            int a = Convert.ToInt32("aa");
            return View();
        }
    }

    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string exception = context.Exception.Message;
            string stackTrace = context.Exception.StackTrace;
            // save database exception
            context.Result = new RedirectToRouteResult(
                new RouteValueDictionary
                {
                    {"controller", "Home"},
                    {"action", "Index"}
                });
        }
    }
}
