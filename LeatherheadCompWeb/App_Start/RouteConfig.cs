using System.Web.Mvc;
using System.Web.Routing;

namespace LeatherheadCompWeb.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "",
                url: "Results",
                defaults: new { controller = "Results", action = "Index" }
                );

            routes.MapRoute(
              name: "",
              url: "Horsham",
              defaults: new { controller = "Horsham", action = "Index" }
              );

            routes.MapRoute(
               name: "",
               url: "Reports",
               defaults: new { controller = "Reports", action = "Index" }
               );

            routes.MapRoute(
                name: "",
                url: "FutureEvents",
                defaults: new { controller = "FutureEvents", action = "Index" }
                );

            routes.MapRoute(
                name: "",
                url: "Home/MeetTheTeam",
                defaults: new {controller = "Home", action = "MeetTheTeam"}
                );

            routes.MapRoute(
                name: "",
                url: "Home/ContactUs",
                defaults: new {controller = "Home", action = "ContactUs"}
                );

            routes.MapRoute(
                name: "",
                url: "DanceRelated",
                defaults: new { controller = "DanceRelated", action = "Index" }
                );
        }
    }
}