using System.Web.Mvc;

namespace Dicket.WebApiServices.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("WebApi服务已开启......");
        }
    }
}