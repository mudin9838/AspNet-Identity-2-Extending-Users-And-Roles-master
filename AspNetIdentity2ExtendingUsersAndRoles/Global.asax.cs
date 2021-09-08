using IdentitySample.Models;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using IdentitySample;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Web;
using DevExpress.DashboardWeb.Mvc;
using AspNetIdentity2ExtendingUsersAndRoles;
using AspNetIdentity2ExtendingUsersAndRoles.Models;

namespace AspNetIdentity2ExtendingUsersAndRoles
{
    // Note: For instructions on enabling IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=301868
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DevExpress.XtraReports.Web.QueryBuilder.Native.QueryBuilderBootstrapper.SessionState = System.Web.SessionState.SessionStateBehavior.Disabled;
            DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage(Server.MapPath("App_Data")));
            DashboardConfigurator.PassCredentials = true;
            DashboardConfig.RegisterService(RouteTable.Routes);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DevExpress.Web.Mvc.MVCxQueryBuilder.StaticInitialize();
        }
    }
}
