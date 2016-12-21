using PrintumCommerce.ClassHelper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace PrintumCommerce
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //config.EnableCors();
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Models.Access.Model1, Migrations.Model1.ConfigurationB>());
          //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Models.DBPrintumContext, Migrations.DBPrintumContext.ConfigurationB>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Models.DBPrintumContext, Migrations.DBPrintumContext.Configuration>());
            CheckRolesAndSuperUsers();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void CheckRolesAndSuperUsers()
        {
            UsersHelper.CheckRole("AdminSystem");
            UsersHelper.CheckRole("User");
            UsersHelper.CheckSuperUser();
        }
    }
}
