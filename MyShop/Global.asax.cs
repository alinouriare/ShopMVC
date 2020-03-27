using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using GSD.Globalization;
using System.Threading;

namespace MyShop
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Application["Online"] = 0;          
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var persianCulture = new PersianCulture();
            Thread.CurrentThread.CurrentCulture = persianCulture;
            Thread.CurrentThread.CurrentUICulture = persianCulture;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            int Online = int.Parse(Application["Online"].ToString());
            Online += 1;
            Application["Online"] = Online;
        }
        protected void Session_End(object sender, EventArgs e)
        {
            int Online = int.Parse(Application["Online"].ToString());
            Online -= 1;
            Application["Online"] = Online;
        }
        protected void Application_PostAuthorizeRequest()
        {
           
                HttpContext.Current.SetSessionStateBehavior(SessionStateBehavior.Required);
            
        }
    }
}