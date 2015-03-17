using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class test2Controller : Controller
    {
        //
        // GET: /test2/

        public ActionResult Index()
        {
            ViewBag.message = "Сегодня:" + DateTime.Now;
            ViewBag.message = "А это test2";
            return View();

        }

    }
}
