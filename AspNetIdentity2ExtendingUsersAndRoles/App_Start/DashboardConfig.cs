using System.Web.Routing;
using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DataAccess.Web;

namespace AspNetIdentity2ExtendingUsersAndRoles
{
    public class DashboardConfig
    {
        public static void RegisterService(RouteCollection routes)
        {
            routes.MapDashboardRoute();

            // Uncomment this line to save dashboards to the App_Data folder.
            DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage(@"~/App_Data/"));
            DashboardConfigurator.Default.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
            // Uncomment these lines to create an in-memory storage of dashboard data sources. Use the DataSourceInMemoryStorage.RegisterDataSource
            // method to register the existing data source in the created storage.
            var dataSourceStorage = new DataSourceInMemoryStorage();
            DashboardConfigurator.Default.SetDataSourceStorage(dataSourceStorage);
        }
    }
}