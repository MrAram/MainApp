using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MainApplication.Models;
using XMLDatabase.XMLDatabase;

namespace MainApplication.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            Data.XMLDataPath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/Database.xml");
        }
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

        [HttpGet]
        public ActionResult Comments()
        {
            ViewData["Comments"] = DataAccess.DataProvider.GetComments();
            return View();
        }

        [HttpPost]
        public ActionResult Comments(CommentModel model)
        {
            DataAccess.DataProvider.AddComment(model.Comment);
            return RedirectToAction("Comments");
        }


    }
}
