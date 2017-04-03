using System;
using System.Web.Mvc;
using LeatherheadCompWeb.Models;

namespace LeatherheadCompWeb.Controllers
{
    public class FutureEventsController : Controller
    {
       public ActionResult Index()
        {
            var url = Helper.AppSetting("JSON.CompDates");
            var results = Leatherhead.Business.CompDates.Get(url, DateTime.Now);

            return View(results);
        }
    }
}
