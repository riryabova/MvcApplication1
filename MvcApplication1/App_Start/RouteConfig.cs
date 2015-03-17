using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

           routes.MapRoute(
                name: "test1",
                url: "test1",
                defaults: new { controller = "test1", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "test2",
               url: "test2",
               defaults: new { controller = "test2", action = "Index", id = UrlParameter.Optional }
           );
          
        }
    }
}