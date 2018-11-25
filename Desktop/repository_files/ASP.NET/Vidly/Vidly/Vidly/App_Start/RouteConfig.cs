using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //****************OLD WAY****************        
            //routes.MapRoute(
            //    "MoviesByReleaseDate",                                                   //name of the parameter. MapRoute takes several parameters but the most common used takes three.
            //    "movies/released/{year}/{month}",                                        //URL order, the curly braces are the parameters
            //    new {controller = "Movies", action = "ByReleaseDate"},                   //Defaults
            //    new {year = @"\d{4}", month = @"\d{2}"});  

            routes.MapMvcAttributeRoutes();                 // <---- New Way that is shown in movies/random

            routes.MapRoute(
                "Customer",
                "customer/index/{id}",
                new {controller = "customer", action = "Index", id = UrlParameter.Optional}
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
