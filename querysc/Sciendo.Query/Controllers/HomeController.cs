﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Sciendo.Query.DataProvider;
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

            return Json(new ResultsProvider().GetResultRows(criteria), JsonRequestBehavior.AllowGet);
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
