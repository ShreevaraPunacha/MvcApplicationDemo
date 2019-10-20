using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationDemo.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        public ActionResult Index()
        {
            return View();
        }

        public string Welcome1()
        {
            return "Hello, this is welcome action message";
        }

        // Below must be accessible by this URL: Music/ShowMusic?MusicTitle=Classical
        public string ShowMusic(string MusicTitle)
        {
            return "You selected " + MusicTitle + " Music";
        }
    }
}