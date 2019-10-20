using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationDemo.Controllers
{
    public class Music2Controller : Controller
    {
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Show()
        {
            return View();
        }
    }
}