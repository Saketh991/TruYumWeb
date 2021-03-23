using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TruYumWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "Cart",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "MenuItemAdmin",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "MenuItemAdmin", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "MenuItems",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "MenuItems", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
       
    }
}
