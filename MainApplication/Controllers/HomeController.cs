using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MainApplication.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Main()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Locations()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Locations(string s)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Maintenance()
        {
            return View();
        }

        [HttpGet]
        public ActionResult PriceList()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Repair()
        {
            return View();
        }


    }
}
