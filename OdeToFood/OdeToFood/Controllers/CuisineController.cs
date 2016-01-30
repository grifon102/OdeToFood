using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [HttpPost]
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name="french");
            return Content(message);
            //return RedirectToAction("Index","Home", new { name = name });
            //return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            //return Json(new { Message = message, Name = "Alexej" }, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult Search()
        {
            
            return Content("Hello world!!!");
            //return RedirectToAction("Index","Home", new { name = name });
            //return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            //return Json(new { Message = message, Name = "Alexej" }, JsonRequestBehavior.AllowGet);
        }
    }
}