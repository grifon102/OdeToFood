using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CusineController : Controller
    {
        // GET: Cusine
        [Authorize]
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name = "french");
            return Content(message);
            
        }
    }
}