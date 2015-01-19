using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Sciendo.Query.Filters;
using Sciendo.Query.Models;

namespace Sciendo.Query.Controllers
{
    [ValidateHttpAntiForgeryToken]
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Search(string criteria)
        {

            return Json(new ResultRow[]
            {
                new ResultRow { album = "1album", artist = "1artist", filePath = "1filePath", lyrics = "1lyrics", title = "1title" }, 
                new ResultRow { album = "2album", artist = "2artist", filePath = "2filePath", lyrics = "2lyrics", title = "2title" },
                                new ResultRow { album = "1album", artist = "1artist", filePath = "1filePath", lyrics = "1lyrics", title = "1title" }, 
                new ResultRow { album = "2album", artist = "2artist", filePath = "2filePath", lyrics = "2lyrics", title = "2title" },
                                new ResultRow { album = "1album", artist = "1artist", filePath = "1filePath", lyrics = "1lyrics", title = "1title" }, 
                new ResultRow { album = "2album", artist = "2artist", filePath = "2filePath", lyrics = "2lyrics", title = "2title" }


            }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Search tool for music collection";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }
    }
}
