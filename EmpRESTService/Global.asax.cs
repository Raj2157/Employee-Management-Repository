﻿using System;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;

namespace EmpRESTService
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            // Edit the base address of Service1 by replacing the "Service1" string below
            RouteTable.Routes.Add(new ServiceRoute("Service1", new WebServiceHostFactory(), typeof(Service1)));
        }
    }
}
