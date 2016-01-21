using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public JsonResult Source()
        {
            var kvp = new Dictionary<string, string>();
            kvp.Add("Windows Blergy Blergy", "Test");
            return Json(kvp, JsonRequestBehavior.AllowGet);

        }







    }
}