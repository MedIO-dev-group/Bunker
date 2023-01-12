﻿using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
namespace BUNKER
{
    public class Global : HttpApplication
    {
        public readonly UserConnectionHub servHub = new UserConnectionHub();

        void Application_Start(object sender, EventArgs e)
        {
            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            GlobalHost.Configuration.DisconnectTimeout = TimeSpan.FromSeconds(6);
            GlobalHost.Configuration.KeepAlive = TimeSpan.FromSeconds(2);
        }

    }
}