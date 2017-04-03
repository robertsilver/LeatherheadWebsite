using System.Web.Mvc;
using LeatherheadCompWeb.Models;

namespace LeatherheadCompWeb.Controllers
{
    public class ResultsController : Controller
    {
        public ActionResult Index()
        {
            var url = Helper.AppSetting("JSON.Results");
            var results = Leatherhead.Business.Results.GetAll(url);

            return View(results);
        }
    }
}
