using System.Collections.Generic;
using System.Data.OleDb;
using System.Web.Mvc;
using MainApplication.DataAccess;
using MainApplication.Models;

namespace MainApplication.Controllers
{
    public class HomeController : Controller
    {
        private Data _data;
        public HomeController()
        {
            _data = new Data();
            _data.Load();
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
            ViewData["Comments"] = new List<string>
                {
                    _data.Comment[0].Value,
                    _data.Comment[1].Value,
                };
            return View();
        }

        [HttpPost]
        public ActionResult Comments(CommentModel model)
        {
            _data.Comment.AddCommentRow("1", model.Comment);
            _data.SaveChanges();
            return RedirectToAction("Comments");
        }


    }
}
