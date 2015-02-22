using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tomstahl.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Call or write.  I look forward to hearing from you!";

            return View();
        }
        public ActionResult Test()
        {
            ViewBag.Message = "Your resume page.";

            return View();
        }

    }
}