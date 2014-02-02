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
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Results",
                url: "Home/Results",
                defaults: new {controller = "Home", action = "Results"}
                );

            routes.MapRoute(
                name: "FutureEvents",
                url: "Home/FutureEvents",
                defaults: new {controller = "Home", action = "FutureEvents"}
                );

            routes.MapRoute(
                name: "MeetTheTeam",
                url: "Home/MeetTheTeam",
                defaults: new {controller = "Home", action = "MeetTheTeam"}
                );

            routes.MapRoute(
                name: "ContactUs",
                url: "Home/ContactUs",
                defaults: new {controller = "Home", action = "ContactUs"}
                );
        }
    }
}