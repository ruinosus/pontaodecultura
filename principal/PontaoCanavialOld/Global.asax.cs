using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace PontaoCanavial
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394810

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Pontinho",
                "{nomeIdentificador}",
                new { controller = "Ponto", action = "Index" }
            );


            routes.MapRoute(
                "Default",                                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Ponto", action = "Index", id = "" }  // Parameter defaults
            );


            //routes.MapRoute("teste", "Ponto/{nomeIdentificador}",
            //   new { controller = "Ponto", action = "Index" });
        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_AuthenticateRequest()
        {
            if (User != null)
                Membership.GetUser(true);
        }
    }
}