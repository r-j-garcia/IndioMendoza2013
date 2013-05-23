using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndioMendoza2013.Controllers
{
    public class InfoController : Controller
    {
        //
        // GET: /Info/

        public ActionResult DondeEs()
        {
            ViewBag.MenuSeleccionado = "DONDEES";
            return View();
        }

        public ActionResult ComoLlegar()
        {
            ViewBag.MenuSeleccionado = "COMOLLEGAR";
            return View();
        }

        public ActionResult DondeComprar()
        {
            ViewBag.MenuSeleccionado = "DONDECOMPRAR";
            return View();
        }

    }
}
