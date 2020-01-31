using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OFB_NEWS.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Newsbreak()
        {
            //TODO
            return PartialView();
        }
    }
}