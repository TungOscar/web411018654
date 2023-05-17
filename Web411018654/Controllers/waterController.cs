using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web411018654.Controllers
{
    public class waterController : Controller
    {
        // GET: water
        public ActionResult Index(String name,float?weight)
        {
            var result = "";
            if (weight.HasValue)
            {
                result = (weight * 30) + "CC";
            }
            ViewBag.Name = name;
            ViewBag.Result = result;
            return View();
        }
    }
}