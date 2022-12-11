using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace tp3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             "Afficher",                                           // Route name
             "personne/{id}",                            // URL with parameters
            defaults: new { controller = "Person", action = "Afficher", id = 7 }  // Parameter defaults
         );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Afficher", id = UrlParameter.Optional }
            ); 
         
           

          
           
        }
    }
}
