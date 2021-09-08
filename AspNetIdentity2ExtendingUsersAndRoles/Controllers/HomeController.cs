using System.Web.Mvc;
using DevExpress.DataAccess.Web;
namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public ActionResult DashboardDesigner()
        //{
           

        //    return View("DashboardDesigner");
        //}


    }
}
