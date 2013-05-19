using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndioMendoza2013.Controllers
{
    public class SharedController : Controller
    {
        //
        // GET: /Shared/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            return PartialView();
        }

    }
}
