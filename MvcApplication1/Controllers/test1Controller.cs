using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class test1Controller : Controller
    {
        //
        // GET: /test1/

        public ActionResult Index()
        {
            
            ViewBag.message = "Это test1";
            return View();
        }

    }
}
