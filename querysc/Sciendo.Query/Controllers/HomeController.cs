using System.Configuration;
using System.Web;
using System.Web.Mvc;
using Sciendo.Query.Contracts;
using Sciendo.Query.DataProviders;
using Sciendo.Query.Filters;

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
            return
                Json(
                    ContainerConfig.Container.Resolve<IResultsProvider>(
                        ((QueryConfigurationSection) ConfigurationManager.GetSection("query")).CurrentDataProvider)
                        .GetResultRows(criteria), JsonRequestBehavior.AllowGet);
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
