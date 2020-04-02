using Microsoft.AspNetCore.Mvc;

namespace niaphilanthropy.com.Web.Controllers
{
    public class HomeController : comControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}