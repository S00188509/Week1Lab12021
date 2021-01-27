using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Tracker.WebAPIClient;

namespace Week1Lab12021
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ActivityAPIClient.Track(StudentID: "S00188509", StudentName: "Alan Regan", activityName: "Rad302 Week 1 Lab 1", Task: "Project Setup");


        }
    }
}
