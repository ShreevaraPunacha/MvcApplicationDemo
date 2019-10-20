using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationDemo.Controllers
{
    public class Music1Controller : Controller
    {
        [ActionName("store")]
        public ActionResult Index()
        {
            return View();
        }

    }
}